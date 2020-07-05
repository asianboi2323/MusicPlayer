using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System
{

	public partial class Form1 : Form
	{

		/// ***************************** CONSTUCTOR ********************************

		public Form1()
		{
			InitializeComponent();

			// reference init
			ScriptTabs = ScriptTabList.TabPages;

			// instance init
			Musics = new List<Music>();
			BeeperManager = new BeeperManager();

			// data init
			if (!LoadMusics())
			{
				Close();

				return;
			}

			MusicList.SelectedIndex = 0;
			PlayButton.Select();

			// ######## TESTING AREA ########

			//tra.ce(new Regex(@"\[[^\]]+\]").Replace(
			//	"1+. 1g 5[aoeu aoeu aoeu] 4d 1+ 5d."
			//,""));
		}

		/// ************************** PUBLIC PROPERTIES ****************************

		public TabControl.TabPageCollection ScriptTabs;

		public List<Music> Musics;
		public BeeperManager BeeperManager;

		/// ************************* PRIVATE PROPERTIES ****************************

		protected string dataUrl = @"Data.txt";

		/// *************************** PUBLIC METHODS ******************************

		public Music SearchMusicByName(object name)
		{
			string s = name.ToString();

			foreach (Music p in Musics)
			{
				if (p.Name == s)
					return p;
			}

			return null;
		}

		public Beeper GenerateBeeper(string key, string script, string bpmString, string volumeString, int partId = 0)
		{
			double bpm = 0, volume = 0;

			// remove comments
			script = new Regex(@"\[[^\]]+\]").Replace(script, "")
				.Replace("\n", " ");

			// check syntax
			try
			{
				bpm = double.Parse(bpmString);
				volume = double.Parse(volumeString) * 10;

				// replace "C#" with "Db"
				string letters = "ABCDEFGA";
				if (key.Length > 2 && key[1] == '#' && letters.IndexOf(key[0]) >= 0)
					key = letters[letters.IndexOf(key[0]) + 1].ToString() + "b" + key[2].ToString();

				// read special settings
				if (script.Length > 2 && script[0] == '@')
				{
					string settings = script.Substring(1, script.IndexOf(' ') - 1);
					script = script.Substring(settings.Length + 1);

					foreach (char p in settings)
					{
						if (p == '-')
							key = key.Substring(0, key.Length - 1) + (int.Parse(key[key.Length - 1].ToString()) - 1);
						else if (p == '+')
							key = key.Substring(0, key.Length - 1) + (int.Parse(key[key.Length - 1].ToString()) + 1);
						else
							throw new InvalidCastException("unknown special settings!");
					}
				}
			}
			catch (Exception ee)
			{
				ms.g("Nope", $"GET OUTTA HERE WITH DAT {format.error(ee)}!!");

				return null;
			}

			// create new Beeper instance
			try
			{
				return new Beeper(key, script, bpm, volume, partId);
			}
			catch (Exception ee)
			{
				if (!(ee is TaskCanceledException))
					ms.g("Nope", $"GET OUTTA HERE WITH DAT {format.error(ee)}!!");

				return null;
			}
		}

		public bool GenerateBeepStream(Beeper beeper)
		{
			try
			{
				beeper?.GenerateStream();
			}
			catch (Exception ee)
			{
				ms.g("Nope", $"GET OUTTA HERE WITH DAT {format.error(ee)}!!");

				return false;
			}

			return true;
		}

		public void StopBeeping()
		{
			if (BeeperManager.IsPlaying)
				BeeperManager.Stop();
		}

		public void SaveMusics()
		{
			/* this method writes the music data to local file, not adds a music */

			if (!File.Exists(dataUrl))
				File.CreateText(dataUrl).Close();

			List<string> data = new List<string>();

			foreach (Music p in Musics)
			{
				data.Add(p.Name);
				data.Add($"{p.Key} {p.Bpm}bpm");
				data.Add(string.Join(", ", p.Volumes));

				// replace new lines with \t so that it won't be confused with properties when reading
				data.Add(string.Join("; ", p.Scripts)
					.Replace("\n", "\t"));

				data.Add("");
			}

			File.WriteAllLines(dataUrl, data);
		}

		public bool LoadMusics()
		{
			/* this method reads music data from local file */

			Musics.Clear();
			MusicList.Items.Clear();

			if (File.Exists(dataUrl))
			{
				string[] data = File.ReadAllLines(dataUrl);

				Music music = new Music();
				string currentReading = "name"; // name, key and bpm, volumes, scripts

				string line = "";

				// check syntax in local file
				try
				{
					foreach (string p in data)
					{
						line = p;

						if (p == "")
						{
							if (music.Name != "")
							{
								Musics.Add(music);

								music = new Music();
							}

							currentReading = "name";

							continue;
						}

						// read each music by going over its name, key and bpm, volumes, and scripts data in order.
						switch (currentReading)
						{
							case "name":
								music.Name = p;
								currentReading = "key.and.bpm";
								break;

							case "key.and.bpm":
								string[] properties = p.Split(' ');
								music.Key = properties[0];
								music.Bpm = properties[1].Replace("bpm", "");

								currentReading = "volumes";
								break;

							case "volumes":
								music.Volumes = p.Split(new string[] { ", " }, StringSplitOptions.None).ToList();
								currentReading = "scripts";
								break;

							case "scripts":
								// replace tabs with new lines
								music.Scripts = p.Replace("\t", "\n")
									.Split(new string[] { "; " }, StringSplitOptions.None).ToList();

								currentReading = "get.outta.here";
								break;

							default:
								throw new DataMisalignedException("extra data/script is more than one line!");
						}
					}
				}
				catch (Exception ee)
				{
					ms.g("Bad Data!", $"GET OUTTA HERE WITH DAT {format.error(ee)} AT LINE\n\"{line}\"!!!");

					return false;
				}

				if (music.Name != "" && !Musics.Contains(music))
					Musics.Add(music);
			}

			// if music list is empty, add a default song "HELLO!"
			if (Musics.Count == 0)
			{
				Music music = new Music("HELLO!!", "Eb5", "120");

				music.Scripts.Add("1+. 1g 5 4d 1+ 5d.");

				music.Volumes.Add("100");

				Musics.Add(music);
			}

			foreach (Music p in Musics)
				MusicList.Items.Add(p.Name);

			return true;
		}

		/// *************************** PRIVATE METHODS *****************************

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			switch (keyData)
			{
				case Keys.Control | Keys.S:
					OnSaveButtonClick(null, null);
					return true;

				case Keys.F1:
					OnHelpButtonClick(null, null);
					return true;

				case Keys.Control | Keys.N:
					OnNewButtonClick(null, null);
					return true;

				case Keys.F5:
				case Keys.Control | Keys.Enter:
					OnPlayButtonClick(null, null);
					return true;
			}

			return base.ProcessCmdKey(ref msg, keyData);
		}

		/// ******************************* EVENTS **********************************

		protected void OnPlayButtonClick(object sender, EventArgs e)
		{
			StopBeeping();

			Beeper[] beepers = new Beeper[ScriptTabs.Count];
			for (int i = 0, l = ScriptTabs.Count; i < l; i++)
			{
				beepers[i] = GenerateBeeper(KeyText.Text, ScriptTabs[i].ToolTipText, BpmText.Text, ScriptTabs[i].ImageKey, i + 1);

				if (!GenerateBeepStream(beepers[i]))
					return;
			}

			BeeperManager.Play(beepers, RepeatCheck.Checked);
		}

		protected void OnPlayPartButtonClick(object sender, EventArgs e)
		{
			Beeper[] beepers = { GenerateBeeper(KeyText.Text, ScriptText.Text, BpmText.Text, VolumeText.Text) };

			if (GenerateBeepStream(beepers[0]))
				BeeperManager.Play(beepers, RepeatCheck.Checked);
		}

		protected void OnStopButtonClick(object sender, EventArgs e)
		{
			StopBeeping();
		}

		protected void OnOutputButtonClick(object sender, EventArgs e)
		{
			Beeper beeper = GenerateBeeper(KeyText.Text, ScriptText.Text, BpmText.Text, VolumeText.Text, ScriptTabList.SelectedIndex + 1);

			if (beeper != null)
			{
				string output = beeper.GetOutputCodes();

				if (output != null)
				{
					Clipboard.SetText(output);

					ms.g("Yay!", "THE CODE HAS BEEN COPIED TO YOUR CLIPBOARD!");
				}
			}
		}

		protected void OnHelpButtonClick(object sender, EventArgs e)
		{
			string s = "    • Spaces separate notes. In every note, 1..7 represent Do..Ti (notes in key), 1- thru 7- represent lower notes, and 1+ thru 7+ represent upper notes. A note can be followed by a '#' or a 'b'. (Examples: 1 3 4# 7b 2+ 5#-)";
			s += "\n    • For note types, 'o' means a whole note, 'd' means a half note, nothing means a quarter note, 'g' means an 8th note, and 'j' means a 16th note. A dot (.) followed by a note means a dotted note. (Examples: 1g 3. 5-d.)";
			s += "\n    • For rests, '/' means a quarter rest, ''' (single quote) means an 8th rest, and '\"' (double quote) means a 16th rest.";
			s += "\n    • '~' connects 2 notes. (Example: 1o~o represents a Do for 8 beats (two whole notes))";
			s += "\n\n    • Examples (in C key):\n\t1.\tC for 1.5 beats\n\t3+g.\tupper E for .75 beats\n\t5#-\tlower G# for 1 beat\n\t7bo~d.\tBb for 7 beats\n\t/ '\trest for 1.5 beats";
			s += "\n\n   • You can add up to 16 parts for a music. Putting '@+' at the beginning of the scripts to higher a part for an octave, and '@-' can lower a part for an octave.";
			s += "\n   • You can add comments in your script by using this syntax:\n\t[comments...]";
			s += "\n\n    • Hotkeys: Help(F1), Save(^S), New(^N), Play(^Enter), Stop(Esc)";
			s += "\n\n- This cute awesome program was brought to life by Nate and Asianboii -";
			s += "\n\n Version: 18-3-31";
			s += "\n Updated: 20-7-3";
			ms.g("HELP!!!", s);
		}

		protected void OnNewButtonClick(object sender, EventArgs e)
		{
			while (ScriptTabs.Count > 1)
				ScriptTabs.RemoveAt(ScriptTabs.Count - 1);

			NameText.Text = "";
			KeyText.Text = "C5";
			BpmText.Text = "120";
			VolumeText.Text = "100";

			ScriptTabList.SelectedTab.ToolTipText = ScriptText.Text = "";
			ScriptTabList.SelectedTab.ImageKey = VolumeText.Text = "100";

			MusicList.SelectedIndex = -1;

			ScriptText.Select();
		}

		protected void OnSaveButtonClick(object sender, EventArgs e)
		{
			if (NameText.Text == "")
			{
				ms.g("Err404", "GET OUTTA HERE WITH DAT MOOSIC'S NAME!!!");

				return;
			}

			ScriptTabList.SelectedTab.ToolTipText = ScriptText.Text;
			ScriptTabList.SelectedTab.ImageKey = VolumeText.Text;

			Music music = SearchMusicByName(NameText.Text);

			if (music != null)
			{
				if (MusicList.SelectedIndex == -1)
					if (ms.g("Override?", $"WANNA OVERRIDE MUSIC \"{music.Name}\"?", MessageBoxButtons.YesNo) == DialogResult.No)
						return;

				music.Name = NameText.Text;
				music.Key = KeyText.Text;
				music.Bpm = BpmText.Text;

				music.Scripts.Clear();
				music.Volumes.Clear();

				foreach (TabPage p in ScriptTabs)
				{
					music.Scripts.Add(p.ToolTipText);
					music.Volumes.Add(p.ImageKey);
				}

				MusicList.SelectedIndex = MusicList.Items.IndexOf(music.Name);
			}
			else
			{
				music = new Music(NameText.Text, KeyText.Text, BpmText.Text);

				foreach (TabPage p in ScriptTabs)
				{
					music.Scripts.Add(p.ToolTipText);
					music.Volumes.Add(p.ImageKey);
				}

				Musics.Add(music);
				MusicList.Items.Add(NameText.Text);
				MusicList.SelectedIndex = Musics.Count - 1;
			}

			SaveMusics();
		}

		protected void OnDeleteButtonClick(object sender, EventArgs e)
		{
			if (MusicList.SelectedIndex == -1)
			{
				ms.g("Hey", "PLZ SELECT WHATCHA WANNA DELETE!");

				return;
			}

			if (ms.g("DontDeleteThisStefan", $"RU SURE YOU WANNA DELETE \"{MusicList.SelectedItem}\"??", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				Musics.Remove(SearchMusicByName(MusicList.SelectedItem));
				MusicList.Items.Remove(MusicList.SelectedItem);

				SaveMusics();
			}
		}

		protected void OnMusicListSelectedIndexChanged(object sender, EventArgs e)
		{
			if (MusicList.SelectedIndex == -1)
				return;

			Music music = SearchMusicByName(MusicList.SelectedItem);

			if (ScriptTabs.Count < music.Scripts.Count)
			{
				while (ScriptTabs.Count < music.Scripts.Count)
					ScriptTabs.Add($"Part {ScriptTabs.Count + 1}");
			}
			else if (ScriptTabs.Count > music.Scripts.Count)
			{
				while (ScriptTabs.Count > music.Scripts.Count)
					ScriptTabs.RemoveAt(ScriptTabs.Count - 1);
			}

			for (int i = 0, l = music.Scripts.Count; i < l; i++)
			{
				ScriptTabs[i].ToolTipText = music.Scripts[i];
				ScriptTabs[i].ImageKey = music.Volumes[i];
			}

			NameText.Text = music.Name;
			KeyText.Text = music.Key;
			BpmText.Text = music.Bpm;

			if (ScriptTabList.SelectedIndex == 0)
			{
				OnScriptTabControlSelectedIndexChanged(null, null);
			}
			else
			{
				ScriptTabList.SelectedIndex = 0;
			}
		}

		protected void OnMusicListKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Back)
				OnDeleteButtonClick(null, null);
		}

		protected void OnPinCheckCheckedChanged(object sender, EventArgs e)
		{
			TopMost = PinCheck.Checked;
		}

		protected void OnRepeatCheckCheckedChanged(object sender, EventArgs e)
		{
			BeeperManager.IsLooping = RepeatCheck.Checked;
		}

		protected void OnAddPartButtonClick(object sender, EventArgs e)
		{
			if (ScriptTabs.Count == 64)
			{
				ms.g("No way", "TOO MANY PARTS! THAT'D BE EAR-RAPING!");

				return;
			}

			ScriptTabList.SelectedTab.ToolTipText = ScriptText.Text;
			ScriptTabList.SelectedTab.ImageKey = VolumeText.Text;

			ScriptTabs.Add($"Part {ScriptTabs.Count + 1}");

			ScriptTabList.SelectedIndex = ScriptTabs.Count - 1;

			ScriptTabList.SelectedTab.ToolTipText = ScriptText.Text = "";
			ScriptTabList.SelectedTab.ImageKey = VolumeText.Text = "100";

			ScriptText.Select();
		}

		protected void OnDeletePartButtonClick(object sender, EventArgs e)
		{
			if (ScriptTabs.Count == 1)
			{
				ms.g("Wait", "PLEASE DELETE WINDOWS/SYSTEM32 FOLDER BEFORE DELETEING THIS LAST DANG PART. :)");

				return;
			}

			ScriptTabs.Remove(ScriptTabList.SelectedTab);

			for (int i = 0, l = ScriptTabs.Count; i < l; i++)
				ScriptTabs[i].Text = $"Part {i + 1}";
		}

		protected void OnScriptTabControlSelectedIndexChanged(object sender, EventArgs e)
		{
			ScriptText.Text = ScriptTabList.SelectedTab.ToolTipText;
			VolumeText.Text = ScriptTabList.SelectedTab.ImageKey;
		}

		protected void OnScriptTextTextChanged(object sender, EventArgs e)
		{
			ScriptTabList.SelectedTab.ToolTipText = ScriptText.Text;
		}

		protected void OnVolumeTextTextChanged(object sender, EventArgs e)
		{
			ScriptTabList.SelectedTab.ImageKey = VolumeText.Text;
		}

		protected void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			Music music = MusicList.SelectedIndex >= 0 ? SearchMusicByName(MusicList.SelectedItem) : null;

			if (music == null ? (NameText.Text != "" || ScriptText.Text != "" || KeyText.Text != "" || BpmText.Text != "")
				: (NameText.Text != music.Name || music.Scripts.Count != ScriptTabs.Count || ScriptText.Text != music.Scripts[ScriptTabList.SelectedIndex] || KeyText.Text != music.Key || BpmText.Text != music.Bpm))
			{
				DialogResult result;
				if ((result = ms.g("Wait!", $"SAVE CHANGES OF MOOSIC \"{NameText.Text}\" BEFORE LEAVING??", MessageBoxButtons.YesNoCancel)) == DialogResult.Yes || result == DialogResult.Cancel)
				{
					if (result == DialogResult.Cancel || NameText.Text == "")
						e.Cancel = true;

					if (result == DialogResult.Yes)
						OnSaveButtonClick(null, null);
				}
			}

			StopBeeping();
		}

	}

}