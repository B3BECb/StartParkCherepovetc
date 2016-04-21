using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncMethods
{
	public partial class Form1 : Form
	{
		#region Properties

		private Progress<TestProgressArgs> Progress { get; }

		private Timer Timer { get; }

		#endregion

		#region .ctor

		public Form1()
		{
			InitializeComponent();

			Progress = new Progress<TestProgressArgs>();
			Timer = new Timer()
			{
				Interval = 1000,
			};
			Timer.Tick += OnTick;

			Progress.ProgressChanged += OnProgressChanged;
		}

		private void OnTick(object sender, EventArgs e)
		{
			label1.Text = DateTime.Now.ToString("HH:mm:ss");
		}

		#endregion

		#region override

		protected async override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			MinimumSize = Size;

			Timer.Start();

			await TestMethods.TestProgressAsync(Progress);
		}

		protected override void Dispose(bool disposing)
		{
			if(disposing)
			{
				Timer.Stop();
				Timer.Tick -= OnTick;
				Progress.ProgressChanged -= OnProgressChanged;
				Timer.Dispose();
				components?.Dispose();
			}
			base.Dispose(disposing);
		}

		#endregion

		#region Handlers

		private void OnProgressChanged(object sender, TestProgressArgs e)
		{
			progressBar1.Value = e.Percent;
		}

		#endregion
	}
}
