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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuLoadRom = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuSaveState = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuLoadState = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.debugToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuRun = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuPause = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuReset = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuPowerCycle = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuStep = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuNextPixel = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuNextScanline = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuNextFrame = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nTMirroringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuMirrorVertical = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuMirrorHorizontal = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuMirrorScreenA = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuMirrorScreenB = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuMirrorFourScreens = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
			this.refreshFrequencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuRefreshSlow = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuRefreshNormal = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuRefreshFast = new System.Windows.Forms.ToolStripMenuItem();
			this.showLayersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuShowDiffusion = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuShowGroundedDiffusion = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuShowPoweredDiffusion = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuShowPolysilicon = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuShowMetal = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuShowProtection = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuShowSimulationState = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuVideoOutputViewer = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.stepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nextPixelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1 = new GUI.ctrlSplitContainer();
			this.ctrlChipDisplay = new GUI.ctrlChipDisplay();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel24 = new System.Windows.Forms.FlowLayoutPanel();
			this.label30 = new System.Windows.Forms.Label();
			this.lblCpuDb = new System.Windows.Forms.Label();
			this.flowLayoutPanel23 = new System.Windows.Forms.FlowLayoutPanel();
			this.label28 = new System.Windows.Forms.Label();
			this.lblCpuAb = new System.Windows.Forms.Label();
			this.flowLayoutPanel22 = new System.Windows.Forms.FlowLayoutPanel();
			this.label26 = new System.Windows.Forms.Label();
			this.lblPC = new System.Windows.Forms.Label();
			this.flowLayoutPanel21 = new System.Windows.Forms.FlowLayoutPanel();
			this.label24 = new System.Windows.Forms.Label();
			this.lblPS = new System.Windows.Forms.Label();
			this.flowLayoutPanel15 = new System.Windows.Forms.FlowLayoutPanel();
			this.label13 = new System.Windows.Forms.Label();
			this.lblA = new System.Windows.Forms.Label();
			this.flowLayoutPanel18 = new System.Windows.Forms.FlowLayoutPanel();
			this.label18 = new System.Windows.Forms.Label();
			this.lblX = new System.Windows.Forms.Label();
			this.flowLayoutPanel19 = new System.Windows.Forms.FlowLayoutPanel();
			this.label20 = new System.Windows.Forms.Label();
			this.lblY = new System.Windows.Forms.Label();
			this.flowLayoutPanel20 = new System.Windows.Forms.FlowLayoutPanel();
			this.label22 = new System.Windows.Forms.Label();
			this.lblSP = new System.Windows.Forms.Label();
			this.flowLayoutPanel25 = new System.Windows.Forms.FlowLayoutPanel();
			this.label17 = new System.Windows.Forms.Label();
			this.lblOpCode = new System.Windows.Forms.Label();
			this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.label3 = new System.Windows.Forms.Label();
			this.lblScanline = new System.Windows.Forms.Label();
			this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
			this.label9 = new System.Windows.Forms.Label();
			this.lblPpuDb = new System.Windows.Forms.Label();
			this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
			this.label7 = new System.Windows.Forms.Label();
			this.lblPpuAb = new System.Windows.Forms.Label();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.lblPixel = new System.Windows.Forms.Label();
			this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
			this.label4 = new System.Windows.Forms.Label();
			this.lblHz = new System.Windows.Forms.Label();
			this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
			this.label5 = new System.Windows.Forms.Label();
			this.lblClk = new System.Windows.Forms.Label();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.lblHalfCycle = new System.Windows.Forms.Label();
			this.splitContainer2 = new GUI.ctrlSplitContainer();
			this.tabMemory = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel16 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnResetCpuRam = new System.Windows.Forms.Button();
			this.btnImportCpuRam = new System.Windows.Forms.Button();
			this.btnExportCpuRam = new System.Windows.Forms.Button();
			this.label15 = new System.Windows.Forms.Label();
			this.hexCpuRam = new Be.Windows.Forms.HexBox();
			this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel17 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnResetPrgRam = new System.Windows.Forms.Button();
			this.btnImportPrgRam = new System.Windows.Forms.Button();
			this.btnExportPrgRam = new System.Windows.Forms.Button();
			this.label16 = new System.Windows.Forms.Label();
			this.hexPrgRam = new Be.Windows.Forms.HexBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnResetNametableRam = new System.Windows.Forms.Button();
			this.btnImportNametableRam = new System.Windows.Forms.Button();
			this.btnExportNametableRam = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.hexNametableRam = new Be.Windows.Forms.HexBox();
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
			this.btnResetChrRam = new System.Windows.Forms.Button();
			this.btnImportChrRam = new System.Windows.Forms.Button();
			this.btnExportChrRam = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.hexChrRam = new Be.Windows.Forms.HexBox();
			this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
			this.btnSelectColumns = new System.Windows.Forms.Button();
			this.lstLogView = new GUI.DoubleBufferedListView();
			this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
			this.chkLogHex = new System.Windows.Forms.CheckBox();
			this.chkLogCsv = new System.Windows.Forms.CheckBox();
			this.btnStartLogging = new System.Windows.Forms.Button();
			this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
			this.chkShowInHex = new System.Windows.Forms.CheckBox();
			this.label12 = new System.Windows.Forms.Label();
			this.cboLogMaxLines = new System.Windows.Forms.ComboBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel13.SuspendLayout();
			this.flowLayoutPanel24.SuspendLayout();
			this.flowLayoutPanel23.SuspendLayout();
			this.flowLayoutPanel22.SuspendLayout();
			this.flowLayoutPanel21.SuspendLayout();
			this.flowLayoutPanel15.SuspendLayout();
			this.flowLayoutPanel18.SuspendLayout();
			this.flowLayoutPanel19.SuspendLayout();
			this.flowLayoutPanel20.SuspendLayout();
			this.flowLayoutPanel25.SuspendLayout();
			this.tableLayoutPanel10.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel8.SuspendLayout();
			this.flowLayoutPanel7.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.flowLayoutPanel4.SuspendLayout();
			this.flowLayoutPanel6.SuspendLayout();
			this.flowLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.tabMemory.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.tableLayoutPanel11.SuspendLayout();
			this.flowLayoutPanel16.SuspendLayout();
			this.tableLayoutPanel12.SuspendLayout();
			this.flowLayoutPanel17.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel9.SuspendLayout();
			this.flowLayoutPanel5.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.flowLayoutPanel11.SuspendLayout();
			this.tableLayoutPanel6.SuspendLayout();
			this.flowLayoutPanel12.SuspendLayout();
			this.tableLayoutPanel7.SuspendLayout();
			this.flowLayoutPanel13.SuspendLayout();
			this.tableLayoutPanel8.SuspendLayout();
			this.flowLayoutPanel9.SuspendLayout();
			this.flowLayoutPanel10.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.debugToolStripMenuItem1,
            this.optionsToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1079, 24);
			this.menuStrip1.TabIndex = 26;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLoadRom,
            this.toolStripMenuItem5,
            this.mnuSaveState,
            this.mnuLoadState,
            this.toolStripMenuItem1,
            this.mnuExit});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// mnuLoadRom
			// 
			this.mnuLoadRom.Image = global::GUI.Properties.Resources.Open;
			this.mnuLoadRom.Name = "mnuLoadRom";
			this.mnuLoadRom.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.mnuLoadRom.Size = new System.Drawing.Size(173, 22);
			this.mnuLoadRom.Text = "Load ROM";
			this.mnuLoadRom.Click += new System.EventHandler(this.mnuLoadRom_Click);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(170, 6);
			// 
			// mnuSaveState
			// 
			this.mnuSaveState.Name = "mnuSaveState";
			this.mnuSaveState.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.mnuSaveState.Size = new System.Drawing.Size(173, 22);
			this.mnuSaveState.Text = "Save state";
			this.mnuSaveState.Click += new System.EventHandler(this.mnuSaveState_Click);
			// 
			// mnuLoadState
			// 
			this.mnuLoadState.Name = "mnuLoadState";
			this.mnuLoadState.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
			this.mnuLoadState.Size = new System.Drawing.Size(173, 22);
			this.mnuLoadState.Text = "Load state";
			this.mnuLoadState.Click += new System.EventHandler(this.mnuLoadState_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(170, 6);
			// 
			// mnuExit
			// 
			this.mnuExit.Image = global::GUI.Properties.Resources.Exit;
			this.mnuExit.Name = "mnuExit";
			this.mnuExit.Size = new System.Drawing.Size(173, 22);
			this.mnuExit.Text = "Exit";
			this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
			// 
			// debugToolStripMenuItem1
			// 
			this.debugToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRun,
            this.mnuPause,
            this.mnuReset,
            this.mnuPowerCycle,
            this.toolStripMenuItem4,
            this.mnuStep,
            this.mnuNextPixel,
            this.mnuNextScanline,
            this.mnuNextFrame});
			this.debugToolStripMenuItem1.Name = "debugToolStripMenuItem1";
			this.debugToolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
			this.debugToolStripMenuItem1.Text = "Debug";
			// 
			// mnuRun
			// 
			this.mnuRun.Image = global::GUI.Properties.Resources.Play;
			this.mnuRun.Name = "mnuRun";
			this.mnuRun.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.mnuRun.Size = new System.Drawing.Size(180, 22);
			this.mnuRun.Text = "Run";
			this.mnuRun.Click += new System.EventHandler(this.mnuRun_Click);
			// 
			// mnuPause
			// 
			this.mnuPause.Image = global::GUI.Properties.Resources.Pause;
			this.mnuPause.Name = "mnuPause";
			this.mnuPause.ShortcutKeyDisplayString = "Esc";
			this.mnuPause.Size = new System.Drawing.Size(180, 22);
			this.mnuPause.Text = "Pause";
			this.mnuPause.Click += new System.EventHandler(this.mnuPause_Click);
			// 
			// mnuReset
			// 
			this.mnuReset.Image = global::GUI.Properties.Resources.Refresh;
			this.mnuReset.Name = "mnuReset";
			this.mnuReset.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.mnuReset.Size = new System.Drawing.Size(180, 22);
			this.mnuReset.Text = "Reset";
			this.mnuReset.Click += new System.EventHandler(this.mnuReset_Click);
			// 
			// mnuPowerCycle
			// 
			this.mnuPowerCycle.Image = global::GUI.Properties.Resources.Stop;
			this.mnuPowerCycle.Name = "mnuPowerCycle";
			this.mnuPowerCycle.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
			this.mnuPowerCycle.Size = new System.Drawing.Size(180, 22);
			this.mnuPowerCycle.Text = "Power Cycle";
			this.mnuPowerCycle.Click += new System.EventHandler(this.mnuPowerCycle_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(177, 6);
			// 
			// mnuStep
			// 
			this.mnuStep.Name = "mnuStep";
			this.mnuStep.ShortcutKeys = System.Windows.Forms.Keys.F11;
			this.mnuStep.Size = new System.Drawing.Size(180, 22);
			this.mnuStep.Text = "Step";
			this.mnuStep.Click += new System.EventHandler(this.mnuStep_Click);
			// 
			// mnuNextPixel
			// 
			this.mnuNextPixel.Name = "mnuNextPixel";
			this.mnuNextPixel.ShortcutKeys = System.Windows.Forms.Keys.F6;
			this.mnuNextPixel.Size = new System.Drawing.Size(180, 22);
			this.mnuNextPixel.Text = "Next Pixel";
			this.mnuNextPixel.Click += new System.EventHandler(this.mnuNextPixel_Click);
			// 
			// mnuNextScanline
			// 
			this.mnuNextScanline.Name = "mnuNextScanline";
			this.mnuNextScanline.ShortcutKeys = System.Windows.Forms.Keys.F7;
			this.mnuNextScanline.Size = new System.Drawing.Size(180, 22);
			this.mnuNextScanline.Text = "Next Scanline";
			this.mnuNextScanline.Click += new System.EventHandler(this.mnuNextScanline_Click);
			// 
			// mnuNextFrame
			// 
			this.mnuNextFrame.Name = "mnuNextFrame";
			this.mnuNextFrame.ShortcutKeys = System.Windows.Forms.Keys.F8;
			this.mnuNextFrame.Size = new System.Drawing.Size(180, 22);
			this.mnuNextFrame.Text = "Next Frame";
			this.mnuNextFrame.Click += new System.EventHandler(this.mnuNextFrame_Click);
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nTMirroringToolStripMenuItem,
            this.toolStripMenuItem6,
            this.refreshFrequencyToolStripMenuItem,
            this.showLayersToolStripMenuItem,
            this.mnuShowSimulationState});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.optionsToolStripMenuItem.Text = "Options";
			// 
			// nTMirroringToolStripMenuItem
			// 
			this.nTMirroringToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMirrorVertical,
            this.mnuMirrorHorizontal,
            this.mnuMirrorScreenA,
            this.mnuMirrorScreenB,
            this.mnuMirrorFourScreens});
			this.nTMirroringToolStripMenuItem.Name = "nTMirroringToolStripMenuItem";
			this.nTMirroringToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.nTMirroringToolStripMenuItem.Text = "Nametable Mirroring";
			// 
			// mnuMirrorVertical
			// 
			this.mnuMirrorVertical.Name = "mnuMirrorVertical";
			this.mnuMirrorVertical.Size = new System.Drawing.Size(155, 22);
			this.mnuMirrorVertical.Text = "Vertical";
			this.mnuMirrorVertical.Click += new System.EventHandler(this.mnuMirrorVertical_Click);
			// 
			// mnuMirrorHorizontal
			// 
			this.mnuMirrorHorizontal.Name = "mnuMirrorHorizontal";
			this.mnuMirrorHorizontal.Size = new System.Drawing.Size(155, 22);
			this.mnuMirrorHorizontal.Text = "Horizontal";
			this.mnuMirrorHorizontal.Click += new System.EventHandler(this.mnuMirrorHorizontal_Click);
			// 
			// mnuMirrorScreenA
			// 
			this.mnuMirrorScreenA.Name = "mnuMirrorScreenA";
			this.mnuMirrorScreenA.Size = new System.Drawing.Size(155, 22);
			this.mnuMirrorScreenA.Text = "Single Screen A";
			this.mnuMirrorScreenA.Click += new System.EventHandler(this.mnuMirrorScreenA_Click);
			// 
			// mnuMirrorScreenB
			// 
			this.mnuMirrorScreenB.Name = "mnuMirrorScreenB";
			this.mnuMirrorScreenB.Size = new System.Drawing.Size(155, 22);
			this.mnuMirrorScreenB.Text = "Single Screen B";
			this.mnuMirrorScreenB.Click += new System.EventHandler(this.mnuMirrorScreenB_Click);
			// 
			// mnuMirrorFourScreens
			// 
			this.mnuMirrorFourScreens.Name = "mnuMirrorFourScreens";
			this.mnuMirrorFourScreens.Size = new System.Drawing.Size(155, 22);
			this.mnuMirrorFourScreens.Text = "4 Screens";
			this.mnuMirrorFourScreens.Click += new System.EventHandler(this.mnuMirrorFourScreens_Click);
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(187, 6);
			// 
			// refreshFrequencyToolStripMenuItem
			// 
			this.refreshFrequencyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRefreshSlow,
            this.mnuRefreshNormal,
            this.mnuRefreshFast});
			this.refreshFrequencyToolStripMenuItem.Name = "refreshFrequencyToolStripMenuItem";
			this.refreshFrequencyToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.refreshFrequencyToolStripMenuItem.Text = "Refresh Frequency";
			// 
			// mnuRefreshSlow
			// 
			this.mnuRefreshSlow.Name = "mnuRefreshSlow";
			this.mnuRefreshSlow.Size = new System.Drawing.Size(114, 22);
			this.mnuRefreshSlow.Text = "Slow";
			this.mnuRefreshSlow.Click += new System.EventHandler(this.mnuRefreshSlow_Click);
			// 
			// mnuRefreshNormal
			// 
			this.mnuRefreshNormal.Checked = true;
			this.mnuRefreshNormal.CheckState = System.Windows.Forms.CheckState.Checked;
			this.mnuRefreshNormal.Name = "mnuRefreshNormal";
			this.mnuRefreshNormal.Size = new System.Drawing.Size(114, 22);
			this.mnuRefreshNormal.Text = "Normal";
			this.mnuRefreshNormal.Click += new System.EventHandler(this.mnuRefreshNormal_Click);
			// 
			// mnuRefreshFast
			// 
			this.mnuRefreshFast.Name = "mnuRefreshFast";
			this.mnuRefreshFast.Size = new System.Drawing.Size(114, 22);
			this.mnuRefreshFast.Text = "Fast";
			this.mnuRefreshFast.Click += new System.EventHandler(this.mnuRefreshFast_Click);
			// 
			// showLayersToolStripMenuItem
			// 
			this.showLayersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuShowDiffusion,
            this.mnuShowGroundedDiffusion,
            this.mnuShowPoweredDiffusion,
            this.mnuShowPolysilicon,
            this.mnuShowMetal,
            this.mnuShowProtection});
			this.showLayersToolStripMenuItem.Name = "showLayersToolStripMenuItem";
			this.showLayersToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.showLayersToolStripMenuItem.Text = "Show layers";
			// 
			// mnuShowDiffusion
			// 
			this.mnuShowDiffusion.Checked = true;
			this.mnuShowDiffusion.CheckOnClick = true;
			this.mnuShowDiffusion.CheckState = System.Windows.Forms.CheckState.Checked;
			this.mnuShowDiffusion.Name = "mnuShowDiffusion";
			this.mnuShowDiffusion.Size = new System.Drawing.Size(178, 22);
			this.mnuShowDiffusion.Text = "Diffusion";
			this.mnuShowDiffusion.CheckedChanged += new System.EventHandler(this.mnuShowLayer_CheckedChanged);
			// 
			// mnuShowGroundedDiffusion
			// 
			this.mnuShowGroundedDiffusion.Checked = true;
			this.mnuShowGroundedDiffusion.CheckOnClick = true;
			this.mnuShowGroundedDiffusion.CheckState = System.Windows.Forms.CheckState.Checked;
			this.mnuShowGroundedDiffusion.Name = "mnuShowGroundedDiffusion";
			this.mnuShowGroundedDiffusion.Size = new System.Drawing.Size(178, 22);
			this.mnuShowGroundedDiffusion.Text = "Grounded Diffusion";
			this.mnuShowGroundedDiffusion.CheckedChanged += new System.EventHandler(this.mnuShowLayer_CheckedChanged);
			// 
			// mnuShowPoweredDiffusion
			// 
			this.mnuShowPoweredDiffusion.Checked = true;
			this.mnuShowPoweredDiffusion.CheckOnClick = true;
			this.mnuShowPoweredDiffusion.CheckState = System.Windows.Forms.CheckState.Checked;
			this.mnuShowPoweredDiffusion.Name = "mnuShowPoweredDiffusion";
			this.mnuShowPoweredDiffusion.Size = new System.Drawing.Size(178, 22);
			this.mnuShowPoweredDiffusion.Text = "Powered Diffusion";
			this.mnuShowPoweredDiffusion.CheckedChanged += new System.EventHandler(this.mnuShowLayer_CheckedChanged);
			// 
			// mnuShowPolysilicon
			// 
			this.mnuShowPolysilicon.Checked = true;
			this.mnuShowPolysilicon.CheckOnClick = true;
			this.mnuShowPolysilicon.CheckState = System.Windows.Forms.CheckState.Checked;
			this.mnuShowPolysilicon.Name = "mnuShowPolysilicon";
			this.mnuShowPolysilicon.Size = new System.Drawing.Size(178, 22);
			this.mnuShowPolysilicon.Text = "Polysilicon";
			this.mnuShowPolysilicon.CheckedChanged += new System.EventHandler(this.mnuShowLayer_CheckedChanged);
			// 
			// mnuShowMetal
			// 
			this.mnuShowMetal.Checked = true;
			this.mnuShowMetal.CheckOnClick = true;
			this.mnuShowMetal.CheckState = System.Windows.Forms.CheckState.Checked;
			this.mnuShowMetal.Name = "mnuShowMetal";
			this.mnuShowMetal.Size = new System.Drawing.Size(178, 22);
			this.mnuShowMetal.Text = "Metal";
			this.mnuShowMetal.CheckedChanged += new System.EventHandler(this.mnuShowLayer_CheckedChanged);
			// 
			// mnuShowProtection
			// 
			this.mnuShowProtection.Checked = true;
			this.mnuShowProtection.CheckOnClick = true;
			this.mnuShowProtection.CheckState = System.Windows.Forms.CheckState.Checked;
			this.mnuShowProtection.Name = "mnuShowProtection";
			this.mnuShowProtection.Size = new System.Drawing.Size(178, 22);
			this.mnuShowProtection.Text = "Protection";
			this.mnuShowProtection.CheckedChanged += new System.EventHandler(this.mnuShowLayer_CheckedChanged);
			// 
			// mnuShowSimulationState
			// 
			this.mnuShowSimulationState.CheckOnClick = true;
			this.mnuShowSimulationState.Name = "mnuShowSimulationState";
			this.mnuShowSimulationState.Size = new System.Drawing.Size(190, 22);
			this.mnuShowSimulationState.Text = "Show simulation state";
			this.mnuShowSimulationState.CheckedChanged += new System.EventHandler(this.mnuShowSimulationState_CheckedChanged);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVideoOutputViewer});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.toolsToolStripMenuItem.Text = "Tools";
			// 
			// mnuVideoOutputViewer
			// 
			this.mnuVideoOutputViewer.Name = "mnuVideoOutputViewer";
			this.mnuVideoOutputViewer.Size = new System.Drawing.Size(183, 22);
			this.mnuVideoOutputViewer.Text = "Video Output Viewer";
			this.mnuVideoOutputViewer.Click += new System.EventHandler(this.mnuVideoOutputViewer_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// mnuAbout
			// 
			this.mnuAbout.Image = global::GUI.Properties.Resources.Icon;
			this.mnuAbout.Name = "mnuAbout";
			this.mnuAbout.Size = new System.Drawing.Size(107, 22);
			this.mnuAbout.Text = "About";
			this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
			// 
			// debugToolStripMenuItem
			// 
			this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem,
            this.toolStripMenuItem2,
            this.stepToolStripMenuItem,
            this.nextPixelToolStripMenuItem,
            this.toolStripMenuItem3});
			this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
			this.debugToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
			this.debugToolStripMenuItem.Text = "Debug";
			// 
			// runToolStripMenuItem
			// 
			this.runToolStripMenuItem.Name = "runToolStripMenuItem";
			this.runToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.runToolStripMenuItem.Text = "Run";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(122, 6);
			// 
			// stepToolStripMenuItem
			// 
			this.stepToolStripMenuItem.Name = "stepToolStripMenuItem";
			this.stepToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.stepToolStripMenuItem.Text = "Step";
			// 
			// nextPixelToolStripMenuItem
			// 
			this.nextPixelToolStripMenuItem.Name = "nextPixelToolStripMenuItem";
			this.nextPixelToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.nextPixelToolStripMenuItem.Text = "Next Pixel";
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(125, 22);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 24);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.ctrlChipDisplay);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
			this.splitContainer1.Size = new System.Drawing.Size(1079, 637);
			this.splitContainer1.SplitterDistance = 390;
			this.splitContainer1.TabIndex = 4;
			// 
			// ctrlChipDisplay
			// 
			this.ctrlChipDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ctrlChipDisplay.Location = new System.Drawing.Point(0, 0);
			this.ctrlChipDisplay.Name = "ctrlChipDisplay";
			this.ctrlChipDisplay.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.ctrlChipDisplay.ShowState = false;
			this.ctrlChipDisplay.Size = new System.Drawing.Size(390, 637);
			this.ctrlChipDisplay.TabIndex = 1;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 4;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(685, 637);
			this.tableLayoutPanel2.TabIndex = 3;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel13, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel10, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel6, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.splitContainer2, 0, 3);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel2.SetRowSpan(this.tableLayoutPanel1, 4);
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(679, 631);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel13
			// 
			this.tableLayoutPanel13.ColumnCount = 5;
			this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel13, 3);
			this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.49275F));
			this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.97585F));
			this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.11594F));
			this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.15584F));
			this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.79221F));
			this.tableLayoutPanel13.Controls.Add(this.flowLayoutPanel24, 3, 1);
			this.tableLayoutPanel13.Controls.Add(this.flowLayoutPanel23, 3, 0);
			this.tableLayoutPanel13.Controls.Add(this.flowLayoutPanel22, 2, 1);
			this.tableLayoutPanel13.Controls.Add(this.flowLayoutPanel21, 1, 1);
			this.tableLayoutPanel13.Controls.Add(this.flowLayoutPanel15, 0, 0);
			this.tableLayoutPanel13.Controls.Add(this.flowLayoutPanel18, 1, 0);
			this.tableLayoutPanel13.Controls.Add(this.flowLayoutPanel19, 2, 0);
			this.tableLayoutPanel13.Controls.Add(this.flowLayoutPanel20, 0, 1);
			this.tableLayoutPanel13.Controls.Add(this.flowLayoutPanel25, 4, 0);
			this.tableLayoutPanel13.Location = new System.Drawing.Point(255, 0);
			this.tableLayoutPanel13.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel13.Name = "tableLayoutPanel13";
			this.tableLayoutPanel13.RowCount = 3;
			this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel13, 2);
			this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel13.Size = new System.Drawing.Size(414, 40);
			this.tableLayoutPanel13.TabIndex = 24;
			// 
			// flowLayoutPanel24
			// 
			this.flowLayoutPanel24.AutoSize = true;
			this.flowLayoutPanel24.Controls.Add(this.label30);
			this.flowLayoutPanel24.Controls.Add(this.lblCpuDb);
			this.flowLayoutPanel24.Location = new System.Drawing.Point(197, 20);
			this.flowLayoutPanel24.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel24.Name = "flowLayoutPanel24";
			this.flowLayoutPanel24.Size = new System.Drawing.Size(75, 13);
			this.flowLayoutPanel24.TabIndex = 9;
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Location = new System.Drawing.Point(3, 0);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(50, 13);
			this.label30.TabIndex = 1;
			this.label30.Text = "CPU DB:";
			// 
			// lblCpuDb
			// 
			this.lblCpuDb.AutoSize = true;
			this.lblCpuDb.Location = new System.Drawing.Point(59, 0);
			this.lblCpuDb.Name = "lblCpuDb";
			this.lblCpuDb.Size = new System.Drawing.Size(13, 13);
			this.lblCpuDb.TabIndex = 1;
			this.lblCpuDb.Text = "0";
			// 
			// flowLayoutPanel23
			// 
			this.flowLayoutPanel23.AutoSize = true;
			this.flowLayoutPanel23.Controls.Add(this.label28);
			this.flowLayoutPanel23.Controls.Add(this.lblCpuAb);
			this.flowLayoutPanel23.Location = new System.Drawing.Point(197, 0);
			this.flowLayoutPanel23.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel23.Name = "flowLayoutPanel23";
			this.flowLayoutPanel23.Size = new System.Drawing.Size(74, 13);
			this.flowLayoutPanel23.TabIndex = 8;
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Location = new System.Drawing.Point(3, 0);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(49, 13);
			this.label28.TabIndex = 1;
			this.label28.Text = "CPU AB:";
			// 
			// lblCpuAb
			// 
			this.lblCpuAb.AutoSize = true;
			this.lblCpuAb.Location = new System.Drawing.Point(58, 0);
			this.lblCpuAb.Name = "lblCpuAb";
			this.lblCpuAb.Size = new System.Drawing.Size(13, 13);
			this.lblCpuAb.TabIndex = 1;
			this.lblCpuAb.Text = "0";
			// 
			// flowLayoutPanel22
			// 
			this.flowLayoutPanel22.AutoSize = true;
			this.flowLayoutPanel22.Controls.Add(this.label26);
			this.flowLayoutPanel22.Controls.Add(this.lblPC);
			this.flowLayoutPanel22.Location = new System.Drawing.Point(122, 20);
			this.flowLayoutPanel22.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel22.Name = "flowLayoutPanel22";
			this.flowLayoutPanel22.Size = new System.Drawing.Size(49, 13);
			this.flowLayoutPanel22.TabIndex = 7;
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Location = new System.Drawing.Point(3, 0);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(24, 13);
			this.label26.TabIndex = 1;
			this.label26.Text = "PC:";
			// 
			// lblPC
			// 
			this.lblPC.AutoSize = true;
			this.lblPC.Location = new System.Drawing.Point(33, 0);
			this.lblPC.Name = "lblPC";
			this.lblPC.Size = new System.Drawing.Size(13, 13);
			this.lblPC.TabIndex = 1;
			this.lblPC.Text = "0";
			// 
			// flowLayoutPanel21
			// 
			this.flowLayoutPanel21.AutoSize = true;
			this.flowLayoutPanel21.Controls.Add(this.label24);
			this.flowLayoutPanel21.Controls.Add(this.lblPS);
			this.flowLayoutPanel21.Location = new System.Drawing.Point(60, 20);
			this.flowLayoutPanel21.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel21.Name = "flowLayoutPanel21";
			this.flowLayoutPanel21.Size = new System.Drawing.Size(49, 13);
			this.flowLayoutPanel21.TabIndex = 6;
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(3, 0);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(24, 13);
			this.label24.TabIndex = 1;
			this.label24.Text = "PS:";
			// 
			// lblPS
			// 
			this.lblPS.AutoSize = true;
			this.lblPS.Location = new System.Drawing.Point(33, 0);
			this.lblPS.Name = "lblPS";
			this.lblPS.Size = new System.Drawing.Size(13, 13);
			this.lblPS.TabIndex = 1;
			this.lblPS.Text = "0";
			// 
			// flowLayoutPanel15
			// 
			this.flowLayoutPanel15.AutoSize = true;
			this.flowLayoutPanel15.Controls.Add(this.label13);
			this.flowLayoutPanel15.Controls.Add(this.lblA);
			this.flowLayoutPanel15.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel15.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel15.Name = "flowLayoutPanel15";
			this.flowLayoutPanel15.Size = new System.Drawing.Size(42, 13);
			this.flowLayoutPanel15.TabIndex = 3;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(3, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(17, 13);
			this.label13.TabIndex = 2;
			this.label13.Text = "A:";
			// 
			// lblA
			// 
			this.lblA.AutoSize = true;
			this.lblA.Location = new System.Drawing.Point(26, 0);
			this.lblA.Name = "lblA";
			this.lblA.Size = new System.Drawing.Size(13, 13);
			this.lblA.TabIndex = 3;
			this.lblA.Text = "0";
			// 
			// flowLayoutPanel18
			// 
			this.flowLayoutPanel18.AutoSize = true;
			this.flowLayoutPanel18.Controls.Add(this.label18);
			this.flowLayoutPanel18.Controls.Add(this.lblX);
			this.flowLayoutPanel18.Location = new System.Drawing.Point(60, 0);
			this.flowLayoutPanel18.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel18.Name = "flowLayoutPanel18";
			this.flowLayoutPanel18.Size = new System.Drawing.Size(42, 13);
			this.flowLayoutPanel18.TabIndex = 4;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(3, 0);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(17, 13);
			this.label18.TabIndex = 1;
			this.label18.Text = "X:";
			// 
			// lblX
			// 
			this.lblX.AutoSize = true;
			this.lblX.Location = new System.Drawing.Point(26, 0);
			this.lblX.Name = "lblX";
			this.lblX.Size = new System.Drawing.Size(13, 13);
			this.lblX.TabIndex = 2;
			this.lblX.Text = "0";
			// 
			// flowLayoutPanel19
			// 
			this.flowLayoutPanel19.AutoSize = true;
			this.flowLayoutPanel19.Controls.Add(this.label20);
			this.flowLayoutPanel19.Controls.Add(this.lblY);
			this.flowLayoutPanel19.Location = new System.Drawing.Point(122, 0);
			this.flowLayoutPanel19.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel19.Name = "flowLayoutPanel19";
			this.flowLayoutPanel19.Size = new System.Drawing.Size(42, 13);
			this.flowLayoutPanel19.TabIndex = 5;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(3, 0);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(17, 13);
			this.label20.TabIndex = 1;
			this.label20.Text = "Y:";
			// 
			// lblY
			// 
			this.lblY.AutoSize = true;
			this.lblY.Location = new System.Drawing.Point(26, 0);
			this.lblY.Name = "lblY";
			this.lblY.Size = new System.Drawing.Size(13, 13);
			this.lblY.TabIndex = 1;
			this.lblY.Text = "0";
			// 
			// flowLayoutPanel20
			// 
			this.flowLayoutPanel20.AutoSize = true;
			this.flowLayoutPanel20.Controls.Add(this.label22);
			this.flowLayoutPanel20.Controls.Add(this.lblSP);
			this.flowLayoutPanel20.Location = new System.Drawing.Point(0, 20);
			this.flowLayoutPanel20.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel20.Name = "flowLayoutPanel20";
			this.flowLayoutPanel20.Size = new System.Drawing.Size(49, 13);
			this.flowLayoutPanel20.TabIndex = 5;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(3, 0);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(24, 13);
			this.label22.TabIndex = 1;
			this.label22.Text = "SP:";
			// 
			// lblSP
			// 
			this.lblSP.AutoSize = true;
			this.lblSP.Location = new System.Drawing.Point(33, 0);
			this.lblSP.Name = "lblSP";
			this.lblSP.Size = new System.Drawing.Size(13, 13);
			this.lblSP.TabIndex = 1;
			this.lblSP.Text = "0";
			// 
			// flowLayoutPanel25
			// 
			this.flowLayoutPanel25.AutoSize = true;
			this.flowLayoutPanel25.Controls.Add(this.label17);
			this.flowLayoutPanel25.Controls.Add(this.lblOpCode);
			this.flowLayoutPanel25.Location = new System.Drawing.Point(297, 0);
			this.flowLayoutPanel25.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel25.Name = "flowLayoutPanel25";
			this.flowLayoutPanel25.Size = new System.Drawing.Size(59, 13);
			this.flowLayoutPanel25.TabIndex = 10;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(3, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(34, 13);
			this.label17.TabIndex = 1;
			this.label17.Text = "Exec:";
			// 
			// lblOpCode
			// 
			this.lblOpCode.AutoSize = true;
			this.lblOpCode.Location = new System.Drawing.Point(43, 0);
			this.lblOpCode.Name = "lblOpCode";
			this.lblOpCode.Size = new System.Drawing.Size(13, 13);
			this.lblOpCode.TabIndex = 1;
			this.lblOpCode.Text = "0";
			// 
			// tableLayoutPanel10
			// 
			this.tableLayoutPanel10.ColumnCount = 2;
			this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel10, 2);
			this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.33333F));
			this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.66667F));
			this.tableLayoutPanel10.Controls.Add(this.flowLayoutPanel1, 0, 0);
			this.tableLayoutPanel10.Controls.Add(this.flowLayoutPanel8, 1, 1);
			this.tableLayoutPanel10.Controls.Add(this.flowLayoutPanel7, 1, 0);
			this.tableLayoutPanel10.Controls.Add(this.flowLayoutPanel2, 0, 1);
			this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel10.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel10.Name = "tableLayoutPanel10";
			this.tableLayoutPanel10.RowCount = 3;
			this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel10, 2);
			this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel10.Size = new System.Drawing.Size(255, 40);
			this.tableLayoutPanel10.TabIndex = 23;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.Controls.Add(this.label3);
			this.flowLayoutPanel1.Controls.Add(this.lblScanline);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
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
			// flowLayoutPanel8
			// 
			this.flowLayoutPanel8.AutoSize = true;
			this.flowLayoutPanel8.Controls.Add(this.label9);
			this.flowLayoutPanel8.Controls.Add(this.lblPpuDb);
			this.flowLayoutPanel8.Location = new System.Drawing.Point(135, 20);
			this.flowLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel8.Name = "flowLayoutPanel8";
			this.flowLayoutPanel8.Size = new System.Drawing.Size(75, 13);
			this.flowLayoutPanel8.TabIndex = 5;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(3, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(50, 13);
			this.label9.TabIndex = 1;
			this.label9.Text = "PPU DB:";
			// 
			// lblPpuDb
			// 
			this.lblPpuDb.AutoSize = true;
			this.lblPpuDb.Location = new System.Drawing.Point(59, 0);
			this.lblPpuDb.Name = "lblPpuDb";
			this.lblPpuDb.Size = new System.Drawing.Size(13, 13);
			this.lblPpuDb.TabIndex = 1;
			this.lblPpuDb.Text = "0";
			// 
			// flowLayoutPanel7
			// 
			this.flowLayoutPanel7.AutoSize = true;
			this.flowLayoutPanel7.Controls.Add(this.label7);
			this.flowLayoutPanel7.Controls.Add(this.lblPpuAb);
			this.flowLayoutPanel7.Location = new System.Drawing.Point(135, 0);
			this.flowLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel7.Name = "flowLayoutPanel7";
			this.flowLayoutPanel7.Size = new System.Drawing.Size(74, 13);
			this.flowLayoutPanel7.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(49, 13);
			this.label7.TabIndex = 1;
			this.label7.Text = "PPU AB:";
			// 
			// lblPpuAb
			// 
			this.lblPpuAb.AutoSize = true;
			this.lblPpuAb.Location = new System.Drawing.Point(58, 0);
			this.lblPpuAb.Name = "lblPpuAb";
			this.lblPpuAb.Size = new System.Drawing.Size(13, 13);
			this.lblPpuAb.TabIndex = 1;
			this.lblPpuAb.Text = "0";
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.AutoSize = true;
			this.flowLayoutPanel2.Controls.Add(this.label2);
			this.flowLayoutPanel2.Controls.Add(this.lblPixel);
			this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 20);
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
			// flowLayoutPanel4
			// 
			this.flowLayoutPanel4.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel4, 3);
			this.flowLayoutPanel4.Controls.Add(this.label4);
			this.flowLayoutPanel4.Controls.Add(this.lblHz);
			this.flowLayoutPanel4.Location = new System.Drawing.Point(255, 40);
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
			// flowLayoutPanel6
			// 
			this.flowLayoutPanel6.AutoSize = true;
			this.flowLayoutPanel6.Controls.Add(this.label5);
			this.flowLayoutPanel6.Controls.Add(this.lblClk);
			this.flowLayoutPanel6.Location = new System.Drawing.Point(135, 40);
			this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel6.Name = "flowLayoutPanel6";
			this.flowLayoutPanel6.Size = new System.Drawing.Size(50, 13);
			this.flowLayoutPanel6.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(25, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "Clk:";
			// 
			// lblClk
			// 
			this.lblClk.AutoSize = true;
			this.lblClk.Location = new System.Drawing.Point(34, 0);
			this.lblClk.Name = "lblClk";
			this.lblClk.Size = new System.Drawing.Size(13, 13);
			this.lblClk.TabIndex = 1;
			this.lblClk.Text = "0";
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.AutoSize = true;
			this.flowLayoutPanel3.Controls.Add(this.label1);
			this.flowLayoutPanel3.Controls.Add(this.lblHalfCycle);
			this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 40);
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
			// splitContainer2
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.splitContainer2, 5);
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(3, 63);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.tabMemory);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel8);
			this.splitContainer2.Size = new System.Drawing.Size(673, 565);
			this.splitContainer2.SplitterDistance = 336;
			this.splitContainer2.TabIndex = 25;
			// 
			// tabMemory
			// 
			this.tabMemory.Controls.Add(this.tabPage1);
			this.tabMemory.Controls.Add(this.tabPage2);
			this.tabMemory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabMemory.Location = new System.Drawing.Point(0, 0);
			this.tabMemory.Name = "tabMemory";
			this.tabMemory.SelectedIndex = 0;
			this.tabMemory.Size = new System.Drawing.Size(673, 336);
			this.tabMemory.TabIndex = 22;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.tableLayoutPanel4);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(665, 310);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "CPU (2A03)";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 1;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel11, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel12, 0, 1);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 2;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(659, 304);
			this.tableLayoutPanel4.TabIndex = 1;
			// 
			// tableLayoutPanel11
			// 
			this.tableLayoutPanel11.ColumnCount = 3;
			this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel11.Controls.Add(this.flowLayoutPanel16, 2, 0);
			this.tableLayoutPanel11.Controls.Add(this.label15, 0, 0);
			this.tableLayoutPanel11.Controls.Add(this.hexCpuRam, 1, 0);
			this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel11.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel11.Name = "tableLayoutPanel11";
			this.tableLayoutPanel11.RowCount = 1;
			this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel11.Size = new System.Drawing.Size(659, 152);
			this.tableLayoutPanel11.TabIndex = 19;
			// 
			// flowLayoutPanel16
			// 
			this.flowLayoutPanel16.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.flowLayoutPanel16.Controls.Add(this.btnResetCpuRam);
			this.flowLayoutPanel16.Controls.Add(this.btnImportCpuRam);
			this.flowLayoutPanel16.Controls.Add(this.btnExportCpuRam);
			this.flowLayoutPanel16.Location = new System.Drawing.Point(581, 61);
			this.flowLayoutPanel16.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel16.Name = "flowLayoutPanel16";
			this.flowLayoutPanel16.Size = new System.Drawing.Size(78, 29);
			this.flowLayoutPanel16.TabIndex = 22;
			this.flowLayoutPanel16.WrapContents = false;
			// 
			// btnResetCpuRam
			// 
			this.btnResetCpuRam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnResetCpuRam.Image = global::GUI.Properties.Resources.Refresh;
			this.btnResetCpuRam.Location = new System.Drawing.Point(0, 3);
			this.btnResetCpuRam.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.btnResetCpuRam.Name = "btnResetCpuRam";
			this.btnResetCpuRam.Size = new System.Drawing.Size(26, 23);
			this.btnResetCpuRam.TabIndex = 8;
			this.btnResetCpuRam.UseVisualStyleBackColor = true;
			this.btnResetCpuRam.Click += new System.EventHandler(this.btnResetCpuRam_Click);
			// 
			// btnImportCpuRam
			// 
			this.btnImportCpuRam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnImportCpuRam.Image = global::GUI.Properties.Resources.Import;
			this.btnImportCpuRam.Location = new System.Drawing.Point(26, 3);
			this.btnImportCpuRam.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.btnImportCpuRam.Name = "btnImportCpuRam";
			this.btnImportCpuRam.Size = new System.Drawing.Size(26, 23);
			this.btnImportCpuRam.TabIndex = 9;
			this.btnImportCpuRam.UseVisualStyleBackColor = true;
			this.btnImportCpuRam.Click += new System.EventHandler(this.btnImportCpuRam_Click);
			// 
			// btnExportCpuRam
			// 
			this.btnExportCpuRam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExportCpuRam.Image = global::GUI.Properties.Resources.Export;
			this.btnExportCpuRam.Location = new System.Drawing.Point(52, 3);
			this.btnExportCpuRam.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.btnExportCpuRam.Name = "btnExportCpuRam";
			this.btnExportCpuRam.Size = new System.Drawing.Size(26, 23);
			this.btnExportCpuRam.TabIndex = 10;
			this.btnExportCpuRam.UseVisualStyleBackColor = true;
			this.btnExportCpuRam.Click += new System.EventHandler(this.btnExportCpuRam_Click);
			// 
			// label15
			// 
			this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(3, 69);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(59, 13);
			this.label15.TabIndex = 21;
			this.label15.Text = "CPU RAM:";
			// 
			// hexCpuRam
			// 
			this.hexCpuRam.Dock = System.Windows.Forms.DockStyle.Fill;
			this.hexCpuRam.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.hexCpuRam.LineInfoVisible = true;
			this.hexCpuRam.Location = new System.Drawing.Point(93, 3);
			this.hexCpuRam.Name = "hexCpuRam";
			this.hexCpuRam.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
			this.hexCpuRam.Size = new System.Drawing.Size(485, 146);
			this.hexCpuRam.TabIndex = 16;
			this.hexCpuRam.UseFixedBytesPerLine = true;
			this.hexCpuRam.VScrollBarVisible = true;
			this.hexCpuRam.SizeChanged += new System.EventHandler(this.hexViewer_SizeChanged);
			// 
			// tableLayoutPanel12
			// 
			this.tableLayoutPanel12.ColumnCount = 3;
			this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel12.Controls.Add(this.flowLayoutPanel17, 2, 0);
			this.tableLayoutPanel12.Controls.Add(this.label16, 0, 0);
			this.tableLayoutPanel12.Controls.Add(this.hexPrgRam, 1, 0);
			this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel12.Location = new System.Drawing.Point(0, 152);
			this.tableLayoutPanel12.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel12.Name = "tableLayoutPanel12";
			this.tableLayoutPanel12.RowCount = 1;
			this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel12.Size = new System.Drawing.Size(659, 152);
			this.tableLayoutPanel12.TabIndex = 20;
			// 
			// flowLayoutPanel17
			// 
			this.flowLayoutPanel17.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.flowLayoutPanel17.Controls.Add(this.btnResetPrgRam);
			this.flowLayoutPanel17.Controls.Add(this.btnImportPrgRam);
			this.flowLayoutPanel17.Controls.Add(this.btnExportPrgRam);
			this.flowLayoutPanel17.Location = new System.Drawing.Point(581, 61);
			this.flowLayoutPanel17.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel17.Name = "flowLayoutPanel17";
			this.flowLayoutPanel17.Size = new System.Drawing.Size(78, 29);
			this.flowLayoutPanel17.TabIndex = 23;
			this.flowLayoutPanel17.WrapContents = false;
			// 
			// btnResetPrgRam
			// 
			this.btnResetPrgRam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnResetPrgRam.Image = global::GUI.Properties.Resources.Refresh;
			this.btnResetPrgRam.Location = new System.Drawing.Point(0, 3);
			this.btnResetPrgRam.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.btnResetPrgRam.Name = "btnResetPrgRam";
			this.btnResetPrgRam.Size = new System.Drawing.Size(26, 23);
			this.btnResetPrgRam.TabIndex = 8;
			this.btnResetPrgRam.UseVisualStyleBackColor = true;
			this.btnResetPrgRam.Click += new System.EventHandler(this.btnResetPrgRam_Click);
			// 
			// btnImportPrgRam
			// 
			this.btnImportPrgRam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnImportPrgRam.Image = global::GUI.Properties.Resources.Import;
			this.btnImportPrgRam.Location = new System.Drawing.Point(26, 3);
			this.btnImportPrgRam.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.btnImportPrgRam.Name = "btnImportPrgRam";
			this.btnImportPrgRam.Size = new System.Drawing.Size(26, 23);
			this.btnImportPrgRam.TabIndex = 9;
			this.btnImportPrgRam.UseVisualStyleBackColor = true;
			this.btnImportPrgRam.Click += new System.EventHandler(this.btnImportPrgRam_Click);
			// 
			// btnExportPrgRam
			// 
			this.btnExportPrgRam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExportPrgRam.Image = global::GUI.Properties.Resources.Export;
			this.btnExportPrgRam.Location = new System.Drawing.Point(52, 3);
			this.btnExportPrgRam.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.btnExportPrgRam.Name = "btnExportPrgRam";
			this.btnExportPrgRam.Size = new System.Drawing.Size(26, 23);
			this.btnExportPrgRam.TabIndex = 10;
			this.btnExportPrgRam.UseVisualStyleBackColor = true;
			this.btnExportPrgRam.Click += new System.EventHandler(this.btnExportPrgRam_Click);
			// 
			// label16
			// 
			this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(3, 69);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(60, 13);
			this.label16.TabIndex = 22;
			this.label16.Text = "PRG RAM:";
			// 
			// hexPrgRam
			// 
			this.hexPrgRam.ColumnInfoVisible = true;
			this.hexPrgRam.Dock = System.Windows.Forms.DockStyle.Fill;
			this.hexPrgRam.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.hexPrgRam.LineInfoOffset = ((long)(32768));
			this.hexPrgRam.LineInfoVisible = true;
			this.hexPrgRam.Location = new System.Drawing.Point(93, 3);
			this.hexPrgRam.Name = "hexPrgRam";
			this.hexPrgRam.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
			this.hexPrgRam.Size = new System.Drawing.Size(485, 146);
			this.hexPrgRam.TabIndex = 4;
			this.hexPrgRam.UseFixedBytesPerLine = true;
			this.hexPrgRam.VScrollBarVisible = true;
			this.hexPrgRam.SizeChanged += new System.EventHandler(this.hexViewer_SizeChanged);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.tableLayoutPanel3);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(665, 310);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "PPU (2C02)";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel9, 0, 3);
			this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 0, 2);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 4;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.75248F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.62376F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.62376F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(659, 304);
			this.tableLayoutPanel3.TabIndex = 0;
			// 
			// tableLayoutPanel9
			// 
			this.tableLayoutPanel9.ColumnCount = 3;
			this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel9.Controls.Add(this.flowLayoutPanel5, 2, 0);
			this.tableLayoutPanel9.Controls.Add(this.label11, 0, 0);
			this.tableLayoutPanel9.Controls.Add(this.hexNametableRam, 1, 0);
			this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 205);
			this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel9.Name = "tableLayoutPanel9";
			this.tableLayoutPanel9.RowCount = 1;
			this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel9.Size = new System.Drawing.Size(659, 99);
			this.tableLayoutPanel9.TabIndex = 21;
			// 
			// flowLayoutPanel5
			// 
			this.flowLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.flowLayoutPanel5.Controls.Add(this.btnResetNametableRam);
			this.flowLayoutPanel5.Controls.Add(this.btnImportNametableRam);
			this.flowLayoutPanel5.Controls.Add(this.btnExportNametableRam);
			this.flowLayoutPanel5.Location = new System.Drawing.Point(581, 35);
			this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel5.Name = "flowLayoutPanel5";
			this.flowLayoutPanel5.Size = new System.Drawing.Size(78, 29);
			this.flowLayoutPanel5.TabIndex = 23;
			this.flowLayoutPanel5.WrapContents = false;
			// 
			// btnResetNametableRam
			// 
			this.btnResetNametableRam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnResetNametableRam.Image = global::GUI.Properties.Resources.Refresh;
			this.btnResetNametableRam.Location = new System.Drawing.Point(0, 3);
			this.btnResetNametableRam.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.btnResetNametableRam.Name = "btnResetNametableRam";
			this.btnResetNametableRam.Size = new System.Drawing.Size(26, 23);
			this.btnResetNametableRam.TabIndex = 8;
			this.btnResetNametableRam.UseVisualStyleBackColor = true;
			this.btnResetNametableRam.Click += new System.EventHandler(this.btnResetNametableRam_Click);
			// 
			// btnImportNametableRam
			// 
			this.btnImportNametableRam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnImportNametableRam.Image = global::GUI.Properties.Resources.Import;
			this.btnImportNametableRam.Location = new System.Drawing.Point(26, 3);
			this.btnImportNametableRam.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.btnImportNametableRam.Name = "btnImportNametableRam";
			this.btnImportNametableRam.Size = new System.Drawing.Size(26, 23);
			this.btnImportNametableRam.TabIndex = 9;
			this.btnImportNametableRam.UseVisualStyleBackColor = true;
			this.btnImportNametableRam.Click += new System.EventHandler(this.btnImportNametableRam_Click);
			// 
			// btnExportNametableRam
			// 
			this.btnExportNametableRam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExportNametableRam.Image = global::GUI.Properties.Resources.Export;
			this.btnExportNametableRam.Location = new System.Drawing.Point(52, 3);
			this.btnExportNametableRam.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.btnExportNametableRam.Name = "btnExportNametableRam";
			this.btnExportNametableRam.Size = new System.Drawing.Size(26, 23);
			this.btnExportNametableRam.TabIndex = 10;
			this.btnExportNametableRam.UseVisualStyleBackColor = true;
			this.btnExportNametableRam.Click += new System.EventHandler(this.btnExportNametableRam_Click);
			// 
			// label11
			// 
			this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(3, 43);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(52, 13);
			this.label11.TabIndex = 22;
			this.label11.Text = "NT RAM:";
			// 
			// hexNametableRam
			// 
			this.hexNametableRam.Dock = System.Windows.Forms.DockStyle.Fill;
			this.hexNametableRam.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.hexNametableRam.LineInfoOffset = ((long)(8192));
			this.hexNametableRam.LineInfoVisible = true;
			this.hexNametableRam.Location = new System.Drawing.Point(93, 3);
			this.hexNametableRam.Name = "hexNametableRam";
			this.hexNametableRam.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
			this.hexNametableRam.Size = new System.Drawing.Size(485, 93);
			this.hexNametableRam.TabIndex = 4;
			this.hexNametableRam.UseFixedBytesPerLine = true;
			this.hexNametableRam.VScrollBarVisible = true;
			this.hexNametableRam.SizeChanged += new System.EventHandler(this.hexViewer_SizeChanged);
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.ColumnCount = 3;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel5.Controls.Add(this.flowLayoutPanel11, 2, 0);
			this.tableLayoutPanel5.Controls.Add(this.hexPaletteRam, 1, 0);
			this.tableLayoutPanel5.Controls.Add(this.label6, 0, 0);
			this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 1;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(659, 44);
			this.tableLayoutPanel5.TabIndex = 18;
			// 
			// flowLayoutPanel11
			// 
			this.flowLayoutPanel11.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.flowLayoutPanel11.Controls.Add(this.btnResetPalette);
			this.flowLayoutPanel11.Controls.Add(this.btnImportPalette);
			this.flowLayoutPanel11.Controls.Add(this.btnExportPalette);
			this.flowLayoutPanel11.Location = new System.Drawing.Point(581, 7);
			this.flowLayoutPanel11.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel11.Name = "flowLayoutPanel11";
			this.flowLayoutPanel11.Size = new System.Drawing.Size(78, 29);
			this.flowLayoutPanel11.TabIndex = 19;
			this.flowLayoutPanel11.WrapContents = false;
			// 
			// btnResetPalette
			// 
			this.btnResetPalette.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnResetPalette.Image = global::GUI.Properties.Resources.Refresh;
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
			this.hexPaletteRam.Dock = System.Windows.Forms.DockStyle.Fill;
			this.hexPaletteRam.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.hexPaletteRam.LineInfoVisible = true;
			this.hexPaletteRam.Location = new System.Drawing.Point(93, 3);
			this.hexPaletteRam.Name = "hexPaletteRam";
			this.hexPaletteRam.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
			this.hexPaletteRam.Size = new System.Drawing.Size(485, 38);
			this.hexPaletteRam.TabIndex = 17;
			this.hexPaletteRam.UseFixedBytesPerLine = true;
			this.hexPaletteRam.SizeChanged += new System.EventHandler(this.hexViewer_SizeChanged);
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
			this.tableLayoutPanel6.ColumnCount = 3;
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel6.Controls.Add(this.flowLayoutPanel12, 2, 0);
			this.tableLayoutPanel6.Controls.Add(this.label8, 0, 0);
			this.tableLayoutPanel6.Controls.Add(this.hexSpriteRam, 1, 0);
			this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 44);
			this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel6.Name = "tableLayoutPanel6";
			this.tableLayoutPanel6.RowCount = 1;
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel6.Size = new System.Drawing.Size(659, 64);
			this.tableLayoutPanel6.TabIndex = 19;
			// 
			// flowLayoutPanel12
			// 
			this.flowLayoutPanel12.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.flowLayoutPanel12.Controls.Add(this.btnResetSprite);
			this.flowLayoutPanel12.Controls.Add(this.btnImportSprite);
			this.flowLayoutPanel12.Controls.Add(this.btnExportSprite);
			this.flowLayoutPanel12.Location = new System.Drawing.Point(581, 17);
			this.flowLayoutPanel12.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel12.Name = "flowLayoutPanel12";
			this.flowLayoutPanel12.Size = new System.Drawing.Size(78, 29);
			this.flowLayoutPanel12.TabIndex = 22;
			this.flowLayoutPanel12.WrapContents = false;
			// 
			// btnResetSprite
			// 
			this.btnResetSprite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnResetSprite.Image = global::GUI.Properties.Resources.Refresh;
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
			this.label8.Location = new System.Drawing.Point(3, 25);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(64, 13);
			this.label8.TabIndex = 21;
			this.label8.Text = "Sprite RAM:";
			// 
			// hexSpriteRam
			// 
			this.hexSpriteRam.Dock = System.Windows.Forms.DockStyle.Fill;
			this.hexSpriteRam.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.hexSpriteRam.LineInfoVisible = true;
			this.hexSpriteRam.Location = new System.Drawing.Point(93, 3);
			this.hexSpriteRam.Name = "hexSpriteRam";
			this.hexSpriteRam.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
			this.hexSpriteRam.Size = new System.Drawing.Size(485, 58);
			this.hexSpriteRam.TabIndex = 16;
			this.hexSpriteRam.UseFixedBytesPerLine = true;
			this.hexSpriteRam.VScrollBarVisible = true;
			this.hexSpriteRam.SizeChanged += new System.EventHandler(this.hexViewer_SizeChanged);
			// 
			// tableLayoutPanel7
			// 
			this.tableLayoutPanel7.ColumnCount = 3;
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel7.Controls.Add(this.flowLayoutPanel13, 2, 0);
			this.tableLayoutPanel7.Controls.Add(this.label10, 0, 0);
			this.tableLayoutPanel7.Controls.Add(this.hexChrRam, 1, 0);
			this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 108);
			this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel7.Name = "tableLayoutPanel7";
			this.tableLayoutPanel7.RowCount = 1;
			this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel7.Size = new System.Drawing.Size(659, 97);
			this.tableLayoutPanel7.TabIndex = 20;
			// 
			// flowLayoutPanel13
			// 
			this.flowLayoutPanel13.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.flowLayoutPanel13.Controls.Add(this.btnResetChrRam);
			this.flowLayoutPanel13.Controls.Add(this.btnImportChrRam);
			this.flowLayoutPanel13.Controls.Add(this.btnExportChrRam);
			this.flowLayoutPanel13.Location = new System.Drawing.Point(581, 34);
			this.flowLayoutPanel13.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel13.Name = "flowLayoutPanel13";
			this.flowLayoutPanel13.Size = new System.Drawing.Size(78, 29);
			this.flowLayoutPanel13.TabIndex = 23;
			this.flowLayoutPanel13.WrapContents = false;
			// 
			// btnResetChrRam
			// 
			this.btnResetChrRam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnResetChrRam.Image = global::GUI.Properties.Resources.Refresh;
			this.btnResetChrRam.Location = new System.Drawing.Point(0, 3);
			this.btnResetChrRam.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.btnResetChrRam.Name = "btnResetChrRam";
			this.btnResetChrRam.Size = new System.Drawing.Size(26, 23);
			this.btnResetChrRam.TabIndex = 8;
			this.btnResetChrRam.UseVisualStyleBackColor = true;
			this.btnResetChrRam.Click += new System.EventHandler(this.btnResetChrRam_Click);
			// 
			// btnImportChrRam
			// 
			this.btnImportChrRam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnImportChrRam.Image = global::GUI.Properties.Resources.Import;
			this.btnImportChrRam.Location = new System.Drawing.Point(26, 3);
			this.btnImportChrRam.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.btnImportChrRam.Name = "btnImportChrRam";
			this.btnImportChrRam.Size = new System.Drawing.Size(26, 23);
			this.btnImportChrRam.TabIndex = 9;
			this.btnImportChrRam.UseVisualStyleBackColor = true;
			this.btnImportChrRam.Click += new System.EventHandler(this.btnImportChrRam_Click);
			// 
			// btnExportChrRam
			// 
			this.btnExportChrRam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExportChrRam.Image = global::GUI.Properties.Resources.Export;
			this.btnExportChrRam.Location = new System.Drawing.Point(52, 3);
			this.btnExportChrRam.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.btnExportChrRam.Name = "btnExportChrRam";
			this.btnExportChrRam.Size = new System.Drawing.Size(26, 23);
			this.btnExportChrRam.TabIndex = 10;
			this.btnExportChrRam.UseVisualStyleBackColor = true;
			this.btnExportChrRam.Click += new System.EventHandler(this.btnExportChrRam_Click);
			// 
			// label10
			// 
			this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(3, 42);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(60, 13);
			this.label10.TabIndex = 22;
			this.label10.Text = "CHR RAM:";
			// 
			// hexChrRam
			// 
			this.hexChrRam.ColumnInfoVisible = true;
			this.hexChrRam.Dock = System.Windows.Forms.DockStyle.Fill;
			this.hexChrRam.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.hexChrRam.LineInfoVisible = true;
			this.hexChrRam.Location = new System.Drawing.Point(93, 3);
			this.hexChrRam.Name = "hexChrRam";
			this.hexChrRam.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
			this.hexChrRam.Size = new System.Drawing.Size(485, 91);
			this.hexChrRam.TabIndex = 4;
			this.hexChrRam.UseFixedBytesPerLine = true;
			this.hexChrRam.VScrollBarVisible = true;
			this.hexChrRam.SizeChanged += new System.EventHandler(this.hexViewer_SizeChanged);
			// 
			// tableLayoutPanel8
			// 
			this.tableLayoutPanel8.ColumnCount = 4;
			this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel8.Controls.Add(this.btnSelectColumns, 0, 0);
			this.tableLayoutPanel8.Controls.Add(this.lstLogView, 0, 1);
			this.tableLayoutPanel8.Controls.Add(this.flowLayoutPanel9, 2, 0);
			this.tableLayoutPanel8.Controls.Add(this.flowLayoutPanel10, 1, 0);
			this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel8.Name = "tableLayoutPanel8";
			this.tableLayoutPanel8.RowCount = 2;
			this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel8.Size = new System.Drawing.Size(673, 225);
			this.tableLayoutPanel8.TabIndex = 0;
			// 
			// btnSelectColumns
			// 
			this.btnSelectColumns.Location = new System.Drawing.Point(3, 3);
			this.btnSelectColumns.Name = "btnSelectColumns";
			this.btnSelectColumns.Size = new System.Drawing.Size(95, 23);
			this.btnSelectColumns.TabIndex = 13;
			this.btnSelectColumns.Text = "Select Columns";
			this.btnSelectColumns.UseVisualStyleBackColor = true;
			this.btnSelectColumns.Click += new System.EventHandler(this.btnSelectColumns_Click);
			// 
			// lstLogView
			// 
			this.tableLayoutPanel8.SetColumnSpan(this.lstLogView, 4);
			this.lstLogView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstLogView.FullRowSelect = true;
			this.lstLogView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lstLogView.Location = new System.Drawing.Point(3, 32);
			this.lstLogView.Name = "lstLogView";
			this.lstLogView.Size = new System.Drawing.Size(667, 190);
			this.lstLogView.TabIndex = 12;
			this.lstLogView.UseCompatibleStateImageBehavior = false;
			this.lstLogView.View = System.Windows.Forms.View.Details;
			// 
			// flowLayoutPanel9
			// 
			this.flowLayoutPanel9.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.flowLayoutPanel9.AutoSize = true;
			this.tableLayoutPanel8.SetColumnSpan(this.flowLayoutPanel9, 2);
			this.flowLayoutPanel9.Controls.Add(this.chkLogHex);
			this.flowLayoutPanel9.Controls.Add(this.chkLogCsv);
			this.flowLayoutPanel9.Controls.Add(this.btnStartLogging);
			this.flowLayoutPanel9.Location = new System.Drawing.Point(393, 0);
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
			// flowLayoutPanel10
			// 
			this.flowLayoutPanel10.Controls.Add(this.chkShowInHex);
			this.flowLayoutPanel10.Controls.Add(this.label12);
			this.flowLayoutPanel10.Controls.Add(this.cboLogMaxLines);
			this.flowLayoutPanel10.Location = new System.Drawing.Point(101, 0);
			this.flowLayoutPanel10.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel10.Name = "flowLayoutPanel10";
			this.flowLayoutPanel10.Size = new System.Drawing.Size(281, 29);
			this.flowLayoutPanel10.TabIndex = 16;
			// 
			// chkShowInHex
			// 
			this.chkShowInHex.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chkShowInHex.AutoSize = true;
			this.chkShowInHex.Checked = true;
			this.chkShowInHex.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkShowInHex.Location = new System.Drawing.Point(3, 5);
			this.chkShowInHex.Name = "chkShowInHex";
			this.chkShowInHex.Size = new System.Drawing.Size(86, 17);
			this.chkShowInHex.TabIndex = 21;
			this.chkShowInHex.Text = "Show in Hex";
			this.chkShowInHex.UseVisualStyleBackColor = true;
			this.chkShowInHex.CheckedChanged += new System.EventHandler(this.chkShowInHex_CheckedChanged);
			// 
			// label12
			// 
			this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(95, 7);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(92, 13);
			this.label12.TabIndex = 22;
			this.label12.Text = "Max num. of lines:";
			// 
			// cboLogMaxLines
			// 
			this.cboLogMaxLines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboLogMaxLines.FormattingEnabled = true;
			this.cboLogMaxLines.Items.AddRange(new object[] {
            "100",
            "200",
            "500"});
			this.cboLogMaxLines.Location = new System.Drawing.Point(193, 3);
			this.cboLogMaxLines.Name = "cboLogMaxLines";
			this.cboLogMaxLines.Size = new System.Drawing.Size(57, 21);
			this.cboLogMaxLines.TabIndex = 23;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1079, 661);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(1095, 699);
			this.Name = "frmMain";
			this.Text = "Visual NES - 2A03 & 2C02 simulator";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel13.ResumeLayout(false);
			this.tableLayoutPanel13.PerformLayout();
			this.flowLayoutPanel24.ResumeLayout(false);
			this.flowLayoutPanel24.PerformLayout();
			this.flowLayoutPanel23.ResumeLayout(false);
			this.flowLayoutPanel23.PerformLayout();
			this.flowLayoutPanel22.ResumeLayout(false);
			this.flowLayoutPanel22.PerformLayout();
			this.flowLayoutPanel21.ResumeLayout(false);
			this.flowLayoutPanel21.PerformLayout();
			this.flowLayoutPanel15.ResumeLayout(false);
			this.flowLayoutPanel15.PerformLayout();
			this.flowLayoutPanel18.ResumeLayout(false);
			this.flowLayoutPanel18.PerformLayout();
			this.flowLayoutPanel19.ResumeLayout(false);
			this.flowLayoutPanel19.PerformLayout();
			this.flowLayoutPanel20.ResumeLayout(false);
			this.flowLayoutPanel20.PerformLayout();
			this.flowLayoutPanel25.ResumeLayout(false);
			this.flowLayoutPanel25.PerformLayout();
			this.tableLayoutPanel10.ResumeLayout(false);
			this.tableLayoutPanel10.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.flowLayoutPanel8.ResumeLayout(false);
			this.flowLayoutPanel8.PerformLayout();
			this.flowLayoutPanel7.ResumeLayout(false);
			this.flowLayoutPanel7.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			this.flowLayoutPanel4.ResumeLayout(false);
			this.flowLayoutPanel4.PerformLayout();
			this.flowLayoutPanel6.ResumeLayout(false);
			this.flowLayoutPanel6.PerformLayout();
			this.flowLayoutPanel3.ResumeLayout(false);
			this.flowLayoutPanel3.PerformLayout();
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.tabMemory.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel11.ResumeLayout(false);
			this.tableLayoutPanel11.PerformLayout();
			this.flowLayoutPanel16.ResumeLayout(false);
			this.tableLayoutPanel12.ResumeLayout(false);
			this.tableLayoutPanel12.PerformLayout();
			this.flowLayoutPanel17.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel9.ResumeLayout(false);
			this.tableLayoutPanel9.PerformLayout();
			this.flowLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanel5.PerformLayout();
			this.flowLayoutPanel11.ResumeLayout(false);
			this.tableLayoutPanel6.ResumeLayout(false);
			this.tableLayoutPanel6.PerformLayout();
			this.flowLayoutPanel12.ResumeLayout(false);
			this.tableLayoutPanel7.ResumeLayout(false);
			this.tableLayoutPanel7.PerformLayout();
			this.flowLayoutPanel13.ResumeLayout(false);
			this.tableLayoutPanel8.ResumeLayout(false);
			this.tableLayoutPanel8.PerformLayout();
			this.flowLayoutPanel9.ResumeLayout(false);
			this.flowLayoutPanel9.PerformLayout();
			this.flowLayoutPanel10.ResumeLayout(false);
			this.flowLayoutPanel10.PerformLayout();
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
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lblPpuDb;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblPpuAb;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblClk;
		private GUI.DoubleBufferedListView lstLogView;
		private System.Windows.Forms.Button btnSelectColumns;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
		private System.Windows.Forms.Button btnStartLogging;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private Be.Windows.Forms.HexBox hexChrRam;
		private Be.Windows.Forms.HexBox hexPaletteRam;
		private Be.Windows.Forms.HexBox hexSpriteRam;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.CheckBox chkLogHex;
		private System.Windows.Forms.CheckBox chkLogCsv;
		private System.Windows.Forms.CheckBox chkShowInHex;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel11;
		private System.Windows.Forms.Button btnResetPalette;
		private System.Windows.Forms.Button btnImportPalette;
		private System.Windows.Forms.Button btnExportPalette;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel12;
		private System.Windows.Forms.Button btnResetSprite;
		private System.Windows.Forms.Button btnImportSprite;
		private System.Windows.Forms.Button btnExportSprite;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel13;
		private System.Windows.Forms.Button btnResetChrRam;
		private System.Windows.Forms.Button btnImportChrRam;
		private System.Windows.Forms.Button btnExportChrRam;
		private ctrlSplitContainer splitContainer1;
		private System.Windows.Forms.TabControl tabMemory;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel16;
		private System.Windows.Forms.Button btnResetCpuRam;
		private System.Windows.Forms.Button btnExportCpuRam;
		private System.Windows.Forms.Label label15;
		private Be.Windows.Forms.HexBox hexCpuRam;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel17;
		private System.Windows.Forms.Button btnResetPrgRam;
		private System.Windows.Forms.Button btnImportPrgRam;
		private System.Windows.Forms.Button btnExportPrgRam;
		private System.Windows.Forms.Label label16;
		private Be.Windows.Forms.HexBox hexPrgRam;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel22;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label lblPC;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel21;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label lblPS;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel15;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label lblA;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel18;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label lblX;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label lblY;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel20;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label lblSP;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel24;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label lblCpuDb;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel23;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label lblCpuAb;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel25;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label lblOpCode;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuLoadRom;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem mnuExit;
		private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem stepToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nextPixelToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem mnuRun;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem mnuStep;
		private System.Windows.Forms.ToolStripMenuItem mnuNextPixel;
		private System.Windows.Forms.ToolStripMenuItem mnuNextScanline;
		private System.Windows.Forms.ToolStripMenuItem mnuNextFrame;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem refreshFrequencyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuRefreshSlow;
		private System.Windows.Forms.ToolStripMenuItem mnuRefreshNormal;
		private System.Windows.Forms.ToolStripMenuItem mnuRefreshFast;
		private System.Windows.Forms.ToolStripMenuItem mnuReset;
		private System.Windows.Forms.ToolStripMenuItem mnuPowerCycle;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem mnuSaveState;
		private System.Windows.Forms.ToolStripMenuItem mnuLoadState;
		private System.Windows.Forms.ToolStripMenuItem nTMirroringToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
		private System.Windows.Forms.ToolStripMenuItem mnuMirrorVertical;
		private System.Windows.Forms.ToolStripMenuItem mnuMirrorHorizontal;
		private System.Windows.Forms.ToolStripMenuItem mnuMirrorScreenA;
		private System.Windows.Forms.ToolStripMenuItem mnuMirrorScreenB;
		private System.Windows.Forms.ToolStripMenuItem mnuMirrorFourScreens;
		private System.Windows.Forms.ToolStripMenuItem mnuPause;
		private ctrlChipDisplay ctrlChipDisplay;
		private System.Windows.Forms.ToolStripMenuItem showLayersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuShowDiffusion;
		private System.Windows.Forms.ToolStripMenuItem mnuShowGroundedDiffusion;
		private System.Windows.Forms.ToolStripMenuItem mnuShowPoweredDiffusion;
		private System.Windows.Forms.ToolStripMenuItem mnuShowMetal;
		private System.Windows.Forms.ToolStripMenuItem mnuShowProtection;
		private System.Windows.Forms.ToolStripMenuItem mnuShowSimulationState;
		private System.Windows.Forms.ToolStripMenuItem mnuShowPolysilicon;
		private ctrlSplitContainer splitContainer2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
		private System.Windows.Forms.Button btnImportCpuRam;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
		private System.Windows.Forms.Button btnResetNametableRam;
		private System.Windows.Forms.Button btnImportNametableRam;
		private System.Windows.Forms.Button btnExportNametableRam;
		private System.Windows.Forms.Label label11;
		private Be.Windows.Forms.HexBox hexNametableRam;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel10;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox cboLogMaxLines;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuAbout;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuVideoOutputViewer;
	}
}

