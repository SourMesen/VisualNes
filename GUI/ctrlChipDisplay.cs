using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
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

		List<List<int>> _segmentDefs = new List<List<int>>();

		Bitmap _imgBackground;
		int _chipScale = 1;
		int _translateX = 0;
		int _translateY = 0;
		bool _needRedraw = true;
		bool _isDragging = false;
		Point _previousLocation;

		public ctrlChipDisplay()
		{
			InitializeComponent();
		}

		public void InitDisplay()
		{
			foreach(string line in File.ReadAllLines("segdefs.txt")) {
				List<int> segmentDef = new List<int>();
				foreach(string value in line.Split(',')) {
					segmentDef.Add(int.Parse(value));
				}
				_segmentDefs.Add(segmentDef);
			}

			RenderChip();
		}

		private void RenderChip()
		{
			_imgBackground = new Bitmap(_canvasSize, _canvasSize);
			using(Graphics g = Graphics.FromImage(_imgBackground)) {
				DrawBackground(g);
			}

			DrawChip();
		}

		private int ScaleDistance(int x)
		{
			return (int)Math.Round((double)(x*_canvasSize/_chipSize));
		}
		
		private void DrawBackground(Graphics g)
		{
			g.FillRectangle(Brushes.Black, 0, 0, _canvasSize, _canvasSize);

			foreach(List<int> segment in _segmentDefs) {
				int layer = segment[2];
				if(_visibleLayers[layer]) {
					using(Brush brush = new SolidBrush(_layerColors[layer])) {
						DrawSegment(g, brush, segment.GetRange(3, segment.Count - 3), layer==0 || layer==6);
					}
				}
			}
		}

		private void DrawSegment(Graphics g, Brush brush, List<int> segment, bool drawBorder)
		{
			int dx = 200;
			int dy = -300;
			GraphicsPath path = new GraphicsPath(FillMode.Alternate);
			List<Point> points = new List<Point>(segment.Count / 2 + 2);
			points.Add(new Point(ScaleDistance(segment[0]+dx), ScaleDistance(_chipSize-segment[1]+dy)));
			for(var i = 2; i<segment.Count; i+=2) {
				points.Add(new Point(ScaleDistance(segment[i]+dx), ScaleDistance(_chipSize-segment[i+1]+dy)));
			}
			points.Add(new Point(ScaleDistance(segment[0]+dx), ScaleDistance(_chipSize-segment[1]+dy)));

			path.AddLines(points.ToArray());
			g.FillPath(brush, path);
			if(drawBorder) {
				g.DrawPath(Pens.Gray, path);
			}
		}

		private void DrawChip()
		{
			if(_needRedraw && _imgBackground != null) {
				if(picChip.Image == null || picChip.Image.Width != picChip.Width || picChip.Image.Height != picChip.Height) {
					Bitmap image = new Bitmap(picChip.Width, picChip.Height);
					picChip.Image = image;
				}

				int dimension = Math.Min(picChip.Width, picChip.Height);
				_translateX = Math.Min(Math.Max(_translateX, -dimension / 2), dimension * _chipScale - dimension / 2);
				_translateY = Math.Min(Math.Max(_translateY, -dimension / 2), dimension * _chipScale - dimension / 2);

				using(Graphics g = Graphics.FromImage(picChip.Image)) {
					g.InterpolationMode = InterpolationMode.NearestNeighbor;
					g.PixelOffsetMode = PixelOffsetMode.Half;
					g.SmoothingMode = SmoothingMode.None;
					g.FillRectangle(Brushes.Black, 0, 0, picChip.Width, picChip.Height);
					g.DrawImage(_imgBackground, -_translateX + (picChip.Width - dimension) / 2, -_translateY + (picChip.Height - dimension) / 2, dimension*_chipScale, dimension*_chipScale);
				}
				picChip.Invalidate();
				_needRedraw = false;
			}
		}

		private void picChip_SizeChanged(object sender, EventArgs e)
		{
			_needRedraw = true;
			DrawChip();
		}

		private void picChip_MouseClick(object sender, MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Right && _chipScale > 1) {
				_translateX /= 2;
				_translateY /= 2;
				_chipScale /= 2;
				_needRedraw = true;
			}
		}

		private void picChip_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Left && _chipScale < 32) {
				_translateX = ((e.Location.X - picChip.Image.Width / 2) + _translateX) * 2;
				_translateY = ((e.Location.Y - picChip.Image.Height / 2) + _translateY) * 2;
				_chipScale *= 2;
				_needRedraw = true;
			}
		}

		private void picChip_MouseDown(object sender, MouseEventArgs e)
		{
			_isDragging = true;
			_previousLocation = e.Location;
		}

		private void picChip_MouseUp(object sender, MouseEventArgs e)
		{
			_isDragging = false;
		}

		private void picChip_MouseMove(object sender, MouseEventArgs e)
		{
			if(_isDragging) {
				_translateX -= (e.Location.X - _previousLocation.X);
				_translateY -= (e.Location.Y - _previousLocation.Y);
				_previousLocation = e.Location;
				_needRedraw = true;
			}
		}

		private void tmrDrawChip_Tick(object sender, EventArgs e)
		{
			DrawChip();
		}

		public void SetVisibleLayers(bool showDiffusion, bool showGroundedDiffusion, bool showPoweredDiffusion, bool showPolysilicon, bool showMetal, bool showProtection)
		{
			_visibleLayers = new bool[] { showDiffusion, showGroundedDiffusion, showPoweredDiffusion, showPolysilicon, showMetal, showProtection };
			_needRedraw = true;
			RenderChip();
		}
	}
}
