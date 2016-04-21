using System;

namespace AsyncMethods
{
	public sealed class TestProgressArgs : EventArgs
	{
		#region Properties

		public int Percent { get; }

		#endregion

		public TestProgressArgs(int percent)
		{
			Percent = percent;
		}
	}
}
