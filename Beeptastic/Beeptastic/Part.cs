using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beeptastic
{
	public class Part
	{
		public string Script = "";
		public double Volume = 1.0;
		public bool IsMuted = false;

		public Part()
		{
		}

		public Part(string script, double volume)
		{
			Script = script;
			Volume = volume;
		}
	}
}
