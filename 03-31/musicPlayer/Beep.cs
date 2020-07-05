using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{

	public class Beep
	{

		public Beep(int duration, double frequency = 0)
		{
			Frequency = frequency;
			Duration = duration;
		}

		public double Frequency;
		public int Duration;

	}

}
