using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void _btnLoading_Click(object sender, EventArgs e)
		{
			_pictureBox.ImageLocation = "http://s020.radikal.ru/i700/1604/75/2d14e743ea8a.jpg";
		}
	}
}
