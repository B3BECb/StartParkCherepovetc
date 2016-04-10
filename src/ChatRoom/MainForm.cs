using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChatRoom
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void _footerSeparator_Paint(object sender, PaintEventArgs e)
		{

		}

		private void _btnDelete_Click(object sender, EventArgs e)
		{
			for(int i = _lstMessageList.SelectedItems.Count - 1; i >= 0; i--)
			{
				_lstMessageList.Items.Remove(_lstMessageList.SelectedItems[i]);
			}
		}

		private void _btnOK_Click(object sender, EventArgs e)
		{
			if(this._txtMessageBox.Text != string.Empty)
			{
				_lstMessageList.Items.Add(_txtMessageBox.Text);
				_txtMessageBox.Text = null;
			}
		}

		private void ChangeTextBox(object sender, EventArgs e)
		{
       
        }

        private void _txtMessageBox_TextChanged(object sender, EventArgs e)
        {
            if (_txtMessageBox.Text.Length >= 10)
            {
                _txtMessageBox.SelectionStart = _txtMessageBox.TextLength;
                _txtMessageBox.SelectionLength = 0;
                _txtMessageBox.SelectionColor = Color.Red;
            }
        }
    }
}
