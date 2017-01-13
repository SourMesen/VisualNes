using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
	public partial class frmVideoViewer : Form
	{
		public frmVideoViewer()
		{
			InitializeComponent();

			if(!DesignMode) {
				picPpuOutput.Image = new Bitmap(256, 240);
				tmrUpdateFrame.Enabled = true;
				UpdatePicture();
			}
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if(keyData == Keys.Escape) {
				this.Close();
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		private void UpdatePicture()
		{
			using(Graphics graphics = Graphics.FromImage(picPpuOutput.Image)) {
				GCHandle handle = GCHandle.Alloc(CoreWrapper.getFrameBuffer(), GCHandleType.Pinned);
				Bitmap source = new Bitmap(256, 240, 4*256, System.Drawing.Imaging.PixelFormat.Format32bppArgb, handle.AddrOfPinnedObject());
				try {
					graphics.DrawImage(source, 0, 0);
				} finally {
					handle.Free();
				}
				picPpuOutput.Invalidate();

				this.Text = "PPU Output" + (frmMain.CurrentRom.Length > 0 ? " - " + Path.GetFileNameWithoutExtension(frmMain.CurrentRom) : "");
			}
		}

		private void tmrUpdateFrame_Tick(object sender, EventArgs e)
		{
			UpdatePicture();
		}
	}
}
