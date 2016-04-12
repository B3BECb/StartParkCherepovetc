using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _120416Threads
{
	public partial class ThreadTestForm : Form
	{
		private CancellationTokenSource _cts;

		private Thread _progressThread;

		public ThreadTestForm()
		{
			InitializeComponent();
		}

		private void _btnStart_Click(object sender, EventArgs e)
		{
			if(_cts == null || _cts.IsCancellationRequested)
			{
				_cts?.Dispose();
				_cts = new CancellationTokenSource();
			}

			if(_progressThread == null || !_progressThread.IsAlive)
			{
				_progressBar.Value = 0;
				_progressThread = new Thread(ChangeProgressBar)
				{
					IsBackground = true,
					Name = "ProgressBarUpdater"
				};
				_progressThread.Start();
			}
		}

		private void ChangeProgressBar()
		{
			for(int i = 0; i < 100 && !_cts.IsCancellationRequested; i++)
			{
				var mi = new MethodInvoker(() =>
				{
					_progressBar.Value++;
				});

				if(this.InvokeRequired)
				{
					this.Invoke(mi);
				}
				else
				{
					mi();
				}

				Thread.Sleep(100);
			}
		}

		private void _btnStop_Click(object sender, EventArgs e)
		{
			_cts.Cancel();
		}
	}
}
