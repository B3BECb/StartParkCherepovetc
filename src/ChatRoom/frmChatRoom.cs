using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatRoom
{
	public partial class frmChatRoom : Form
	{
		public frmChatRoom()
		{
			InitializeComponent();
		}

		private void _footerSeparator_Paint(object sender, PaintEventArgs e)
		{

		}

		private void Form1_Enter(object sender, EventArgs e)
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
			if(this._txtMessageBox.TextLength > 10)
			{
				_txtMessageBox.ForeColor = Color.Red;
			}
			else
			{
				_txtMessageBox.ForeColor = DefaultForeColor;
			}
		}
	}
}
