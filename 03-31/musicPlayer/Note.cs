using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace System
{

	public class Note
	{
		public static double A4 = 440.0;

		public static int GetNoteIndex(string key)
		{
			if (!Regex.IsMatch(key, @"^[A-Ga-g](#|b|B)?[0-9]$"))
				throw new ArgumentException();

			int pitchClass = PitchClasses[char.ToUpper(key[0])];
			int accidental = key.Length == 3 ? (key[1] == '#' ? 1 : -1) : 0;
			int octave = key.Last() - '0';

			return octave * 12 + pitchClass + accidental - 48; // 48 = A4
		}

		public static double GetFrequency(int index)
		{
			return A4 * Math.Pow(2, index / 12.0);
		}

		public static Dictionary<char, int> PitchClasses = new Dictionary<char, int>()
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

	}

}
