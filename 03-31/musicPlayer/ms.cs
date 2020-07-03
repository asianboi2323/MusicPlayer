using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System
{

	public class ms
	{

		static public DialogResult g(string title, string content, MessageBoxButtons buttons)
		{
			return MessageBox.Show(content, title, buttons);
		}

		static public DialogResult g(string title, string content)
		{
			return MessageBox.Show(content, title);
		}

	}

}
