using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beeptastic
{
	public static class Compiler
	{
		public static MemoryStream CompileTune(Tune tune, double masterVolume)
		{
			int duration = 0; // equal to the longest part
			List<List<Beep>> parts = new List<List<Beep>>();
			for (int i = 0; i < tune.Parts.Count; i++)
			{
				Part rawPart = tune.Parts[i];
				if (rawPart.IsMuted || rawPart.Volume == 0)
					continue;

				parts.Add(CompileScript(rawPart.Script, tune.Key, masterVolume * rawPart.Volume, tune.Bpm, out int temp));

				if (temp > duration)
					duration = temp;
			}

			MemoryStream stream = new MemoryStream();

			using (BinaryWriter writer = new BinaryWriter(stream))
			{
				// awesome code by Shawn Kovac
				// https://stackoverflow.com/questions/12611982/generate-audio-tone-to-sound-card-in-c-or-c-sharp
				// thank you Shawn

				const int formatChunkSize = 16, headerSize = 8, waveSize = 4;
				const short formatType = 1, tracks = 1, bitsPerSample = 16, frameSize = tracks * ((bitsPerSample + 7) / 8);

				int bytesPerSecond = Note.SampleRate * frameSize;
				int dataChunkSize = duration * frameSize;
				int fileSize = waveSize + headerSize + formatChunkSize + headerSize + dataChunkSize;

				writer.Write(0x46464952);
				writer.Write(fileSize);
				writer.Write(0x45564157);
				writer.Write(0x20746D66);
				writer.Write(formatChunkSize);
				writer.Write(formatType);
				writer.Write(tracks);
				writer.Write(Note.SampleRate);
				writer.Write(bytesPerSecond);
				writer.Write(frameSize);
				writer.Write(bitsPerSample);
				writer.Write(0x61746164);
				writer.Write(dataChunkSize);

				short[] buffer = new short[duration];
				foreach (List<Beep> part in parts)
				{
					int i = 0;
					foreach (Beep beep in part)
					{
						double theta = beep.Freq * 2 * Math.PI / Note.SampleRate;
						double amplitude = beep.Volume * 32_767;
						for (int step = 0; step < beep.Duration; step++, i++)
							buffer[i] += (short)(amplitude * Math.Sin(theta * step));

						Console.WriteLine($"{beep.Freq}, {beep.Duration}");
					}
				}

				foreach (short sample in buffer)
					writer.Write(sample);

				// TODO: move these
				stream.Seek(0, SeekOrigin.Begin);
				new System.Media.SoundPlayer(stream).PlaySync();
			}

			return stream;
		}

		public static List<Beep> CompileScript(string script, int key, double volume, double bpm, out int duration)
		{
			int currKey = key;
			double currVolume = volume, currBpm = bpm;
			double position = 0; // number of samples into the tune

			List<Beep> beeps = new List<Beep>();

			foreach (string token in GetNonCommentTokens(script))
			{
				if (token[0] == '@')
				{
					ParseSettings(token, ref currKey, ref currVolume, ref currBpm, key, volume, bpm);
					continue;
				}

				double noteDuration = 0, mult = 1.0;
				int i = token.Length - 1;
				while (i >= 0)
				{
					if (token[i] == '.')
						mult *= 1.5;
					else if (token[i] == 't')
						mult *= 2.0 / 3;
					else if (Durations.TryGetValue(char.ToLower(token[i]), out double temp))
					{
						noteDuration += temp * mult;
						mult = 1.0;
					}
					else // reaching the pitch code
						break;

					i--;
				}
				if (noteDuration == 0) // a default quarter note
					noteDuration = mult;

				double freq = 0;
				if (i >= 0) // an actual note (not a rest)
					freq = Note.GetFreq(Note.Parse(token.Substring(0, i + 1), currKey));

				beeps.Add(new Beep((int)(position + 0.5), freq, currVolume, (int)(noteDuration * 60 * Note.SampleRate / currBpm + 0.5)));

				position += noteDuration * 60 * Note.SampleRate / currBpm;
			}

			duration = (int)(position + 0.5);

			return beeps;
		}

		// comments starts with /* and ends with */
		private static IEnumerable<string> GetNonCommentTokens(string script)
		{
			bool isComment = false;

			foreach (string token in script.Split(' ', '\t', '\n'))
			{
				if (token.Length == 0)
					continue;

				if (isComment)
				{
					if (token.EndsWith("*/"))
						isComment = false;

					continue;
				}

				if (token.StartsWith("/*"))
				{
					isComment = true;
					continue;
				}

				yield return token;
			}
		}

		private static void ParseSettings(string token, ref int key, ref double volume, ref double bpm, int defaultKey,
			double defaultVolume, double defaultBpm)
		{
			if (token == "@") // reset all
			{
				key = defaultKey;
				volume = defaultVolume;
				bpm = defaultBpm;

				return;
			}

			switch (char.ToLower(token.Last()))
			{
				case 'k': // @XXk
				{
					if (token.Length == 2)
						key = defaultKey;
					else
						key = Note.Parse(token.Substring(1, token.Length - 2), defaultKey);

					break;
				}
				case 'v':
				{
					if (token.Length == 2)
						volume = defaultVolume;
					else
						volume = defaultVolume * double.Parse(token.Substring(1, token.Length - 2));

					break;
				}
				case 'b':
				{
					if (token.Length == 2)
						bpm = defaultBpm;
					else
						bpm = double.Parse(token.Substring(1, token.Length - 2));

					break;
				}
				default:
					throw new BeepingException($"\"{token}\" is not a valid settings token!");
			}
		}

		private static Dictionary<char, double> Durations = new Dictionary<char, double>()
		{
			['o'] = 4.0,
			['^'] = 4.0,
			['d'] = 2.0,
			['v'] = 2.0,
			['q'] = 1.0,
			['/'] = 1.0,
			['g'] = 0.5,
			['\''] = 0.5,
			['j'] = 0.25,
			['"'] = 0.25,
		};
	}
}
