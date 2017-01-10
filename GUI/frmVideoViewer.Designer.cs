namespace GUI
{
	partial class frmVideoViewer
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.tmrUpdateFrame = new System.Windows.Forms.Timer(this.components);
			this.picPpuOutput = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picPpuOutput)).BeginInit();
			this.SuspendLayout();
			// 
			// tmrUpdateFrame
			// 
			this.tmrUpdateFrame.Interval = 1000;
			this.tmrUpdateFrame.Tick += new System.EventHandler(this.tmrUpdateFrame_Tick);
			// 
			// picPpuOutput
			// 
			this.picPpuOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picPpuOutput.Location = new System.Drawing.Point(0, 0);
			this.picPpuOutput.MaximumSize = new System.Drawing.Size(256, 240);
			this.picPpuOutput.MinimumSize = new System.Drawing.Size(256, 240);
			this.picPpuOutput.Name = "picPpuOutput";
			this.picPpuOutput.Size = new System.Drawing.Size(256, 240);
			this.picPpuOutput.TabIndex = 0;
			this.picPpuOutput.TabStop = false;
			// 
			// frmVideoViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(256, 240);
			this.Controls.Add(this.picPpuOutput);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "frmVideoViewer";
			this.Text = "PPU Output Viewer";
			((System.ComponentModel.ISupportInitialize)(this.picPpuOutput)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox picPpuOutput;
		private System.Windows.Forms.Timer tmrUpdateFrame;
	}
}