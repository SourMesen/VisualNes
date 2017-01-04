namespace GUI
{
	partial class ctrlChipDisplay
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.picChip = new System.Windows.Forms.PictureBox();
			this.tmrDrawChip = new System.Windows.Forms.Timer(this.components);
			this.lblNodeInfo = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picChip)).BeginInit();
			this.SuspendLayout();
			// 
			// picChip
			// 
			this.picChip.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picChip.Location = new System.Drawing.Point(0, 0);
			this.picChip.Margin = new System.Windows.Forms.Padding(0);
			this.picChip.Name = "picChip";
			this.picChip.Size = new System.Drawing.Size(379, 247);
			this.picChip.TabIndex = 0;
			this.picChip.TabStop = false;
			this.picChip.SizeChanged += new System.EventHandler(this.picChip_SizeChanged);
			this.picChip.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picChip_MouseClick);
			this.picChip.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.picChip_MouseDoubleClick);
			this.picChip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picChip_MouseDown);
			this.picChip.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picChip_MouseMove);
			this.picChip.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picChip_MouseUp);
			// 
			// tmrDrawChip
			// 
			this.tmrDrawChip.Interval = 66;
			this.tmrDrawChip.Tick += new System.EventHandler(this.tmrDrawChip_Tick);
			// 
			// lblNodeInfo
			// 
			this.lblNodeInfo.BackColor = System.Drawing.Color.Black;
			this.lblNodeInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblNodeInfo.ForeColor = System.Drawing.Color.White;
			this.lblNodeInfo.Location = new System.Drawing.Point(0, 247);
			this.lblNodeInfo.Name = "lblNodeInfo";
			this.lblNodeInfo.Size = new System.Drawing.Size(379, 30);
			this.lblNodeInfo.TabIndex = 1;
			// 
			// ctrlChipDisplay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.picChip);
			this.Controls.Add(this.lblNodeInfo);
			this.DoubleBuffered = true;
			this.Name = "ctrlChipDisplay";
			this.Size = new System.Drawing.Size(379, 277);
			((System.ComponentModel.ISupportInitialize)(this.picChip)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox picChip;
		private System.Windows.Forms.Timer tmrDrawChip;
		private System.Windows.Forms.Label lblNodeInfo;
	}
}
