using System;

namespace Notepad
{
	public class ProgressArgs
	{
		public ProgressArgs(int percent)
		{
			Percent = percent;
		}

		public int Percent { get; }
	}
}
