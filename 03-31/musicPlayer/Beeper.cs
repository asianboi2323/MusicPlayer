using NAudio;
using NAudio.Wave;

using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System
{

	public class Beeper
	{

		/// ***************************** CONSTUCTOR ********************************

		public Beeper(string key, string script, double bpm, double volume = 1000, int partId = 0)
		{
			Volume = volume;

			Beeps = new List<Beep>();

			double mainFrequency = Note.FrequencyDict[key];

			int mainIndex = Note.Frequencies.IndexOf(mainFrequency);
			int[] toneIndices = { mainIndex, mainIndex + 2, mainIndex + 4, mainIndex + 5, mainIndex + 7, mainIndex + 9, mainIndex + 11 };

			Dictionary<char, double> durationDict = GetBeatDurations(bpm);

			string[] notes = script.Split(' ');

			double durationDecimal = 0;

			foreach (string p in notes)
			{
				try
				{
					if (p == "")
						continue;

					int tone = -1;

					if (int.TryParse(p[0].ToString(), out tone))
					{
						int noteIndex = toneIndices[tone - 1];
						int specIndex = 0;
						char noteType = '/';
						double duration = 0;
						double tempDur = 0;

						for (int i = 1, l = p.Length; i < l; i++)
						{
							if (p[i] == '+')
								noteIndex += 12;
							else if (p[i] == '-')
								noteIndex -= 12;
							else if (p[i] == 'b')
								specIndex--;
							else if (p[i] == '#')
								specIndex++;
							else if (durationDict.ContainsKey(p[i]))
							{
								noteType = p[i];
								tempDur = durationDict[noteType];

								if (i < l - 1 && p[i + 1] == '.')
								{
									tempDur *= 1.5;
									i++;
								}

								duration += tempDur;
							}
							else if (p[i] == '.')
							{
								duration += tempDur = durationDict['/'] * 1.5;
							}
							else if (p[i] == '~')
							{
								if (noteType == '/' && tempDur == 0)
									duration += durationDict['/'];

								noteType = '/';
								tempDur = 0;
							}
							else
								throw new InvalidExpressionException();
						}

						if (noteType == '/' && tempDur == 0)
							duration += durationDict['/'];

						double frequency = Note.Frequencies[noteIndex + specIndex];
						int intfreq = (int)Math.Round(frequency, 0);
						int intDuration = (int)duration + (int)durationDecimal;

						durationDecimal += duration % 1;

						Beeps.Add(new Beep(intDuration, frequency));

						durationDecimal %= 1;

						TotalDuration += intDuration;
					}
					else
					{
						double duration = durationDict[p[0]];
						int intDuration = (int)duration + (int)durationDecimal;

						durationDecimal += duration % 1;

						Beeps.Add(new Beep(intDuration));

						durationDecimal %= 1;

						TotalDuration += intDuration;
					}
				} // end try
				catch (Exception ee)
				{
					if (!(ee is ThreadAbortException))
					{
						if (ms.g("Oops!", $"GET OUTTA HERE WITH DAT {format.error(ee)} AT NOTE \"{p}\" IN PART {partId}!!\n\nCONTINUE ANYWAY?", MessageBoxButtons.YesNo) == DialogResult.Yes)
						{
							Beeps.Add(new Beep((int)durationDict['/']));

							TotalDuration += (int)durationDict['/'];
						}
						else
						{
							throw new TaskCanceledException("get outta this constructor!");
						}
					}
				}
			} // end for
		}

		/// ************************** PUBLIC PROPERTIES ****************************

		public BinaryWriter BinaryWriter;
		public MemoryStream Stream;
		public WaveOut Sound;
		public List<Beep> Beeps;
		public double Volume;
		public int TotalDuration;
		public bool IsPlaying;
		public bool IsLooping;

		/// ************************* PRIVATE PROPERTIES ****************************



		/// *************************** PUBLIC METHODS ******************************

		public string GetOutputCodes()
		{
			if (Beeps.Count == 0)
			{
				ms.g("`@!\\#?", "NO NOTES FOUND!");

				return null;
			}

			string output = "";

			foreach (Beep p in Beeps)
			{
				if (p.Frequency == 0)
					output += $"Thread.Sleep({p.Duration});\r\n";
				else
					output += $"Console.Beep({Math.Round(p.Frequency, 0)}, {p.Duration});\r\n";
			}

			return output.Substring(0, output.Length - 2);
		}

		public void GenerateStream()
		{
			int bytes = 441 * TotalDuration / 10 * 4;
			int[] hdr = { 0x46464952, 36 + bytes, 0x45564157, 0x20746D66, 16, 0x20001, 44100, 176400, 0x100004, 0x61746164, bytes };

			Stream = new MemoryStream();

			BinaryWriter = new BinaryWriter(Stream);

			foreach (int p in hdr)
				BinaryWriter.Write(p);

			foreach (Beep p in Beeps)
				AddNote(p.Duration, p.Frequency);
		}

		public void Play(bool looping = false)
		{
			Stream.Seek(0, SeekOrigin.Begin);

			Sound = new WaveOut(WaveCallbackInfo.FunctionCallback());
			Sound.Init(new WaveFileReader(Stream));

			Sound.PlaybackStopped += OnSoundPlayBackStopped;

			IsLooping = looping;

			Sound.Play();

			IsPlaying = true;
		}

		public void Stop()
		{
			IsPlaying = false;

			if (Sound == null)
				return;

			Sound.Stop();

			Sound.PlaybackStopped -= OnSoundPlayBackStopped;

			Sound.Dispose();

			IsLooping = false;
			Sound = null;
		}

		/// *************************** PRIVATE METHODS *****************************

		protected Dictionary<char, double> GetBeatDurations(double bpm)
		{
			Dictionary<char, double> dict = new Dictionary<char, double>();

			double quarter = 60000 / bpm;
			double half = quarter * 2;
			double whole = half * 2;
			double eighth = quarter / 2;
			double sixteenth = eighth / 2;
			double thirtysecond = sixteenth / 2;

			dict['o'] = whole;
			dict['d'] = half;
			dict['/'] = quarter;
			dict['\''] = eighth;
			dict['g'] = eighth;
			dict['\"'] = sixteenth;
			dict['j'] = sixteenth;
			dict['`'] = thirtysecond;

			return dict;
		}

		protected void AddNote(int duration, double frequency)
		{
			double amp = ((Volume * (System.Math.Pow(2, 15))) / 1000) - 1;
			double deltaFt = 2 * Math.PI * frequency / 44100.0;

			int Samples = 441 * duration / 10;

			for (int i = 0; i < Samples; i++)
			{
				short s = Convert.ToInt16(amp * Math.Sin(i * deltaFt));

				BinaryWriter.Write(s);
				BinaryWriter.Write(s);
			}

			BinaryWriter.Flush();
		}

		/// ******************************* EVENTS **********************************

		private void OnSoundPlayBackStopped(object sender, StoppedEventArgs e)
		{
			bool wasLooping = IsLooping;

			Stop();

			if (wasLooping)
				Play(true);
		}

	}

}
