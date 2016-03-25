using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestUI
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			Font = SystemFonts.MessageBoxFont;

			var request = WebRequest.Create("");
			request.Credentials = new NetworkCredential("login", "password");

			using(var response = request.GetResponse())
			{

			}
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("OK", "Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);


		}

		private void button2_Click(object sender, EventArgs e)
		{
			//using(
			var form = new MainForm();
			form.TopMost = false;
				//)
			//{
				form.Show(this);
				//form.ShowDialog(this);
			//}
		}
	}
}
