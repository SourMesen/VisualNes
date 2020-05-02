using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace GUI
{
   public class AutoCompleteTextBox : TextBox
   {
      private ListBox _listBox;
      private bool _isAdded;
      private String _formerValue = String.Empty;
      
      public String[] Values { get; set; }

      public AutoCompleteTextBox()
      {
         InitializeComponent();
         ResetListBox();
      }

      private void InitializeComponent()
      {
         _listBox = new ListBox();
         this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.this_KeyDown);
         this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.this_KeyUp);
      }

      private void ShowListBox()
      {
         if(!_isAdded) {
            this.FindForm().Controls.Add(_listBox);
            _isAdded = true;
         }

         Point pos = this.FindForm().PointToClient(this.Parent.PointToScreen(this.Location));
         _listBox.Left = pos.X;
         _listBox.Top = pos.Y - _listBox.Height - 2;
         _listBox.Width = this.Width;
         _listBox.KeyDown += this_KeyDown;
         _listBox.DoubleClick += listBox_DoubleClick;
         _listBox.BringToFront();
         _listBox.Visible = true;
      }

      private void listBox_DoubleClick(object sender, EventArgs e)
      {
         if(_listBox.SelectedItem != null) {
            InsertWord((String)_listBox.SelectedItem);
            ResetListBox();
            _formerValue = this.Text;
         }
      }

      private void ResetListBox()
      {
         _listBox.Visible = false;
      }

      private void this_KeyUp(object sender, KeyEventArgs e)
      {
         UpdateListBox();
      }

      private void this_KeyDown(object sender, KeyEventArgs e)
      {
         switch(e.KeyCode) {
            case Keys.Enter:
            case Keys.Tab: {
               if(_listBox.Visible) {
                  InsertWord((String)_listBox.SelectedItem);
                  ResetListBox();
                  _formerValue = this.Text;
                  e.Handled = true;
                  e.SuppressKeyPress = true;
               }
               break;
            }
            case Keys.Down: {
               if(sender != _listBox && (_listBox.Visible) && (_listBox.SelectedIndex < _listBox.Items.Count - 1)) {
                  _listBox.SelectedIndex++;
               }
               break;
            }
            case Keys.Up: {
               if(sender != _listBox && (_listBox.Visible) && (_listBox.SelectedIndex > 0)) {
                  _listBox.SelectedIndex--;
               }
               break;
            }

            case Keys.PageDown: {
               if(sender != _listBox && _listBox.Visible) {
                  if(_listBox.SelectedIndex < _listBox.Items.Count - 10) {
                     _listBox.SelectedIndex += 10;
                  } else {
                     _listBox.SelectedIndex = _listBox.Items.Count - 1;
                  }
               }
               break;
            }
            case Keys.PageUp: {
               if(sender != _listBox && _listBox.Visible) {
                  if(_listBox.SelectedIndex >= 10) {
                     _listBox.SelectedIndex -= 10;
                  } else {
                     _listBox.SelectedIndex = 0;
                  }
               }
               break;
            }
         }
      }

      protected override bool IsInputKey(Keys keyData)
      {
         switch(keyData) {
            case Keys.Tab:
               return true;
            default:
               return base.IsInputKey(keyData);
         }
      }

      private void UpdateListBox()
      {
         if(this.Text != _formerValue) {
            _formerValue = this.Text;
            String word = GetWord();

            if(word.Length > 0) {
               String[] matches = Array.FindAll(this.Values, x => (x.Contains(word)));
               if(matches.Length > 0) {
                  _listBox.BeginUpdate();
                  _listBox.Items.Clear();
                  _listBox.Items.AddRange(matches);
                  _listBox.SelectedIndex = 0;
                  int height = 0;
                  using(Graphics graphics = _listBox.CreateGraphics()) {
                     for(int i = 0; i < _listBox.Items.Count; i++) {
                        height += _listBox.GetItemHeight(i);
                        if(height > 200) {
                           break;
                        }
                     }
                  }
                  _listBox.Height = Math.Min(height, 200);
                  _listBox.EndUpdate();
                  ShowListBox();
                  this.Focus();
               } else {
                  ResetListBox();
               }
            } else {
               ResetListBox();
            }
         }
      }

      private String GetWord()
      {
         String text = this.Text;
         int pos = this.SelectionStart;

         int posStart = text.LastIndexOf(',', (pos < 1) ? 0 : pos - 1);
         posStart = (posStart == -1) ? 0 : posStart + 1;
         int posEnd = text.IndexOf(',', pos);
         posEnd = (posEnd == -1) ? text.Length : posEnd;

         int length = ((posEnd - posStart) < 0) ? 0 : posEnd - posStart;

         return text.Substring(posStart, length);
      }

      private void InsertWord(String newTag)
      {
         String text = this.Text;
         int pos = this.SelectionStart;

         int posStart = text.LastIndexOf(',', (pos < 1) ? 0 : pos - 1);
         posStart = (posStart == -1) ? 0 : posStart + 1;
         int posEnd = text.IndexOf(',', pos);

         String firstPart = text.Substring(0, posStart) + newTag;
         String updatedText = firstPart + ((posEnd == -1) ? "" : text.Substring(posEnd, text.Length - posEnd));


         this.Text = updatedText;
         this.SelectionStart = firstPart.Length;
      }

      public List<String> SelectedValues
      {
         get
         {
            String[] result = Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            return new List<String>(result);
         }
      }
   }
}
