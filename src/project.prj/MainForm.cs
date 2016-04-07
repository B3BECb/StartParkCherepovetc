using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Project
{
	public partial class MainForm : Form
	{
		#region Members
		Progress _progress;
		Thread _thread;
		#endregion

		public MainForm()
		{
			InitializeComponent();
			_progress = new Progress();

			// Привязка данных
			_prgBar.DataBindings.Add("Value", _progress, "Value");

			// Назначение событий
			_btnReset.Click += ResetCurrentValue;
			_btnAction.Click += DoAction;
		}

		private void DoAction(object sender, EventArgs e)
		{
			if (_thread == null)
			{
				_thread = new Thread(() =>
				{
					for (; _progress.Value < 100;)
					{
						if (!_thread.IsAlive)
						{
							break;
						}

						this.Invoke((MethodInvoker)delegate
						{
							checked
							{
								_progress.Value++;
							}
						});

						if (_progress.Value == 100)
						{
							_thread.Abort();
							_thread = null;
							break;
						}

						Thread.Sleep(500);
					}
				});
				_thread.Start();

				_btnAction.Text = "Пауза";
			}
			else
			{
				if (_thread.IsAlive)
				{
					_thread.Abort();
					_thread = null;
				}

				_btnAction.Text = "Запуск";
			}
		}

		private void ResetCurrentValue(object sender, EventArgs e)
		{
			_progress.Value = 0;
		}

		private void ExitApplication(object sender, FormClosedEventArgs e)
		{
			if ((_thread != null) && _thread.IsAlive)
			{
				_thread.Abort();
			}
		}
	}
}
