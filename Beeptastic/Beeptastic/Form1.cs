using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beeptastic
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			Part part1 = new Part();
			Part part2 = new Part();
			Part part3 = new Part();
			Part part4 = new Part();
			part1.Script = "@k 1-g 2-g 3-g 4-g 5-g 6-g 7-g 1g 2g 3G 4G 5G 6G 7G 1+G 2+g 3+g 4+g 5+g 6+g 7+g 1++g";
			part2.Script = "1-g 2-g 3-g 4-g 5-g 6-g 7-g 1g 2g 3G 4G 5G 6G 7G 1+G 2+g 3+g 4+g 5+g 6+g 7+g 1++g";
			part3.Script = "@0v 1-g 2-g 3-g 4-g 5-g 6-g 7-g 1g 2g 3G 4G 5G 6G 7G 1+G 2+g 3+g 4+g 5+g 6+g 7+g 1++g";
			part4.Script = "@1+k 1+ 2+ 3+ 4+ 5+ 6+ 7+ A4";

			Tune tune = new Tune();
			//tune.Parts[0] = part1;
			tune.Parts[0] = part4;
			//tune.Parts[1] = part2;
			//tune.Parts[2] = part3;

			Compiler.CompileTune(tune, 1.0);
		}
	}
}
