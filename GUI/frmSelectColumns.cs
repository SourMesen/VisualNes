using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
	public partial class frmSelectColumns : Form
	{
		private static List<SelectTreeNode> _nodeNames;
		private static HashSet<string> _selectedColumns;
		
		static frmSelectColumns()
		{
			HashSet<string> existingColumns = new HashSet<string>();
			_nodeNames = new List<SelectTreeNode>();
			string[] lines = File.ReadAllLines("nodenames.txt");
			foreach(string line in lines) {
				string nodename = line.Split(',')[0];
				_nodeNames.Add(new SelectTreeNode(nodename));
				existingColumns.Add(nodename);
				string withoutNumber = Regex.Replace(nodename, "[_0-9]+$", "");
				if(withoutNumber != nodename && !existingColumns.Contains(withoutNumber)) {
					_nodeNames.Add(new SelectTreeNode(withoutNumber));
					existingColumns.Add(withoutNumber);
				}
			}
			_nodeNames.Add(new SelectTreeNode("cycle"));
		}

		public frmSelectColumns(List<string> originalColumns)
		{
			InitializeComponent();
			_selectedColumns = new HashSet<string>(originalColumns);
			RefreshList();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			txtSearchString.Focus();
		}

		public static HashSet<string> SelectedColumns { get { return _selectedColumns; } }

		private void RefreshList()
		{
			List<SelectTreeNode> nodes = new List<SelectTreeNode>();
			foreach(SelectTreeNode node in _nodeNames) {
				if(string.IsNullOrWhiteSpace(txtSearchString.Text) || Regex.Match(node.Name, txtSearchString.Text).Success) {
					nodes.Add(node);
				}
			}
			nodes.Sort();

			lstSelectedColumns.BeginUpdate();
			lstSelectedColumns.Items.Clear();
			foreach(SelectTreeNode node in nodes) {
				lstSelectedColumns.Items.Add(node, _selectedColumns.Contains(node.Name));
			}
			lstSelectedColumns.EndUpdate();
		}

		private void lstSelectedColumns_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			SelectTreeNode node = (SelectTreeNode)lstSelectedColumns.Items[e.Index];
			if(e.NewValue == CheckState.Checked) {
				_selectedColumns.Add(node.Name);
			} else {
				_selectedColumns.Remove(node.Name);
			}
		}

		private void txtSearchString_TextChanged(object sender, EventArgs e)
		{
			try {
				Regex.Match("", txtSearchString.Text);
				RefreshList();
			} catch { }
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			_selectedColumns = new HashSet<string>();
			RefreshList();
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			_selectedColumns = new HashSet<string>() { "cycle", "hpos", "vpos", "vbl_flag", "spr0_hit", "spr_overflow", "vramaddr_t", "vramaddr_v", "io_db", "io_ab", "io_rw", "io_ce", "rd", "wr", "ab", "ale", "db" };
			RefreshList();
		}
	}

	public class SelectTreeNode : IComparable
	{
		private string _name;
		private string _sortName;

		public SelectTreeNode(string name)
		{
			_name = name;
			_sortName = name.Replace("+", "").Replace("_", "").Replace("\\", "").Replace("/", "").Replace("(", "").Replace(")", "");
		}

		public string Name { get { return _name; } }

		public override string ToString()
		{
			return _name;
		}

		int IComparable.CompareTo(object obj)
		{
			SelectTreeNode b = (SelectTreeNode)obj;
			bool aSelected = frmSelectColumns.SelectedColumns.Contains(this.Name);
			bool bSelected = frmSelectColumns.SelectedColumns.Contains(b.Name);
			if(aSelected && !bSelected) {
				return -1;
			} else if(!aSelected && bSelected) {
				return 1;
			} else {
				return this._sortName.CompareTo(b._sortName);
			}
		}
	}
}
