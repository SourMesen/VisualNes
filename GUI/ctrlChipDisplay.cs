using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GUI
{
	public partial class ctrlChipDisplay : UserControl
	{
		const int _canvasSize = 5000;
		const int _chipSize = 10000;

		bool[] _visibleLayers = new bool[] { true, true, true, true, true, true };
		Color[] _layerColors = new Color[] {
			Color.FromArgb(100, 128, 128, 192), Color.FromArgb(255, 255, 0), Color.FromArgb(255, 0, 255), Color.FromArgb(0x4D, 255, 0x4D),
			Color.FromArgb(255, 0x4D, 0x4D), Color.FromArgb(0x80, 0x1A, 0xC0), Color.FromArgb(191, 128, 0, 255)
		};

		Bitmap _imgBackground;
		Bitmap _imgHitBuffer;
		Bitmap _imgHighlight;
		Bitmap _imgHighNodes;
		int _chipScale = 1;
		int _translateX = 0;
		int _translateY = 0;
		bool _viewPortChanged = true;
		bool _needRefresh = true;
		bool _isDragging = false;
		Point _previousLocation;
		bool _showState = false;
		ChipDefinitions _chipDef;

		public ctrlChipDisplay()
		{
			InitializeComponent();

			bool designMode = (LicenseManager.UsageMode == LicenseUsageMode.Designtime);
			if(!designMode) {
				_chipDef = new ChipDefinitions();
				RenderChip();
				tmrDrawChip.Enabled = true;
				this.MouseWheel += picChip_MouseWheel;
			}
		}

		bool _refreshingState = false;

		public bool ShowState { get { return _showState; } set { _showState = value; _needRefresh = true; } }
		public void RefreshState(bool async = false)
		{
			if(!_refreshingState && _showState) {
				Action updateState = () => {
					_refreshingState = true;
					lock(_imgHighNodes) {
						using(Graphics g = Graphics.FromImage(_imgHighNodes)) {
							g.Clear(Color.Transparent);
							using(Brush brush = new SolidBrush(Color.FromArgb(100, 255, 0, 64))) {
								foreach(node node in _chipDef.Nodes) {
									if(node != null) {
										if(node.num != 1 && CoreWrapper.isNodeHigh(node.num)) {
											foreach(List<int> segments in node.segs) {
												DrawSegment(g, brush, segments, false);
											}
										}
									}
								}
							}
						}
					}
					_needRefresh = true;
					_refreshingState = false;
				};

				if(async) {
					Task.Run(updateState);
				} else {
					updateState();
				}
			}
		}
		
		public void SetVisibleLayers(bool showDiffusion, bool showGroundedDiffusion, bool showPoweredDiffusion, bool showPolysilicon, bool showMetal, bool showProtection)
		{
			_visibleLayers = new bool[] { showDiffusion, showGroundedDiffusion, showPoweredDiffusion, showPolysilicon, showMetal, showProtection };
			_viewPortChanged = true;
			RenderChip();
		}

		public void RenderChip()
		{
			_imgBackground = new Bitmap(_canvasSize, _canvasSize);
			_imgHitBuffer = new Bitmap(_canvasSize, _canvasSize);
			_imgHighlight = new Bitmap(_canvasSize, _canvasSize);
			_imgHighNodes = new Bitmap(_canvasSize, _canvasSize);

			using(Graphics g = Graphics.FromImage(_imgBackground)) {
				DrawBackground(g);
			}
			using(Graphics g = Graphics.FromImage(_imgHitBuffer)) {
				DrawHitBuffer(g);
			}
			using(Graphics g = Graphics.FromImage(_imgHighlight)) {
				g.Clear(Color.Transparent);
			}
			using(Graphics g = Graphics.FromImage(_imgHighNodes)) {
				g.Clear(Color.Transparent);
			}

			RefreshPicture();
		}

		private int ScaleDistance(int x)
		{
			return (int)Math.Round((double)(x*_canvasSize/_chipSize));
		}
		
		private void DrawBackground(Graphics g)
		{
			g.FillRectangle(Brushes.Black, 0, 0, _canvasSize, _canvasSize);

			foreach(List<int> segmentDef in _chipDef.SegmentDefs) {
				int layer = segmentDef[2];
				if(_visibleLayers[layer]) {
					using(Brush brush = new SolidBrush(_layerColors[layer])) {
						DrawSegment(g, brush, segmentDef.GetRange(3, segmentDef.Count - 3), layer==0 || layer==6);
					}
				}
			}
		}

		private void DrawHitBuffer(Graphics g)
		{
			g.FillRectangle(Brushes.Black, 0, 0, _canvasSize, _canvasSize);

			foreach(List<int> segmentDef in _chipDef.SegmentDefs) {
				int segmentID = segmentDef[0];
				int layer = segmentDef[2];

				using(Brush brush = new SolidBrush(Color.FromArgb((int)(0xFF000000|segmentID)))) {
					DrawSegment(g, brush, segmentDef.GetRange(3, segmentDef.Count - 3), false);
				}
			}
		}

		private void DrawSegment(Graphics g, Brush brush, List<int> segment, bool drawBorder)
		{
			int dx = 0;//200;
			int dy = 0;//-300;
			GraphicsPath path = new GraphicsPath();
			Point[] points = new Point[segment.Count / 2 + 1];
			points[0] = new Point(ScaleDistance(segment[0]+dx), ScaleDistance(_chipSize-segment[1]+dy));
			for(var i = 2; i<segment.Count; i+=2) {
				points[i/2] = new Point(ScaleDistance(segment[i]+dx), ScaleDistance(_chipSize-segment[i+1]+dy));
			}
			points[segment.Count / 2] = new Point(ScaleDistance(segment[0]+dx), ScaleDistance(_chipSize-segment[1]+dy));

			path.AddLines(points);
			g.FillPath(brush, path);
			if(drawBorder) {
				g.DrawPath(Pens.Gray, path);
			}
		}

		Bitmap _imgViewport;
		private void UpdateViewportImage()
		{
			if(_viewPortChanged && _imgBackground != null) {
				if(_imgViewport == null || _imgViewport.Width != picChip.Width || _imgViewport.Height != picChip.Height) {
					_imgViewport = new Bitmap(picChip.Width, picChip.Height);
					picChip.Image = new Bitmap(picChip.Width, picChip.Height);
				}

				int dimension = Math.Min(picChip.Width, picChip.Height);
				_translateX = Math.Min(Math.Max(_translateX, -dimension / 2), dimension * _chipScale - dimension / 2);
				_translateY = Math.Min(Math.Max(_translateY, -dimension / 2), dimension * _chipScale - dimension / 2);

				using(Graphics g = Graphics.FromImage(_imgViewport)) {
					g.InterpolationMode = InterpolationMode.NearestNeighbor;
					g.PixelOffsetMode = PixelOffsetMode.Half;
					g.SmoothingMode = SmoothingMode.None;
					g.Clear(Color.Black);

					int size = dimension*_chipScale;
					int xPos = -_translateX + (picChip.Width - dimension) / 2;
					int yPos = -_translateY + (picChip.Height - dimension) / 2;

					g.DrawImage(_imgBackground, xPos, yPos, size, size);					
					g.DrawImage(_imgHighlight, xPos, yPos, size, size);

					g.DrawLine(Pens.White, 0, picChip.Height - 1, picChip.Width - 1, picChip.Height - 1);
				}

				_viewPortChanged = false;
				_needRefresh = true;
			}
		}

		private void RefreshPicture()
		{
			UpdateViewportImage();

			if(_needRefresh) {
				using(Graphics g = Graphics.FromImage(picChip.Image)) {
					g.DrawImage(_imgViewport, 0, 0);

					if(ShowState) {
						g.InterpolationMode = InterpolationMode.NearestNeighbor;
						g.PixelOffsetMode = PixelOffsetMode.Half;
						g.SmoothingMode = SmoothingMode.None;

						int dimension = Math.Min(picChip.Width, picChip.Height);
						int size = dimension*_chipScale;
						int xPos = -_translateX + (picChip.Width - dimension) / 2;
						int yPos = -_translateY + (picChip.Height - dimension) / 2;

						lock(_imgHighNodes) {
							g.DrawImage(_imgHighNodes, xPos, yPos, size, size);
						}
					}
				}
				picChip.Invalidate();
				_needRefresh = false;
			}
		}

		private void ZoomOut()
		{
			if(_chipScale > 1) {
				int dimension = Math.Min(picChip.Width, picChip.Height);
				_translateX = _translateX / 2 - dimension / 4;
				_translateY = _translateY / 2 - dimension / 4;
				_chipScale /= 2;
				_viewPortChanged = true;
			}
		}

		private void ZoomIn(Point location)
		{
			if(_chipScale < 32) {
				int dimension = Math.Min(picChip.Width, picChip.Height);
				int x = location.X - (picChip.Width - dimension) / 2;
				_translateX = (_translateX + (x - dimension / 4)) * 2;
				_translateY = (_translateY + (location.Y - dimension / 4)) * 2;
				_chipScale *= 2;
				_viewPortChanged = true;
			}
		}

		List<int> _highlightedNodes = new List<int>();
		private void HighlightNode(List<int> nodeNumbers)
		{
			using(Graphics g = Graphics.FromImage(_imgHighlight)) {
				g.Clear(Color.Transparent);

				_highlightedNodes = nodeNumbers;

				foreach(int nn in nodeNumbers) {
					if(nn < 0) {
						//Draw transistor
						using(Brush brush = new SolidBrush(Color.FromArgb(180, 255, 255, 255))) {
							List<int> bb = _chipDef.Transistors[-nn + 1].bb;
							DrawSegment(g, brush, new List<int> { bb[0], bb[2], bb[1], bb[2], bb[1], bb[3], bb[0], bb[3] }, false);
						}
					} else if(_chipDef.Nodes[nn].segs.Count > 0) {
						//Draw node
						Color color = CoreWrapper.isNodeHigh(nn) ? Color.FromArgb(180, 255, 0, 0) : Color.FromArgb(180, 255, 255, 255);
						using(Brush brush = new SolidBrush(color)) {
							foreach(List<int> segments in _chipDef.Nodes[nn].segs) {
								DrawSegment(g, brush, segments, false);
							}
						}
					}
				}
			}
			_viewPortChanged = true;
		}
		
		private void FindNodeAtLocation(Point location, bool highlightGroup)
		{
			int dimension = Math.Min(picChip.Width, picChip.Height);
			int x = (location.X + _translateX - (picChip.Width - dimension) / 2);
			int y = (location.Y + _translateY - (picChip.Height - dimension) / 2);

			int xChip = x * _canvasSize / (dimension * _chipScale);
			int yChip = y * _canvasSize / (dimension * _chipScale);

			if(xChip >= 0 && xChip < _canvasSize && yChip >= 0 && yChip < _canvasSize) {
				List<node> nodes = _chipDef.Nodes;

				int w = _imgHitBuffer.GetPixel(xChip, yChip).ToArgb() & 0xFFFFFF;
				if(w <= 0 || w >= nodes.Count)
					return;

				// we have a node, but maybe we clicked over a transistor
				List<int> nodelist = new List<int>() { w };
				// match the coordinate against transistor gate bounding boxes
				x = xChip*_chipSize/_canvasSize;
				y = _chipSize - yChip*_chipSize/_canvasSize;
				string s1 = "x: " + x + " y: " + y;
				string s2 = "node: " + w + " " + _chipDef.getNodeName(w);

				for(var i = 0; i<nodes[w].gates.Count; i++) {
					int xmin = nodes[w].gates[i].bb[0];
					int xmax = nodes[w].gates[i].bb[1];
					int ymin = nodes[w].gates[i].bb[2];
					int ymax = nodes[w].gates[i].bb[3];

					if((x >= xmin) && (x <= xmax) && (y >= ymin) && (y <= ymax)) {
						// only one match at most, so we replace rather than push

						nodelist = new List<int> { -_chipDef.getTransistorIndex(nodes[w].gates[i].name) - 1 };
						s2="transistor: " + nodes[w].gates[i].name + " on " + s2;
					}
				}

				// if this is a shift-click, just find and highlight the pass-connected group
				// and list the nodes (or nodenames, preferably)
				if(highlightGroup) {
					nodelist = new List<int>(_chipDef.getNodeGroup(w));
					s2 = "nodegroup from " + s2 + " (nodes: " +
							string.Join(",", nodelist.Select((nn) => { return _chipDef.getNodeName(nn).Length > 0 ? _chipDef.getNodeName(nn) : nn.ToString(); })) + ")";
				}
				HighlightNode(nodelist);
				lblNodeInfo.Text = s1 + Environment.NewLine + s2;
			}
		}

		#region Events
		private void picChip_SizeChanged(object sender, EventArgs e)
		{
			_viewPortChanged = true;
			RefreshPicture();
		}

		private void picChip_MouseClick(object sender, MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Right) {
				ZoomOut();
			} 
		}

		private void picChip_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Left) {
				ZoomIn(e.Location);
			}
		}

		private void picChip_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(e.Delta < 0) {
				ZoomOut();
			} else if(e.Delta > 0) {
				ZoomIn(e.Location);
			}
		}

		bool _dragged = false;
		private void picChip_MouseDown(object sender, MouseEventArgs e)
		{
			_isDragging = true;
			_dragged = false;
			_previousLocation = e.Location;
		}

		private void picChip_MouseUp(object sender, MouseEventArgs e)
		{
			_isDragging = false;
			if(!_dragged && e.Clicks == 1) {
				FindNodeAtLocation(e.Location, ModifierKeys.HasFlag(Keys.Shift));
			}
		}

		private void picChip_MouseMove(object sender, MouseEventArgs e)
		{
			this.Focus();
			if(ModifierKeys.HasFlag(Keys.Alt)) {
				FindNodeAtLocation(e.Location, ModifierKeys.HasFlag(Keys.Shift));
			}
			if(_isDragging) {
				int dx = e.Location.X - _previousLocation.X;
				int dy = e.Location.Y - _previousLocation.Y;
				if(Math.Abs(dx) > 2 || Math.Abs(dy) > 2) {
					_dragged = true;
				}
				_translateX -= dx;
				_translateY -= dy;
				_previousLocation = e.Location;
				_viewPortChanged = true;
			}
		}

		private void tmrDrawChip_Tick(object sender, EventArgs e)
		{
			RefreshPicture();
		}
		#endregion
	}
}
