using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Be.Windows.Forms;

namespace GUI
{
	public partial class frmMain : Form
	{
		private List<string> _tracedColumns = new List<string> { "cycle", "hpos", "vpos", "ab", "db", "cpu_a", "cpu_x", "cpu_y", "cpu_db", "cpu_ab", "io_rw", "io_ce" };
		private Dictionary<int, string> _opName = new Dictionary<int, string>() {
			{ 0x00,"BRK"},{0x01,"ORA (zp,X)"},{0x05,"ORA zp"},{0x06,"ASL zp"},{0x08,"PHP"},{0x09,"ORA #"},{0x0A,"ASL "},{0x0D,"ORA Abs"},{0x0E,"ASL Abs"},{0x10,"BPL "},{0x11,"ORA (zp),Y"},
			{ 0x15,"ORA zp,X"},{0x16,"ASL zp,X"},{0x18,"CLC"},{0x19,"ORA Abs,Y"},{0x1D,"ORA Abs,X"},{0x1E,"ASL Abs,X"},{0x20,"JSR Abs"},{0x21,"AND (zp,X)"},{0x24,"BIT zp"},{0x25,"AND zp"},
			{ 0x26,"ROL zp"},{0x28,"PLP"},{0x29,"AND #"},{0x2A,"ROL "},{0x2C,"BIT Abs"},{0x2D,"AND Abs"},{0x2E,"ROL Abs"},{0x30,"BMI "},{0x31,"AND (zp),Y"},{0x35,"AND zp,X"},{0x36,"ROL zp,X"},
			{ 0x38,"SEC"},{0x39,"AND Abs,Y"},{0x3D,"AND Abs,X"},{0x3E,"ROL Abs,X"},{0x40,"RTI"},{0x41,"EOR (zp,X)"},{0x45,"EOR zp"},{0x46,"LSR zp"},{0x48,"PHA"},{0x49,"EOR #"},{0x4A,"LSR "},
			{ 0x4C,"JMP Abs"},{0x4D,"EOR Abs"},{0x4E,"LSR Abs"},{0x50,"BVC "},{0x51,"EOR (zp),Y"},{0x55,"EOR zp,X"},{0x56,"LSR zp,X"},{0x58,"CLI"},{0x59,"EOR Abs,Y"},{0x5D,"EOR Abs,X"},
			{ 0x5E,"LSR Abs,X"},{0x60,"RTS"},{0x61,"ADC (zp,X)"},{0x65,"ADC zp"},{0x66,"ROR zp"},{0x68,"PLA"},{0x69,"ADC #"},{0x6A,"ROR "},{0x6C,"JMP zp"},{0x6D,"ADC Abs"},{0x6E,"ROR Abs"},
			{ 0x70,"BVS "},{0x71,"ADC (zp),Y"},{0x75,"ADC zp,X"},{0x76,"ROR zp,X"},{0x78,"SEI"},{0x79,"ADC Abs,Y"},{0x7D,"ADC Abs,X"},{0x7E,"ROR Abs,X"},{0x81,"STA (zp,X)"},{0x84,"STY zp"},
			{ 0x85,"STA zp"},{0x86,"STX zp"},{0x88,"DEY"},{0x8A,"TXA"},{0x8C,"STY Abs"},{0x8D,"STA Abs"},{0x8E,"STX Abs"},{0x90,"BCC "},{0x91,"STA (zp),Y"},{0x94,"STY zp,X"},{0x95,"STA zp,X"},
			{ 0x96,"STX zp,Y"},{0x98,"TYA"},{0x99,"STA Abs,Y"},{0x9A,"TXS"},{0x9D,"STA Abs,X"},{0xA0,"LDY #"},{0xA1,"LDA (zp,X)"},{0xA2,"LDX #"},{0xA4,"LDY zp"},{0xA5,"LDA zp"},{0xA6,"LDX zp"},
			{ 0xA8,"TAY"},{0xA9,"LDA #"},{0xAA,"TAX"},{0xAC,"LDY Abs"},{0xAD,"LDA Abs"},{0xAE,"LDX Abs"},{0xB0,"BCS "},{0xB1,"LDA (zp),Y"},{0xB4,"LDY zp,X"},{0xB5,"LDA zp,X"},{0xB6,"LDX zp,Y"},
			{ 0xB8,"CLV"},{0xB9,"LDA Abs,Y"},{0xBA,"TSX"},{0xBC,"LDY Abs,X"},{0xBD,"LDA Abs,X"},{0xBE,"LDX Abs,Y"},{0xC0,"CPY #"},{0xC1,"CMP (zp,X)"},{0xC4,"CPY zp"},{0xC5,"CMP zp"},{0xC6,"DEC zp"},
			{ 0xC8,"INY"},{0xC9,"CMP #"},{0xCA,"DEX"},{0xCC,"CPY Abs"},{0xCD,"CMP Abs"},{0xCE,"DEC Abs"},{0xD0,"BNE "},{0xD1,"CMP (zp),Y"},{0xD5,"CMP zp,X"},{0xD6,"DEC zp,X"},{0xD8,"CLD"},
			{ 0xD9,"CMP Abs,Y"},{0xDD,"CMP Abs,X"},{0xDE,"DEC Abs,X"},{0xE0,"CPX #"},{0xE1,"SBC (zp,X)"},{0xE4,"CPX zp"},{0xE5,"SBC zp"},{0xE6,"INC zp"},{0xE8,"INX"},{0xE9,"SBC #"},{0xEA,"NOP"},
			{ 0xEC,"CPX Abs"},{0xED,"SBC Abs"},{0xEE,"INC Abs"},{0xF0,"BEQ "},{0xF1,"SBC (zp),Y"},{0xF5,"SBC zp,X"},{0xF6,"INC zp,X"},{0xF8,"SED"},{0xF9,"SBC Abs,Y"},{0xFD,"SBC Abs,X"},
			{ 0xFE,"INC Abs,X"}
		};

		private const string _windowTitle = "Visual NES - 2A03 & 2C02 simulator";
		internal static string CurrentRom = "";
		private frmVideoViewer _videoViewer = null;

		private bool _autoRun = false;
		private object _runLock = new object();
		private int _stepsToRun = 0;
		private bool _needColumnUpdate = true;
		private EmulationState _previousState = new EmulationState();
		private Task _emulationThread = null;
		private bool _stopFlag = false;
		private string _dumpPath;
		private bool _chrRamChanged = false;
		private bool _nametableRamChanged = false;
		private bool _paletteRamChanged = false;
		private bool _spriteRamChanged = false;
		private bool _cpuRamChanged = false;
		private bool _prgRamChanged = false;
		private int _refreshSpeed = 4000;
		private bool _logging = false;
		private byte[] _chrRamData;
		private byte[] _nametableRamData;
		private byte[] _paletteData;
		private byte[] _spriteData;
		private byte[] _cpuRamData;
		private byte[] _prgRamData;
		private ChipDefinitions _chipDef = new ChipDefinitions();

		public frmMain()
		{
			InitializeComponent();

			if(!DesignMode) {
				ctrlChipDisplay.SetChipDefinitions(_chipDef);
				_dumpPath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "Dumps");
				Directory.CreateDirectory(_dumpPath);
			}
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if(keyData == Keys.Escape) {
				Stop();
				return true;
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if(!DesignMode) {
				cboLogMaxLines.SelectedIndex = 0;
				SetMirroring(MirroringType.Horizontal);

				CoreWrapper.initEmulator();
				CoreWrapper.setTrace(string.Join("|", _tracedColumns));
				CoreWrapper.reset(string.Empty, false);

				Step(1);

				StartEmulationThread();
			}
		}

		protected override void OnClosed(EventArgs e)
		{
			Stop();
			_stopFlag = true;
			if(_emulationThread != null) {
				_emulationThread.Wait();
			}
			CoreWrapper.release();
			base.OnClosed(e);
		}

		private void StartEmulationThread()
		{
			_emulationThread = Task.Run(() => {
				while(!_stopFlag) {
					while(!_stopFlag && _stepsToRun > 0) {
						UpdateRam();

						int stepsToRun = Math.Min(_refreshSpeed, _stepsToRun);
						Interlocked.Add(ref _stepsToRun, -stepsToRun);

						Stopwatch sw = new Stopwatch();
						lock(_runLock) {
							sw.Start();
							CoreWrapper.step((UInt32)stepsToRun);
							CoreWrapper.getState(ref _previousState);
							
							_chrRamData = CoreWrapper.getMemoryState(MemoryType.ChrRam);
							_nametableRamData =  CoreWrapper.getMemoryState(MemoryType.NametableRam);
							_paletteData = CoreWrapper.getMemoryState(MemoryType.PaletteRam);
							_spriteData = CoreWrapper.getMemoryState(MemoryType.SpriteRam);
							_cpuRamData = CoreWrapper.getMemoryState(MemoryType.CpuRam);
							_prgRamData = CoreWrapper.getMemoryState(MemoryType.PrgRam);

							if(mnuShowSimulationState.Checked) {
								ctrlChipDisplay.ShowState = true;
								ctrlChipDisplay.RefreshState(true);
							}
							sw.Stop();
						}

						this.BeginInvoke((MethodInvoker)(() => {
							double emulatedHz = Stopwatch.Frequency / (double)sw.ElapsedTicks * stepsToRun / 2;
							int nesMasterClockSpeed = 21477272;
							double speedPercent = (emulatedHz / nesMasterClockSpeed) * 100;
							lblHz.Text = string.Format("{0:0} ({1:0.0000}% of NES speed - {2:0.0000} FPM)", emulatedHz, speedPercent, speedPercent / 100 * 60.1 * 60);

							UpdateUI();
						}));
					}

					if(_autoRun) {
						Interlocked.Add(ref _stepsToRun, _refreshSpeed);
					} else {
						System.Threading.Thread.Sleep(50);
					}
				}
			});
		}

		private void UpdateRam()
		{
			lock(_runLock) {
				if(_chrRamChanged) {
					CoreWrapper.setMemoryState(MemoryType.ChrRam, ((StaticByteProvider)hexChrRam.ByteProvider).Bytes.ToArray());
				}
				if(_nametableRamChanged) {
					CoreWrapper.setMemoryState(MemoryType.NametableRam, ((StaticByteProvider)hexNametableRam.ByteProvider).Bytes.ToArray());
				}
				if(_paletteRamChanged) {
					CoreWrapper.setMemoryState(MemoryType.PaletteRam, ((StaticByteProvider)hexPaletteRam.ByteProvider).Bytes.ToArray());
				}
				if(_spriteRamChanged) {
					CoreWrapper.setMemoryState(MemoryType.SpriteRam, ((StaticByteProvider)hexSpriteRam.ByteProvider).Bytes.ToArray());
				}
				if(_cpuRamChanged) {
					CoreWrapper.setMemoryState(MemoryType.CpuRam, ((StaticByteProvider)hexCpuRam.ByteProvider).Bytes.ToArray());
				}
				if(_prgRamChanged) {
					CoreWrapper.setMemoryState(MemoryType.PrgRam, ((StaticByteProvider)hexPrgRam.ByteProvider).Bytes.ToArray());
				}
			}
			_chrRamChanged = false;
			_nametableRamChanged = false;
			_paletteRamChanged = false;
			_spriteRamChanged = false;
			_cpuRamChanged = false;
			_prgRamChanged = false;
		}

		private void UpdateUI()
		{
			this.Text = _windowTitle;
			if(CurrentRom.Length > 0) {
				this.Text += " - " + Path.GetFileNameWithoutExtension(CurrentRom);
			}

			lblHalfCycle.Text = _previousState.halfcycle.ToString();
			lblPixel.Text = _previousState.hpos.ToString();
			lblScanline.Text = _previousState.vpos.ToString();
			lblFrameCount.Text = (_previousState.halfcycle / (8 * 341 * 262 - 1)).ToString();

			lblClk.Text = _previousState.clk.ToString();
			lblPpuAb.Text = _previousState.ab.ToString("X4");
			lblPpuDb.Text = _previousState.d.ToString("X2");

			lblA.Text = _previousState.a.ToString("X2");
			lblX.Text = _previousState.x.ToString("X2");
			lblY.Text = _previousState.y.ToString("X2");
			lblPS.Text = _previousState.ps.ToString("X2");
			lblSP.Text = _previousState.sp.ToString("X2");
			lblPC.Text = _previousState.pc.ToString("X4");

			lblCpuAb.Text = _previousState.cpu_ab.ToString("X4");
			lblPpuDb.Text = _previousState.cpu_db.ToString("X2");
			lblOpCode.Text = _opName.ContainsKey(_previousState.opCode) ? _opName[_previousState.opCode] : "n/a";

			UpdateMemoryViews();
			UpdateLogList();
		}

		private void UpdateMemoryViews()
		{
			StaticByteProvider chrRamBp = new StaticByteProvider(_chrRamData);
			StaticByteProvider nametableRamBp = new StaticByteProvider(_nametableRamData);
			StaticByteProvider paletteBp = new StaticByteProvider(_paletteData);
			StaticByteProvider spriteBp = new StaticByteProvider(_spriteData);
			StaticByteProvider cpuRamBp = new StaticByteProvider(_cpuRamData);
			StaticByteProvider prgRamBp = new StaticByteProvider(_prgRamData);
			hexChrRam.ByteProvider = chrRamBp;
			hexNametableRam.ByteProvider = nametableRamBp;
			hexPaletteRam.ByteProvider = paletteBp;
			hexSpriteRam.ByteProvider = spriteBp;
			hexCpuRam.ByteProvider = cpuRamBp;
			hexPrgRam.ByteProvider = prgRamBp;

			chrRamBp.ByteChanged += (index, e) => { _chrRamChanged = true; };
			nametableRamBp.ByteChanged += (index, e) => { _nametableRamChanged = true; };
			spriteBp.ByteChanged += (index, e) => { _spriteRamChanged = true; };
			cpuRamBp.ByteChanged += (index, e) => { _cpuRamChanged = true; };
			prgRamBp.ByteChanged += (index, e) => { _prgRamChanged = true; };
			paletteBp.ByteChanged += (index, e) => {
				//Mirror palette writes
				int i = (int)index;
				if(i == 0x10 || i == 0x14 || i == 0x18 || i == 0x1C) {
					paletteBp.WriteByte(i - 0x10, paletteBp.Bytes[i]);
				} else if(i == 0x00 || i == 0x04 || i == 0x08 || i == 0x0C) {
					paletteBp.WriteByte(i + 0x10, paletteBp.Bytes[i]);
				}
				_paletteRamChanged = true;
			};
		}

		private void UpdateLogList()
		{
			lstLogView.BeginUpdate();

			int numLines = int.Parse(cboLogMaxLines.SelectedItem.ToString());
			numLines = Math.Min(numLines, 10000 / _tracedColumns.Count);
			if(_needColumnUpdate || lstLogView.Items.Count != numLines) {
				_needColumnUpdate = false;
				lstLogView.Clear();
				foreach(string column in _tracedColumns) {
					lstLogView.Columns.Add(column);
				}

				for(int i = 0; i < numLines; i++) {
					ListViewItem item = new ListViewItem("");
					for(int j = 0; j < _tracedColumns.Count - 1; j++) {
						item.SubItems.Add("");
					}
					lstLogView.Items.Add(item);
				}
			}

			int pos = 0;
			int row = 0;
			bool endOfArray = false;

			while(row < numLines) {
				for(int j = 0; j < _tracedColumns.Count; j++) {
					if(pos >= 10000) {
						break;
					}
					if(_previousState.recentLog[pos] == -1) {
						endOfArray = true;
					}
					string newVal = (pos >= _previousState.recentLog.Length || endOfArray) ? "" : _previousState.recentLog[pos].ToString(chkShowInHex.Checked ? "X2" : "");
					if(lstLogView.Items[row].SubItems[j].Text != newVal) {
						lstLogView.Items[row].SubItems[j].Text = newVal;
					}
					pos++;
				}

				row++;
			}

			lstLogView.EndUpdate();
		}

		private void Stop()
		{
			mnuRun.Enabled = true;
			mnuPause.Enabled = false;
			_autoRun = false;
		}

		private void Step(UInt32 step)
		{
			Interlocked.Exchange(ref _stepsToRun, (int)step);
		}

		private void Reset(bool softReset)
		{
			lock(_runLock) {
				CoreWrapper.reset(string.Empty, softReset);
				Step(1);
			}
		}

		private void SaveFile(string filter, Action<string> callback)
		{
			using(SaveFileDialog sfd = new SaveFileDialog()) {
				sfd.InitialDirectory = _dumpPath;
				sfd.Filter = filter;
				sfd.FileName = "data";
				if(sfd.ShowDialog() == DialogResult.OK) {
					callback(sfd.FileName);
				}
			}
		}

		private void LoadFile(string filter, Action<string> callback)
		{
			using(OpenFileDialog ofd = new OpenFileDialog()) {
				ofd.InitialDirectory = _dumpPath;
				ofd.Filter = filter;
				ofd.FileName = "data";
				if(ofd.ShowDialog() == DialogResult.OK) {
					callback(ofd.FileName);
				}
			}
		}

		private void btnStartLogging_Click(object sender, EventArgs e)
		{
			if(_logging) {
				btnStartLogging.Text = "Start Logging";
				_logging = false;
				chkLogHex.Enabled = true;
				chkLogCsv.Enabled = true;
				lock(_runLock) {
					CoreWrapper.stopLogging();
				}
			} else {
				using(SaveFileDialog sfd = new SaveFileDialog()) {
					sfd.Filter = "Log file (*.txt)|*.txt";
					sfd.FileName = "tracelog.txt";
					if(sfd.ShowDialog() == DialogResult.OK) {
						lock(_runLock) {
							if(CoreWrapper.startLogging(sfd.FileName, chkLogHex.Checked, chkLogCsv.Checked)) {
								btnStartLogging.Text = "Stop Logging";
								_logging = true;
								chkLogHex.Enabled = false;
								chkLogCsv.Enabled = false;
							} else {
								MessageBox.Show("Couldn't open file");
							}
						}
					}
				}
			}
		}

		private void btnSelectColumns_Click(object sender, EventArgs e)
		{
			using(frmSelectColumns frm = new frmSelectColumns(_chipDef, _tracedColumns)) {
				if(frm.ShowDialog() == DialogResult.OK) {
					lock(_runLock) {
						_tracedColumns.Clear();
						_tracedColumns.AddRange(frmSelectColumns.SelectedColumns);
						CoreWrapper.setTrace(string.Join("|", _tracedColumns));
						_needColumnUpdate = true;
						Step(1);
					}
				}
			}
		}
		
		private void chkShowInHex_CheckedChanged(object sender, EventArgs e)
		{
			UpdateLogList();
		}

		private void btnResetPalette_Click(object sender, EventArgs e)
		{
			SetMemoryState(MemoryType.PaletteRam, new byte[0x20]);
		}

		private void btnImportPalette_Click(object sender, EventArgs e)
		{
			LoadFile("Palette ram (*.pr)|*.pr", (file) => {
				SetMemoryState(MemoryType.PaletteRam, File.ReadAllBytes(file));
			});
		}

		private void btnExportPalette_Click(object sender, EventArgs e)
		{
			SaveFile("Palette ram (*.pr)|*.pr", (file) => {
				lock(this._runLock) {
					UpdateRam();
					File.WriteAllBytes(file, CoreWrapper.getMemoryState(MemoryType.PaletteRam));
				}
			});
		}

		private void btnResetSprite_Click(object sender, EventArgs e)
		{
			SetMemoryState(MemoryType.SpriteRam, new byte[0x120]);
		}

		private void btnImportSprite_Click(object sender, EventArgs e)
		{
			LoadFile("Sprite ram (*.sr)|*.sr", (file) => {
				SetMemoryState(MemoryType.SpriteRam, File.ReadAllBytes(file));
			});
		}

		private void btnExportSprite_Click(object sender, EventArgs e)
		{
			SaveFile("Sprite ram (*.sr)|*.sr", (file) => {
				lock(_runLock) {
					UpdateRam();
					File.WriteAllBytes(file, CoreWrapper.getMemoryState(MemoryType.SpriteRam));
				}
			});
		}

		private void btnResetChrRam_Click(object sender, EventArgs e)
		{
			SetMemoryState(MemoryType.ChrRam, new byte[0x2000]);
		}

		private void btnImportChrRam_Click(object sender, EventArgs e)
		{
			LoadFile("CHR RAM (*.cr)|*.cr", (file) => {
				SetMemoryState(MemoryType.ChrRam, File.ReadAllBytes(file));
			});
		}

		private void btnExportChrRam_Click(object sender, EventArgs e)
		{
			SaveFile("CHR RAM (*.cr)|*.cr", (file) => {
				lock(_runLock) {
					UpdateRam();
					File.WriteAllBytes(file, CoreWrapper.getMemoryState(MemoryType.ChrRam));
				}
			});
		}

		private void btnResetNametableRam_Click(object sender, EventArgs e)
		{
			SetMemoryState(MemoryType.NametableRam, new byte[0x1000]);
		}

		private void btnImportNametableRam_Click(object sender, EventArgs e)
		{
			LoadFile("Nametable RAM (*.nr)|*.nr", (file) => {
				SetMemoryState(MemoryType.NametableRam, File.ReadAllBytes(file));
			});
		}

		private void btnExportNametableRam_Click(object sender, EventArgs e)
		{
			SaveFile("Nametable RAM (*.nr)|*.nr", (file) => {
				lock(_runLock) {
					UpdateRam();
					File.WriteAllBytes(file, CoreWrapper.getMemoryState(MemoryType.NametableRam));
				}
			});
		}

		private void btnResetCpuRam_Click(object sender, EventArgs e)
		{
			SetMemoryState(MemoryType.CpuRam, new byte[0x800]);
		}

		private void btnImportCpuRam_Click(object sender, EventArgs e)
		{
			LoadFile("CPU RAM (*.cr)|*.cr", (file) => {
				SetMemoryState(MemoryType.CpuRam, File.ReadAllBytes(file));
			});
		}

		private void btnExportCpuRam_Click(object sender, EventArgs e)
		{
			SaveFile("CPU RAM (*.cr)|*.cr", (file) => {
				lock(_runLock) {
					UpdateRam();
					File.WriteAllBytes(file, CoreWrapper.getMemoryState(MemoryType.CpuRam));
				}
			});
		}

		private void btnResetPrgRam_Click(object sender, EventArgs e)
		{
			CurrentRom = "";
			this.Text = _windowTitle;
			SetMemoryState(MemoryType.PrgRam, new byte[0x8000]);
		}

		private void btnImportPrgRam_Click(object sender, EventArgs e)
		{
			LoadFile("PRG RAM (*.pr)|*.pr", (file) => {
				SetMemoryState(MemoryType.PrgRam, File.ReadAllBytes(file));
			});
		}

		private void btnExportPrgRam_Click(object sender, EventArgs e)
		{
			SaveFile("PRG RAM (*.pr)|*.pr", (file) => {
				lock(_runLock) {
					UpdateRam();
					File.WriteAllBytes(file, CoreWrapper.getMemoryState(MemoryType.PrgRam));
				}
			});
		}

		private void SetMemoryState(MemoryType type, byte[] data)
		{
			lock(_runLock) {
				UpdateRam();
				CoreWrapper.setMemoryState(type, data);
				_chrRamData = CoreWrapper.getMemoryState(MemoryType.ChrRam);
				_paletteData = CoreWrapper.getMemoryState(MemoryType.PaletteRam);
				_spriteData = CoreWrapper.getMemoryState(MemoryType.SpriteRam);
				_cpuRamData = CoreWrapper.getMemoryState(MemoryType.CpuRam);
				_prgRamData = CoreWrapper.getMemoryState(MemoryType.PrgRam);
			}
			UpdateMemoryViews();
		}

		private void mnuShowLayer_CheckedChanged(object sender, EventArgs e)
		{
			this.ctrlChipDisplay.SetVisibleLayers(
				mnuShowDiffusion.Checked, mnuShowGroundedDiffusion.Checked, mnuShowPoweredDiffusion.Checked,
				mnuShowPolysilicon.Checked, mnuShowMetal.Checked, mnuShowProtection.Checked
			);
		}

		private void mnuShowSimulationState_CheckedChanged(object sender, EventArgs e)
		{
			ctrlChipDisplay.ShowState = mnuShowSimulationState.Checked;
		}

		private void mnuRefreshSlow_Click(object sender, EventArgs e)
		{
			mnuRefreshSlow.Checked = true;
			mnuRefreshNormal.Checked = mnuRefreshFast.Checked = false;
			_refreshSpeed = 8000;
		}

		private void mnuRefreshNormal_Click(object sender, EventArgs e)
		{
			mnuRefreshNormal.Checked = true;
			mnuRefreshSlow.Checked = mnuRefreshFast.Checked = false;
			_refreshSpeed = 4000;
		}

		private void mnuRefreshFast_Click(object sender, EventArgs e)
		{
			mnuRefreshFast.Checked = true;
			mnuRefreshSlow.Checked = mnuRefreshNormal.Checked = false;
			_refreshSpeed = 2000;
		}

		private void mnuRun_Click(object sender, EventArgs e)
		{
			if(_autoRun) {
				Stop();
			} else {
				mnuRun.Enabled = false;
				mnuPause.Enabled = true;
				_autoRun = true;
			}
		}

		private void mnuReset_Click(object sender, EventArgs e)
		{
			Reset(true);
		}

		private void mnuPowerCycle_Click(object sender, EventArgs e)
		{
			if(CurrentRom.Length > 0) {
				LoadRom(CurrentRom);
			} else {
				Reset(false);
			}
		}

		private void mnuStep_Click(object sender, EventArgs e)
		{
			Stop();
			Step(1);
		}

		private void mnuNextPixel_Click(object sender, EventArgs e)
		{
			Stop();
			Step(8);
		}

		private void mnuNextScanline_Click(object sender, EventArgs e)
		{
			Stop();
			Step(2728);
		}

		private void mnuNextFrame_Click(object sender, EventArgs e)
		{
			Stop();
			Step(714736);
		}

		private void mnuExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void mnuLoadRom_Click(object sender, EventArgs e)
		{
			using(OpenFileDialog ofd = new OpenFileDialog()) {
				ofd.Filter = "*.nes|*.nes";
				if(ofd.ShowDialog() == DialogResult.OK) {
					CurrentRom = ofd.FileName;
					LoadRom(CurrentRom);
				}
			}
		}

		void LoadRom(string filename)
		{
			byte[] rom = File.ReadAllBytes(filename);

			if((rom[6] & 0x08) == 0x08) {
				CoreWrapper.setMirroringType(MirroringType.FourScreens);
			} else {
				CoreWrapper.setMirroringType((rom[6] & 0x01) == 0x01 ? MirroringType.Vertical : MirroringType.Horizontal);
			}

			int prgRamSize = rom[4]*0x4000;
			int chrRamSize = rom[5]*0x2000;
			byte[] prgRam = new byte[prgRamSize];
			byte[] chrRam = new byte[chrRamSize];
			Array.Copy(rom, 16, prgRam, 0, prgRamSize);
			Array.Copy(rom, 16 + prgRamSize, chrRam, 0, chrRamSize);

			if(prgRamSize == 0x4000) {
				Array.Resize(ref prgRam, 0x8000);
				Array.Copy(prgRam, 0, prgRam, 0x4000, 0x4000);
			}

			lock(_runLock) {
				Stop();
				Reset(false);
				CoreWrapper.setMemoryState(MemoryType.ChrRam, chrRam);
				CoreWrapper.setMemoryState(MemoryType.PrgRam, prgRam);
			}
		}
		
		private void mnuSaveState_Click(object sender, EventArgs e)
		{
			SaveFile("Save states (*.ss)|*.ss", (file) => {
				lock(_runLock) {
					UpdateRam();
					File.WriteAllBytes(file, CoreWrapper.getMemoryState(MemoryType.FullState));
				}
			});
		}

		private void mnuLoadState_Click(object sender, EventArgs e)
		{
			LoadFile("Save states (*.ss)|*.ss", (file) => {
				lock(_runLock) {
					CoreWrapper.setMemoryState(MemoryType.FullState, File.ReadAllBytes(file));
					_chrRamChanged = false;
					_paletteRamChanged = false;
					_spriteRamChanged = false;
					_cpuRamChanged = false;
					_prgRamChanged = false;
					Step(1);
				}
			});
		}

		void SetMirroring(MirroringType mirroringType)
		{
			mnuMirrorHorizontal.Checked = mirroringType == MirroringType.Horizontal;
			mnuMirrorVertical.Checked = mirroringType == MirroringType.Vertical;
			mnuMirrorScreenA.Checked = mirroringType == MirroringType.ScreenAOnly;
			mnuMirrorScreenB.Checked = mirroringType == MirroringType.ScreenBOnly;
			mnuMirrorFourScreens.Checked = mirroringType == MirroringType.FourScreens;

			CoreWrapper.setMirroringType(mirroringType);
		}

		private void mnuMirrorVertical_Click(object sender, EventArgs e)
		{
			SetMirroring(MirroringType.Vertical);
		}

		private void mnuMirrorHorizontal_Click(object sender, EventArgs e)
		{
			SetMirroring(MirroringType.Horizontal);
		}

		private void mnuMirrorScreenA_Click(object sender, EventArgs e)
		{
			SetMirroring(MirroringType.ScreenAOnly);
		}

		private void mnuMirrorScreenB_Click(object sender, EventArgs e)
		{
			SetMirroring(MirroringType.ScreenBOnly);
		}

		private void mnuMirrorFourScreens_Click(object sender, EventArgs e)
		{
			SetMirroring(MirroringType.FourScreens);
		}

		private void mnuPause_Click(object sender, EventArgs e)
		{
			Stop();
		}

		private void hexViewer_SizeChanged(object sender, EventArgs e)
		{
			HexBox hexBox = (HexBox)sender;
			if(hexBox.Width > 870) {
				hexBox.BytesPerLine = 32;
			} else {
				hexBox.BytesPerLine = 16;
			}
		}

		private void mnuAbout_Click(object sender, EventArgs e)
		{
			using(frmAbout frm = new frmAbout()) {
				frm.ShowDialog();
			}
		}

		private void mnuVideoOutputViewer_Click(object sender, EventArgs e)
		{
			if(_videoViewer == null) {
				_videoViewer = new frmVideoViewer();
				_videoViewer.StartPosition = FormStartPosition.Manual;
				_videoViewer.Top = this.Top + this.Height / 2 - _videoViewer.Height / 2;
				_videoViewer.Left = this.Left + this.Width / 2 - _videoViewer.Width / 2;
				_videoViewer.Show(this);
				_videoViewer.FormClosed += (s, evt) => {
					_videoViewer = null;
				};
				_videoViewer.Focus();
			} else {
				_videoViewer.Focus();
			}
		}
	}
}
