using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{

	public class Music
	{

		public Music(string name = "", string key = "C5", string bpm = "120")
		{
			this.Name = name;
			this.Key = key;
			this.Bpm = bpm;

			this.Scripts = new List<string>();
			this.Volumes = new List<string>();
		}

		public List<string> Scripts;
		public List<string> Volumes;

		public string Name;
		public string Key;
		public string Bpm;

	}

}
