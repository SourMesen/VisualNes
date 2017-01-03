namespace GUI
{
	partial class frmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.chkShowInHex = new System.Windows.Forms.CheckBox();
			this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
			this.label4 = new System.Windows.Forms.Label();
			this.lblHz = new System.Windows.Forms.Label();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.lblHalfCycle = new System.Windows.Forms.Label();
			this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
			this.label9 = new System.Windows.Forms.Label();
			this.lblD = new System.Windows.Forms.Label();
			this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
			this.label7 = new System.Windows.Forms.Label();
			this.lblAb = new System.Windows.Forms.Label();
			this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnRun = new System.Windows.Forms.Button();
			this.btnStep = new System.Windows.Forms.Button();
			this.btnNextPixel = new System.Windows.Forms.Button();
			this.btnNextScanline = new System.Windows.Forms.Button();
			this.btnNextFrame = new System.Windows.Forms.Button();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.lblPixel = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.label3 = new System.Windows.Forms.Label();
			this.lblScanline = new System.Windows.Forms.Label();
			this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
			this.label5 = new System.Windows.Forms.Label();
			this.lblClk = new System.Windows.Forms.Label();
			this.lstLogView = new GUI.DoubleBufferedListView();
			this.btnSelectColumns = new System.Windows.Forms.Button();
			this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
			this.chkLogHex = new System.Windows.Forms.CheckBox();
			this.chkLogCsv = new System.Windows.Forms.CheckBox();
			this.btnStartLogging = new System.Windows.Forms.Button();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel11 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnResetPalette = new System.Windows.Forms.Button();
			this.btnImportPalette = new System.Windows.Forms.Button();
			this.btnExportPalette = new System.Windows.Forms.Button();
			this.hexPaletteRam = new Be.Windows.Forms.HexBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel12 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnResetSprite = new System.Windows.Forms.Button();
			this.btnImportSprite = new System.Windows.Forms.Button();
			this.btnExportSprite = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.hexSpriteRam = new Be.Windows.Forms.HexBox();
			this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel13 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnResetVram = new System.Windows.Forms.Button();
			this.btnImportVram = new System.Windows.Forms.Button();
			this.btnExportVram = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.hexVram = new Be.Windows.Forms.HexBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.grpReset = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.radResetPostrenderOdd = new System.Windows.Forms.RadioButton();
			this.radResetPrerenderOdd = new System.Windows.Forms.RadioButton();
			this.radResetPrerenderEven = new System.Windows.Forms.RadioButton();
			this.radResetPowerOn = new System.Windows.Forms.RadioButton();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnSaveState = new System.Windows.Forms.Button();
			this.btnLoadState = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
			this.label11 = new System.Windows.Forms.Label();
			this.cboRefreshSpeed = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.hexProgram = new Be.Windows.Forms.HexBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel4.SuspendLayout();
			this.flowLayoutPanel3.SuspendLayout();
			this.flowLayoutPanel8.SuspendLayout();
			this.flowLayoutPanel7.SuspendLayout();
			this.flowLayoutPanel5.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel6.SuspendLayout();
			this.flowLayoutPanel9.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.flowLayoutPanel11.SuspendLayout();
			this.tableLayoutPanel6.SuspendLayout();
			this.flowLayoutPanel12.SuspendLayout();
			this.tableLayoutPanel7.SuspendLayout();
			this.flowLayoutPanel13.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.grpReset.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.flowLayoutPanel10.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.chkShowInHex, 1, 7);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel8, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel7, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel5, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel6, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.lstLogView, 0, 8);
			this.tableLayoutPanel1.Controls.Add(this.btnSelectColumns, 0, 7);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel9, 2, 7);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 0, 6);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(284, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 9;
			this.tableLayoutPanel2.SetRowSpan(this.tableLayoutPanel1, 4);
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(660, 648);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// chkShowInHex
			// 
			this.chkShowInHex.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chkShowInHex.AutoSize = true;
			this.chkShowInHex.Location = new System.Drawing.Point(120, 412);
			this.chkShowInHex.Name = "chkShowInHex";
			this.chkShowInHex.Size = new System.Drawing.Size(86, 17);
			this.chkShowInHex.TabIndex = 21;
			this.chkShowInHex.Text = "Show in Hex";
			this.chkShowInHex.UseVisualStyleBackColor = true;
			this.chkShowInHex.CheckedChanged += new System.EventHandler(this.chkShowInHex_CheckedChanged);
			// 
			// flowLayoutPanel4
			// 
			this.flowLayoutPanel4.AutoSize = true;
			this.flowLayoutPanel4.Controls.Add(this.label4);
			this.flowLayoutPanel4.Controls.Add(this.lblHz);
			this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 40);
			this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel4.Name = "flowLayoutPanel4";
			this.flowLayoutPanel4.Size = new System.Drawing.Size(48, 13);
			this.flowLayoutPanel4.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(23, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "Hz:";
			// 
			// lblHz
			// 
			this.lblHz.AutoSize = true;
			this.lblHz.Location = new System.Drawing.Point(32, 0);
			this.lblHz.Name = "lblHz";
			this.lblHz.Size = new System.Drawing.Size(13, 13);
			this.lblHz.TabIndex = 1;
			this.lblHz.Text = "0";
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.AutoSize = true;
			this.flowLayoutPanel3.Controls.Add(this.label1);
			this.flowLayoutPanel3.Controls.Add(this.lblHalfCycle);
			this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Size = new System.Drawing.Size(79, 13);
			this.flowLayoutPanel3.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Halfcycle:";
			// 
			// lblHalfCycle
			// 
			this.lblHalfCycle.AutoSize = true;
			this.lblHalfCycle.Location = new System.Drawing.Point(63, 0);
			this.lblHalfCycle.Name = "lblHalfCycle";
			this.lblHalfCycle.Size = new System.Drawing.Size(13, 13);
			this.lblHalfCycle.TabIndex = 1;
			this.lblHalfCycle.Text = "0";
			// 
			// flowLayoutPanel8
			// 
			this.flowLayoutPanel8.AutoSize = true;
			this.flowLayoutPanel8.Controls.Add(this.label9);
			this.flowLayoutPanel8.Controls.Add(this.lblD);
			this.flowLayoutPanel8.Location = new System.Drawing.Point(302, 0);
			this.flowLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel8.Name = "flowLayoutPanel8";
			this.flowLayoutPanel8.Size = new System.Drawing.Size(43, 13);
			this.flowLayoutPanel8.TabIndex = 5;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(3, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(18, 13);
			this.label9.TabIndex = 1;
			this.label9.Text = "D:";
			// 
			// lblD
			// 
			this.lblD.AutoSize = true;
			this.lblD.Location = new System.Drawing.Point(27, 0);
			this.lblD.Name = "lblD";
			this.lblD.Size = new System.Drawing.Size(13, 13);
			this.lblD.TabIndex = 1;
			this.lblD.Text = "0";
			// 
			// flowLayoutPanel7
			// 
			this.flowLayoutPanel7.AutoSize = true;
			this.flowLayoutPanel7.Controls.Add(this.label7);
			this.flowLayoutPanel7.Controls.Add(this.lblAb);
			this.flowLayoutPanel7.Location = new System.Drawing.Point(218, 0);
			this.flowLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel7.Name = "flowLayoutPanel7";
			this.flowLayoutPanel7.Size = new System.Drawing.Size(49, 13);
			this.flowLayoutPanel7.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(24, 13);
			this.label7.TabIndex = 1;
			this.label7.Text = "AB:";
			// 
			// lblAb
			// 
			this.lblAb.AutoSize = true;
			this.lblAb.Location = new System.Drawing.Point(33, 0);
			this.lblAb.Name = "lblAb";
			this.lblAb.Size = new System.Drawing.Size(13, 13);
			this.lblAb.TabIndex = 1;
			this.lblAb.Text = "0";
			// 
			// flowLayoutPanel5
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel5, 4);
			this.flowLayoutPanel5.Controls.Add(this.btnRun);
			this.flowLayoutPanel5.Controls.Add(this.btnStep);
			this.flowLayoutPanel5.Controls.Add(this.btnNextPixel);
			this.flowLayoutPanel5.Controls.Add(this.btnNextScanline);
			this.flowLayoutPanel5.Controls.Add(this.btnNextFrame);
			this.flowLayoutPanel5.Location = new System.Drawing.Point(0, 60);
			this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel5.Name = "flowLayoutPanel5";
			this.flowLayoutPanel5.Size = new System.Drawing.Size(451, 28);
			this.flowLayoutPanel5.TabIndex = 10;
			// 
			// btnRun
			// 
			this.btnRun.Location = new System.Drawing.Point(3, 3);
			this.btnRun.Name = "btnRun";
			this.btnRun.Size = new System.Drawing.Size(75, 23);
			this.btnRun.TabIndex = 6;
			this.btnRun.Text = "Run";
			this.btnRun.UseVisualStyleBackColor = true;
			this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
			// 
			// btnStep
			// 
			this.btnStep.Location = new System.Drawing.Point(84, 3);
			this.btnStep.Name = "btnStep";
			this.btnStep.Size = new System.Drawing.Size(75, 23);
			this.btnStep.TabIndex = 10;
			this.btnStep.Text = "Step";
			this.btnStep.UseVisualStyleBackColor = true;
			this.btnStep.Click += new System.EventHandler(this.btnStep_Click);
			// 
			// btnNextPixel
			// 
			this.btnNextPixel.Location = new System.Drawing.Point(165, 3);
			this.btnNextPixel.Name = "btnNextPixel";
			this.btnNextPixel.Size = new System.Drawing.Size(75, 23);
			this.btnNextPixel.TabIndex = 7;
			this.btnNextPixel.Text = "Next Pixel";
			this.btnNextPixel.UseVisualStyleBackColor = true;
			this.btnNextPixel.Click += new System.EventHandler(this.btnNextPixel_Click);
			// 
			// btnNextScanline
			// 
			this.btnNextScanline.Location = new System.Drawing.Point(246, 3);
			this.btnNextScanline.Name = "btnNextScanline";
			this.btnNextScanline.Size = new System.Drawing.Size(91, 23);
			this.btnNextScanline.TabIndex = 8;
			this.btnNextScanline.Text = "Next Scanline";
			this.btnNextScanline.UseVisualStyleBackColor = true;
			this.btnNextScanline.Click += new System.EventHandler(this.btnNextScanline_Click);
			// 
			// btnNextFrame
			// 
			this.btnNextFrame.Location = new System.Drawing.Point(343, 3);
			this.btnNextFrame.Name = "btnNextFrame";
			this.btnNextFrame.Size = new System.Drawing.Size(91, 23);
			this.btnNextFrame.TabIndex = 9;
			this.btnNextFrame.Text = "Next Frame";
			this.btnNextFrame.UseVisualStyleBackColor = true;
			this.btnNextFrame.Click += new System.EventHandler(this.btnNextFrame_Click);
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.AutoSize = true;
			this.flowLayoutPanel2.Controls.Add(this.label2);
			this.flowLayoutPanel2.Controls.Add(this.lblPixel);
			this.flowLayoutPanel2.Location = new System.Drawing.Point(117, 20);
			this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(57, 13);
			this.flowLayoutPanel2.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Pixel:";
			// 
			// lblPixel
			// 
			this.lblPixel.AutoSize = true;
			this.lblPixel.Location = new System.Drawing.Point(41, 0);
			this.lblPixel.Name = "lblPixel";
			this.lblPixel.Size = new System.Drawing.Size(13, 13);
			this.lblPixel.TabIndex = 2;
			this.lblPixel.Text = "0";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.Controls.Add(this.label3);
			this.flowLayoutPanel1.Controls.Add(this.lblScanline);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 20);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(76, 13);
			this.flowLayoutPanel1.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Scanline:";
			// 
			// lblScanline
			// 
			this.lblScanline.AutoSize = true;
			this.lblScanline.Location = new System.Drawing.Point(60, 0);
			this.lblScanline.Name = "lblScanline";
			this.lblScanline.Size = new System.Drawing.Size(13, 13);
			this.lblScanline.TabIndex = 3;
			this.lblScanline.Text = "0";
			// 
			// flowLayoutPanel6
			// 
			this.flowLayoutPanel6.AutoSize = true;
			this.flowLayoutPanel6.Controls.Add(this.label5);
			this.flowLayoutPanel6.Controls.Add(this.lblClk);
			this.flowLayoutPanel6.Location = new System.Drawing.Point(117, 0);
			this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel6.Name = "flowLayoutPanel6";
			this.flowLayoutPanel6.Size = new System.Drawing.Size(49, 13);
			this.flowLayoutPanel6.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(24, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "clk:";
			// 
			// lblClk
			// 
			this.lblClk.AutoSize = true;
			this.lblClk.Location = new System.Drawing.Point(33, 0);
			this.lblClk.Name = "lblClk";
			this.lblClk.Size = new System.Drawing.Size(13, 13);
			this.lblClk.TabIndex = 1;
			this.lblClk.Text = "0";
			// 
			// lstLogView
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.lstLogView, 4);
			this.lstLogView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstLogView.FullRowSelect = true;
			this.lstLogView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lstLogView.Location = new System.Drawing.Point(3, 438);
			this.lstLogView.Name = "lstLogView";
			this.lstLogView.Size = new System.Drawing.Size(654, 207);
			this.lstLogView.TabIndex = 12;
			this.lstLogView.UseCompatibleStateImageBehavior = false;
			this.lstLogView.View = System.Windows.Forms.View.Details;
			// 
			// btnSelectColumns
			// 
			this.btnSelectColumns.Location = new System.Drawing.Point(3, 409);
			this.btnSelectColumns.Name = "btnSelectColumns";
			this.btnSelectColumns.Size = new System.Drawing.Size(103, 23);
			this.btnSelectColumns.TabIndex = 13;
			this.btnSelectColumns.Text = "Select Columns";
			this.btnSelectColumns.UseVisualStyleBackColor = true;
			this.btnSelectColumns.Click += new System.EventHandler(this.btnSelectColumns_Click);
			// 
			// flowLayoutPanel9
			// 
			this.flowLayoutPanel9.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.flowLayoutPanel9.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel9, 2);
			this.flowLayoutPanel9.Controls.Add(this.chkLogHex);
			this.flowLayoutPanel9.Controls.Add(this.chkLogCsv);
			this.flowLayoutPanel9.Controls.Add(this.btnStartLogging);
			this.flowLayoutPanel9.Location = new System.Drawing.Point(380, 406);
			this.flowLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel9.Name = "flowLayoutPanel9";
			this.flowLayoutPanel9.Size = new System.Drawing.Size(280, 29);
			this.flowLayoutPanel9.TabIndex = 15;
			// 
			// chkLogHex
			// 
			this.chkLogHex.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chkLogHex.AutoSize = true;
			this.chkLogHex.Location = new System.Drawing.Point(3, 6);
			this.chkLogHex.Name = "chkLogHex";
			this.chkLogHex.Size = new System.Drawing.Size(77, 17);
			this.chkLogHex.TabIndex = 16;
			this.chkLogHex.Text = "Log in Hex";
			this.chkLogHex.UseVisualStyleBackColor = true;
			// 
			// chkLogCsv
			// 
			this.chkLogCsv.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chkLogCsv.AutoSize = true;
			this.chkLogCsv.Location = new System.Drawing.Point(86, 6);
			this.chkLogCsv.Name = "chkLogCsv";
			this.chkLogCsv.Size = new System.Drawing.Size(82, 17);
			this.chkLogCsv.TabIndex = 15;
			this.chkLogCsv.Text = "Log as CSV";
			this.chkLogCsv.UseVisualStyleBackColor = true;
			// 
			// btnStartLogging
			// 
			this.btnStartLogging.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnStartLogging.Location = new System.Drawing.Point(174, 3);
			this.btnStartLogging.Name = "btnStartLogging";
			this.btnStartLogging.Size = new System.Drawing.Size(103, 23);
			this.btnStartLogging.TabIndex = 14;
			this.btnStartLogging.Text = "Start Logging";
			this.btnStartLogging.UseVisualStyleBackColor = true;
			this.btnStartLogging.Click += new System.EventHandler(this.btnStartLogging_Click);
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.AutoSize = true;
			this.tableLayoutPanel5.ColumnCount = 3;
			this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel5, 4);
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel5.Controls.Add(this.flowLayoutPanel11, 2, 0);
			this.tableLayoutPanel5.Controls.Add(this.hexPaletteRam, 1, 0);
			this.tableLayoutPanel5.Controls.Add(this.label6, 0, 0);
			this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 88);
			this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 1;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(658, 44);
			this.tableLayoutPanel5.TabIndex = 18;
			// 
			// flowLayoutPanel11
			// 
			this.flowLayoutPanel11.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.flowLayoutPanel11.AutoSize = true;
			this.flowLayoutPanel11.Controls.Add(this.btnResetPalette);
			this.flowLayoutPanel11.Controls.Add(this.btnImportPalette);
			this.flowLayoutPanel11.Controls.Add(this.btnExportPalette);
			this.flowLayoutPanel11.Location = new System.Drawing.Point(580, 7);
			this.flowLayoutPanel11.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel11.Name = "flowLayoutPanel11";
			this.flowLayoutPanel11.Size = new System.Drawing.Size(78, 29);
			this.flowLayoutPanel11.TabIndex = 19;
			this.flowLayoutPanel11.WrapContents = false;
			// 
			// btnResetPalette
			// 
			this.btnResetPalette.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnResetPalette.Image = global::GUI.Properties.Resources.view_refresh;
			this.btnResetPalette.Location = new System.Drawing.Point(0, 3);
			this.btnResetPalette.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.btnResetPalette.Name = "btnResetPalette";
			this.btnResetPalette.Size = new System.Drawing.Size(26, 23);
			this.btnResetPalette.TabIndex = 8;
			this.btnResetPalette.UseVisualStyleBackColor = true;
			this.btnResetPalette.Click += new System.EventHandler(this.btnResetPalette_Click);
			// 
			// btnImportPalette
			// 
			this.btnImportPalette.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnImportPalette.Image = global::GUI.Properties.Resources.Import;
			this.btnImportPalette.Location = new System.Drawing.Point(26, 3);
			this.btnImportPalette.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.btnImportPalette.Name = "btnImportPalette";
			this.btnImportPalette.Size = new System.Drawing.Size(26, 23);
			this.btnImportPalette.TabIndex = 9;
			this.btnImportPalette.UseVisualStyleBackColor = true;
			this.btnImportPalette.Click += new System.EventHandler(this.btnImportPalette_Click);
			// 
			// btnExportPalette
			// 
			this.btnExportPalette.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExportPalette.Image = global::GUI.Properties.Resources.Export;
			this.btnExportPalette.Location = new System.Drawing.Point(52, 3);
			this.btnExportPalette.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.btnExportPalette.Name = "btnExportPalette";
			this.btnExportPalette.Size = new System.Drawing.Size(26, 23);
			this.btnExportPalette.TabIndex = 10;
			this.btnExportPalette.UseVisualStyleBackColor = true;
			this.btnExportPalette.Click += new System.EventHandler(this.btnExportPalette_Click);
			// 
			// hexPaletteRam
			// 
			this.hexPaletteRam.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.hexPaletteRam.LineInfoVisible = true;
			this.hexPaletteRam.Location = new System.Drawing.Point(83, 3);
			this.hexPaletteRam.Name = "hexPaletteRam";
			this.hexPaletteRam.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
			this.hexPaletteRam.Size = new System.Drawing.Size(494, 38);
			this.hexPaletteRam.TabIndex = 17;
			this.hexPaletteRam.UseFixedBytesPerLine = true;
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 15);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(70, 13);
			this.label6.TabIndex = 18;
			this.label6.Text = "Palette RAM:";
			// 
			// tableLayoutPanel6
			// 
			this.tableLayoutPanel6.AutoSize = true;
			this.tableLayoutPanel6.ColumnCount = 3;
			this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel6, 4);
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel6.Controls.Add(this.flowLayoutPanel12, 2, 0);
			this.tableLayoutPanel6.Controls.Add(this.label8, 0, 0);
			this.tableLayoutPanel6.Controls.Add(this.hexSpriteRam, 1, 0);
			this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 132);
			this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel6.Name = "tableLayoutPanel6";
			this.tableLayoutPanel6.RowCount = 1;
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel6.Size = new System.Drawing.Size(658, 79);
			this.tableLayoutPanel6.TabIndex = 19;
			// 
			// flowLayoutPanel12
			// 
			this.flowLayoutPanel12.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.flowLayoutPanel12.AutoSize = true;
			this.flowLayoutPanel12.Controls.Add(this.btnResetSprite);
			this.flowLayoutPanel12.Controls.Add(this.btnImportSprite);
			this.flowLayoutPanel12.Controls.Add(this.btnExportSprite);
			this.flowLayoutPanel12.Location = new System.Drawing.Point(580, 25);
			this.flowLayoutPanel12.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel12.Name = "flowLayoutPanel12";
			this.flowLayoutPanel12.Size = new System.Drawing.Size(78, 29);
			this.flowLayoutPanel12.TabIndex = 22;
			this.flowLayoutPanel12.WrapContents = false;
			// 
			// btnResetSprite
			// 
			this.btnResetSprite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnResetSprite.Image = global::GUI.Properties.Resources.view_refresh;
			this.btnResetSprite.Location = new System.Drawing.Point(0, 3);
			this.btnResetSprite.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.btnResetSprite.Name = "btnResetSprite";
			this.btnResetSprite.Size = new System.Drawing.Size(26, 23);
			this.btnResetSprite.TabIndex = 8;
			this.btnResetSprite.UseVisualStyleBackColor = true;
			this.btnResetSprite.Click += new System.EventHandler(this.btnResetSprite_Click);
			// 
			// btnImportSprite
			// 
			this.btnImportSprite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnImportSprite.Image = global::GUI.Properties.Resources.Import;
			this.btnImportSprite.Location = new System.Drawing.Point(26, 3);
			this.btnImportSprite.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.btnImportSprite.Name = "btnImportSprite";
			this.btnImportSprite.Size = new System.Drawing.Size(26, 23);
			this.btnImportSprite.TabIndex = 9;
			this.btnImportSprite.UseVisualStyleBackColor = true;
			this.btnImportSprite.Click += new System.EventHandler(this.btnImportSprite_Click);
			// 
			// btnExportSprite
			// 
			this.btnExportSprite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExportSprite.Image = global::GUI.Properties.Resources.Export;
			this.btnExportSprite.Location = new System.Drawing.Point(52, 3);
			this.btnExportSprite.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.btnExportSprite.Name = "btnExportSprite";
			this.btnExportSprite.Size = new System.Drawing.Size(26, 23);
			this.btnExportSprite.TabIndex = 10;
			this.btnExportSprite.UseVisualStyleBackColor = true;
			this.btnExportSprite.Click += new System.EventHandler(this.btnExportSprite_Click);
			// 
			// label8
			// 
			this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(3, 33);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(64, 13);
			this.label8.TabIndex = 21;
			this.label8.Text = "Sprite RAM:";
			// 
			// hexSpriteRam
			// 
			this.hexSpriteRam.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.hexSpriteRam.LineInfoVisible = true;
			this.hexSpriteRam.Location = new System.Drawing.Point(83, 3);
			this.hexSpriteRam.Name = "hexSpriteRam";
			this.hexSpriteRam.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
			this.hexSpriteRam.Size = new System.Drawing.Size(494, 73);
			this.hexSpriteRam.TabIndex = 16;
			this.hexSpriteRam.UseFixedBytesPerLine = true;
			this.hexSpriteRam.VScrollBarVisible = true;
			// 
			// tableLayoutPanel7
			// 
			this.tableLayoutPanel7.AutoSize = true;
			this.tableLayoutPanel7.ColumnCount = 3;
			this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel7, 4);
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel7.Controls.Add(this.flowLayoutPanel13, 2, 0);
			this.tableLayoutPanel7.Controls.Add(this.label10, 0, 0);
			this.tableLayoutPanel7.Controls.Add(this.hexVram, 1, 0);
			this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 211);
			this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel7.Name = "tableLayoutPanel7";
			this.tableLayoutPanel7.RowCount = 1;
			this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel7.Size = new System.Drawing.Size(658, 195);
			this.tableLayoutPanel7.TabIndex = 20;
			// 
			// flowLayoutPanel13
			// 
			this.flowLayoutPanel13.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.flowLayoutPanel13.AutoSize = true;
			this.flowLayoutPanel13.Controls.Add(this.btnResetVram);
			this.flowLayoutPanel13.Controls.Add(this.btnImportVram);
			this.flowLayoutPanel13.Controls.Add(this.btnExportVram);
			this.flowLayoutPanel13.Location = new System.Drawing.Point(580, 83);
			this.flowLayoutPanel13.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel13.Name = "flowLayoutPanel13";
			this.flowLayoutPanel13.Size = new System.Drawing.Size(78, 29);
			this.flowLayoutPanel13.TabIndex = 23;
			this.flowLayoutPanel13.WrapContents = false;
			// 
			// btnResetVram
			// 
			this.btnResetVram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnResetVram.Image = global::GUI.Properties.Resources.view_refresh;
			this.btnResetVram.Location = new System.Drawing.Point(0, 3);
			this.btnResetVram.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.btnResetVram.Name = "btnResetVram";
			this.btnResetVram.Size = new System.Drawing.Size(26, 23);
			this.btnResetVram.TabIndex = 8;
			this.btnResetVram.UseVisualStyleBackColor = true;
			this.btnResetVram.Click += new System.EventHandler(this.btnResetVram_Click);
			// 
			// btnImportVram
			// 
			this.btnImportVram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnImportVram.Image = global::GUI.Properties.Resources.Import;
			this.btnImportVram.Location = new System.Drawing.Point(26, 3);
			this.btnImportVram.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.btnImportVram.Name = "btnImportVram";
			this.btnImportVram.Size = new System.Drawing.Size(26, 23);
			this.btnImportVram.TabIndex = 9;
			this.btnImportVram.UseVisualStyleBackColor = true;
			this.btnImportVram.Click += new System.EventHandler(this.btnImportVram_Click);
			// 
			// btnExportVram
			// 
			this.btnExportVram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExportVram.Image = global::GUI.Properties.Resources.Export;
			this.btnExportVram.Location = new System.Drawing.Point(52, 3);
			this.btnExportVram.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.btnExportVram.Name = "btnExportVram";
			this.btnExportVram.Size = new System.Drawing.Size(26, 23);
			this.btnExportVram.TabIndex = 10;
			this.btnExportVram.UseVisualStyleBackColor = true;
			this.btnExportVram.Click += new System.EventHandler(this.btnExportVram_Click);
			// 
			// label10
			// 
			this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(3, 91);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(41, 13);
			this.label10.TabIndex = 22;
			this.label10.Text = "VRAM:";
			// 
			// hexVram
			// 
			this.hexVram.ColumnInfoVisible = true;
			this.hexVram.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.hexVram.LineInfoVisible = true;
			this.hexVram.Location = new System.Drawing.Point(83, 3);
			this.hexVram.Name = "hexVram";
			this.hexVram.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
			this.hexVram.Size = new System.Drawing.Size(494, 189);
			this.hexVram.TabIndex = 4;
			this.hexVram.UseFixedBytesPerLine = true;
			this.hexVram.VScrollBarVisible = true;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.grpReset, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel10, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 3);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 4;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(947, 654);
			this.tableLayoutPanel2.TabIndex = 3;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(275, 219);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// grpReset
			// 
			this.grpReset.Controls.Add(this.tableLayoutPanel3);
			this.grpReset.Location = new System.Drawing.Point(3, 228);
			this.grpReset.Name = "grpReset";
			this.grpReset.Size = new System.Drawing.Size(275, 154);
			this.grpReset.TabIndex = 4;
			this.grpReset.TabStop = false;
			this.grpReset.Text = "Reset State";
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Controls.Add(this.radResetPostrenderOdd, 0, 3);
			this.tableLayoutPanel3.Controls.Add(this.radResetPrerenderOdd, 0, 2);
			this.tableLayoutPanel3.Controls.Add(this.radResetPrerenderEven, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.radResetPowerOn, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 4);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 6;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(269, 135);
			this.tableLayoutPanel3.TabIndex = 0;
			// 
			// radResetPostrenderOdd
			// 
			this.radResetPostrenderOdd.AutoSize = true;
			this.radResetPostrenderOdd.Location = new System.Drawing.Point(3, 72);
			this.radResetPostrenderOdd.Name = "radResetPostrenderOdd";
			this.radResetPostrenderOdd.Size = new System.Drawing.Size(174, 17);
			this.radResetPostrenderOdd.TabIndex = 3;
			this.radResetPostrenderOdd.Text = "Post-render scanline, odd frame";
			this.radResetPostrenderOdd.UseVisualStyleBackColor = true;
			// 
			// radResetPrerenderOdd
			// 
			this.radResetPrerenderOdd.AutoSize = true;
			this.radResetPrerenderOdd.Location = new System.Drawing.Point(3, 49);
			this.radResetPrerenderOdd.Name = "radResetPrerenderOdd";
			this.radResetPrerenderOdd.Size = new System.Drawing.Size(169, 17);
			this.radResetPrerenderOdd.TabIndex = 2;
			this.radResetPrerenderOdd.Text = "Pre-render scanline, odd frame";
			this.radResetPrerenderOdd.UseVisualStyleBackColor = true;
			// 
			// radResetPrerenderEven
			// 
			this.radResetPrerenderEven.AutoSize = true;
			this.radResetPrerenderEven.Checked = true;
			this.radResetPrerenderEven.Location = new System.Drawing.Point(3, 26);
			this.radResetPrerenderEven.Name = "radResetPrerenderEven";
			this.radResetPrerenderEven.Size = new System.Drawing.Size(175, 17);
			this.radResetPrerenderEven.TabIndex = 1;
			this.radResetPrerenderEven.TabStop = true;
			this.radResetPrerenderEven.Text = "Pre-render scanline, even frame";
			this.radResetPrerenderEven.UseVisualStyleBackColor = true;
			// 
			// radResetPowerOn
			// 
			this.radResetPowerOn.AutoSize = true;
			this.radResetPowerOn.Location = new System.Drawing.Point(3, 3);
			this.radResetPowerOn.Name = "radResetPowerOn";
			this.radResetPowerOn.Size = new System.Drawing.Size(72, 17);
			this.radResetPowerOn.TabIndex = 0;
			this.radResetPowerOn.Text = "Power On";
			this.radResetPowerOn.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 4;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel4.Controls.Add(this.btnSaveState, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.btnLoadState, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.btnReset, 3, 0);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 97);
			this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 1;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(269, 31);
			this.tableLayoutPanel4.TabIndex = 8;
			// 
			// btnSaveState
			// 
			this.btnSaveState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSaveState.Location = new System.Drawing.Point(81, 3);
			this.btnSaveState.Name = "btnSaveState";
			this.btnSaveState.Size = new System.Drawing.Size(70, 23);
			this.btnSaveState.TabIndex = 9;
			this.btnSaveState.Text = "Save State";
			this.btnSaveState.UseVisualStyleBackColor = true;
			this.btnSaveState.Click += new System.EventHandler(this.btnSaveState_Click);
			// 
			// btnLoadState
			// 
			this.btnLoadState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLoadState.Location = new System.Drawing.Point(3, 3);
			this.btnLoadState.Name = "btnLoadState";
			this.btnLoadState.Size = new System.Drawing.Size(72, 23);
			this.btnLoadState.TabIndex = 8;
			this.btnLoadState.Text = "Load State";
			this.btnLoadState.UseVisualStyleBackColor = true;
			this.btnLoadState.Click += new System.EventHandler(this.btnLoadState_Click);
			// 
			// btnReset
			// 
			this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnReset.Image = global::GUI.Properties.Resources.view_refresh;
			this.btnReset.Location = new System.Drawing.Point(235, 3);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(31, 25);
			this.btnReset.TabIndex = 7;
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// flowLayoutPanel10
			// 
			this.flowLayoutPanel10.AutoSize = true;
			this.flowLayoutPanel10.Controls.Add(this.label11);
			this.flowLayoutPanel10.Controls.Add(this.cboRefreshSpeed);
			this.flowLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel10.Location = new System.Drawing.Point(0, 385);
			this.flowLayoutPanel10.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel10.Name = "flowLayoutPanel10";
			this.flowLayoutPanel10.Size = new System.Drawing.Size(281, 27);
			this.flowLayoutPanel10.TabIndex = 5;
			// 
			// label11
			// 
			this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(3, 7);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(103, 13);
			this.label11.TabIndex = 0;
			this.label11.Text = "Refresh Frequency: ";
			// 
			// cboRefreshSpeed
			// 
			this.cboRefreshSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboRefreshSpeed.FormattingEnabled = true;
			this.cboRefreshSpeed.Items.AddRange(new object[] {
            "Slow",
            "Normal",
            "Fast"});
			this.cboRefreshSpeed.Location = new System.Drawing.Point(112, 3);
			this.cboRefreshSpeed.Name = "cboRefreshSpeed";
			this.cboRefreshSpeed.Size = new System.Drawing.Size(121, 21);
			this.cboRefreshSpeed.TabIndex = 1;
			this.cboRefreshSpeed.SelectedIndexChanged += new System.EventHandler(this.cboRefreshSpeed_SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.hexProgram);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 415);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(275, 236);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Test Program";
			// 
			// hexProgram
			// 
			this.hexProgram.BytesPerLine = 2;
			this.hexProgram.Dock = System.Windows.Forms.DockStyle.Fill;
			this.hexProgram.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.hexProgram.LineInfoVisible = true;
			this.hexProgram.Location = new System.Drawing.Point(3, 56);
			this.hexProgram.Name = "hexProgram";
			this.hexProgram.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
			this.hexProgram.Size = new System.Drawing.Size(269, 177);
			this.hexProgram.TabIndex = 5;
			this.hexProgram.UseFixedBytesPerLine = true;
			this.hexProgram.VScrollBarVisible = true;
			// 
			// label13
			// 
			this.label13.Dock = System.Windows.Forms.DockStyle.Top;
			this.label13.Location = new System.Drawing.Point(3, 16);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(269, 40);
			this.label13.TabIndex = 0;
			this.label13.Text = "Format: ABCC\r\nA: 0/1 = idle, 2 = write, 3 = read, B: 0-7 (reg number)\r\nCC: value " +
    "(ignored for read)";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(93, 106);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(97, 13);
			this.label12.TabIndex = 4;
			this.label12.Text = "(insert picture here)";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(947, 654);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(963, 692);
			this.Name = "frmMain";
			this.Text = "(Not so) Visual 2C02";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.flowLayoutPanel4.ResumeLayout(false);
			this.flowLayoutPanel4.PerformLayout();
			this.flowLayoutPanel3.ResumeLayout(false);
			this.flowLayoutPanel3.PerformLayout();
			this.flowLayoutPanel8.ResumeLayout(false);
			this.flowLayoutPanel8.PerformLayout();
			this.flowLayoutPanel7.ResumeLayout(false);
			this.flowLayoutPanel7.PerformLayout();
			this.flowLayoutPanel5.ResumeLayout(false);
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.flowLayoutPanel6.ResumeLayout(false);
			this.flowLayoutPanel6.PerformLayout();
			this.flowLayoutPanel9.ResumeLayout(false);
			this.flowLayoutPanel9.PerformLayout();
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanel5.PerformLayout();
			this.flowLayoutPanel11.ResumeLayout(false);
			this.tableLayoutPanel6.ResumeLayout(false);
			this.tableLayoutPanel6.PerformLayout();
			this.flowLayoutPanel12.ResumeLayout(false);
			this.tableLayoutPanel7.ResumeLayout(false);
			this.tableLayoutPanel7.PerformLayout();
			this.flowLayoutPanel13.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.grpReset.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.flowLayoutPanel10.ResumeLayout(false);
			this.flowLayoutPanel10.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblHz;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblHalfCycle;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblPixel;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblScanline;
		private System.Windows.Forms.Button btnRun;
		private System.Windows.Forms.Button btnNextPixel;
		private System.Windows.Forms.Button btnNextScanline;
		private System.Windows.Forms.Button btnNextFrame;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lblD;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblAb;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblClk;
		private GUI.DoubleBufferedListView lstLogView;
		private System.Windows.Forms.Button btnSelectColumns;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
		private System.Windows.Forms.Button btnStartLogging;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox grpReset;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.RadioButton radResetPostrenderOdd;
		private System.Windows.Forms.RadioButton radResetPrerenderOdd;
		private System.Windows.Forms.RadioButton radResetPrerenderEven;
		private System.Windows.Forms.RadioButton radResetPowerOn;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.Button btnSaveState;
		private System.Windows.Forms.Button btnLoadState;
		private Be.Windows.Forms.HexBox hexVram;
		private Be.Windows.Forms.HexBox hexPaletteRam;
		private Be.Windows.Forms.HexBox hexSpriteRam;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox cboRefreshSpeed;
		private System.Windows.Forms.CheckBox chkLogHex;
		private System.Windows.Forms.CheckBox chkLogCsv;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.GroupBox groupBox1;
		private Be.Windows.Forms.HexBox hexProgram;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.CheckBox chkShowInHex;
		private System.Windows.Forms.Button btnStep;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel11;
		private System.Windows.Forms.Button btnResetPalette;
		private System.Windows.Forms.Button btnImportPalette;
		private System.Windows.Forms.Button btnExportPalette;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel12;
		private System.Windows.Forms.Button btnResetSprite;
		private System.Windows.Forms.Button btnImportSprite;
		private System.Windows.Forms.Button btnExportSprite;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel13;
		private System.Windows.Forms.Button btnResetVram;
		private System.Windows.Forms.Button btnImportVram;
		private System.Windows.Forms.Button btnExportVram;
	}
}

