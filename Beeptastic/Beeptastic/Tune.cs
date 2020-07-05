using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beeptastic
{
	public class Tune
	{
		public string Title = "";
		public int Key = Note.ParseAbsolute("C5");
		public double Bpm = 120.0;
		public Dictionary<int, Part> Parts = new Dictionary<int, Part>()
		{
			[0] = new Part(),
		};

		public Tune()
		{
		}
	}
}
