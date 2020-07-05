using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Beeptastic
{
	public class Note
	{
		public static int SampleRate = 12_288;

		public static int ParseAbsolute(string text)
		{
			if (!Regex.IsMatch(text, @"^[A-Ga-g](#|b|B)?[0-9]$"))
				throw new BeepingException($"\"{text}\" is not a valid note!");

			int pitchClass = PitchClasses[char.ToUpper(text[0])];
			int accidental = text.Length == 3 ? (text[1] == '#' ? 1 : -1) : 0;
			int octave = text.Last() - '0';

			return octave * 12 + pitchClass + accidental - 48; // 48 = A4
		}

		public static int ParseRelative(string text, int key)
		{
			if (!Regex.IsMatch(text, @"^[1-7](#|b|B)?(\+|\-)*$"))
				throw new BeepingException($"\"{text}\" is not a valid note!");

			int modIndex = text.IndexOfAny(new char[] { '+', '-' });

			int pitchClass = PitchClasses[text[0]];
			int accidental = 0;
			if (modIndex == 2)
				accidental = text[1] == '#' ? 1 : -1;
			else if (modIndex == -1)
				modIndex = text.Length;
			int relativeOctave = text.Length - modIndex;

			return key + pitchClass + accidental + relativeOctave * (text.Last() == '+' ? 12 : -12);
		}

		public int Pitch;
		public int Duration;

		public Note(int pitch, int duration)
		{
			Pitch = pitch;
			Duration = duration;
		}

		public Note(string script, int key)
		{
			int durationStartIndex = Regex.Match(script, @"^[1-7](#|b|B)?(\+|\-)*$").Length;
			Pitch = ParseRelative(script.Substring(0, durationStartIndex), key);

			double currDurationMod = 0;
			for (int i = durationStartIndex; i < script.Length; i++)
			{
				char ch = script[i];


			}
		}

		private static Dictionary<char, int> PitchClasses = new Dictionary<char, int>()
		{
			['A'] = 0,
			['B'] = 2,
			['C'] = -9,
			['D'] = -7,
			['E'] = -5,
			['F'] = -4,
			['G'] = -2,

			['1'] = 0,
			['2'] = 2,
			['3'] = 4,
			['4'] = 5,
			['5'] = 7,
			['6'] = 9,
			['7'] = 11,
		};

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

		public static double GetFreq(int note)
		{
			return StandardFreq * Math.Pow(2, note / 12.0);
		}
	}
}
