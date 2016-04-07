using System;
using System.Drawing;
using System.Net;
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
			//_pictureBox.ImageLocation = "http://s020.radikal.ru/i700/1604/75/2d14e743ea8a.jpg";

			const string Uri = "http://www.hdwallpaperup.com/wp-content/uploads/2015/05/Baloons-With-Hot-Air-Wallpaper-2560x1024.jpg";

			var requset = CreateRequest(Uri);

			using (var respone = requset.GetResponse())
			{
				using (var stream = respone.GetResponseStream())
				{
					//byte[] b = new byte[stream.Length];
					//stream.Read(b, 0, (int)stream.Length);

					
					_pictureBox.Image = new Bitmap(stream);
				}
			}
		}

		private WebRequest CreateRequest(string uri) => WebRequest.Create(uri);
	}
}
