using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beeptastic
{
	public class Beep
	{
		public int Position;
		public double Freq;
		public double Volume;
		public int Duration;

		public Beep(int position, double freq, double volume, int duration)
		{
			Position = position;
			Freq = freq;
			Volume = volume;
			Duration = duration;
		}
	}
}
