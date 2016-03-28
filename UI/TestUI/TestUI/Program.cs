using System;
using System.Windows.Forms;

namespace TestUI
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			var c = new Class1();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
