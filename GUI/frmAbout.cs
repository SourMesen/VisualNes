using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
	partial class frmAbout : Form
	{
		public frmAbout()
		{
			InitializeComponent();
		}

		private void lblLink_Click(object sender, EventArgs e)
		{
			Process.Start("http://www.mesen.ca/VisualNes.php");
		}
	}
}
