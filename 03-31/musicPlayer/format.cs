using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{

	public class format
	{

		static public string error(Exception ee)
		{
			return ee.GetType().ToString().Split('.').Reverse().ToList()[0];
		}

	}

}
