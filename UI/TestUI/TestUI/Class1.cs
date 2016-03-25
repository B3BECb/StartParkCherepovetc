using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUI
{
	public sealed class TestEventArgs : EventArgs
	{
		public int NewPort { get; set; }
	}

	class Class1
	{
		#region Events

		public event EventHandler<TestEventArgs> PortChanged;

		private void OnPortChanged(TestEventArgs e)
		{
			if(e == null)
			{
				throw new ArgumentNullException(nameof(e));
			}
			PortChanged?.Invoke(this, e);
		}

		#endregion

		#region Data

		private int _port;

		#endregion

		#region Properties

		public int Port
		{
			get { return _port; }
			private set
			{
				if(value < 0 || value > 64364)
				{
					throw new ArgumentException("Invalide port");
				}
				_port = value;
				OnPortChanged(new TestEventArgs() { NewPort = value });
			}
		}

		public int X { get; }

		#endregion

		#region .ctor

		public Class1()
		{
			X = new int();
		}

		#endregion
	}
}
