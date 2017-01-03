using System.Windows.Forms;

namespace GUI
{
	public class DoubleBufferedListView : ListView
	{
		public DoubleBufferedListView()
		{
			this.DoubleBuffered = true;
		}
	}
}
