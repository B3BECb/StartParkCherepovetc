using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project
{
	public class Progress : INotifyPropertyChanged
	{
		#region Members
		private int _value;
		#endregion

		#region Properties
		public int Value
		{
			get { return _value; }
			set
			{
				_value = value;
				InvokePropertyChanged(new PropertyChangedEventArgs("Value"));
			}
		}
		#endregion
		
		#region Constructor
		public Progress()
		{
			Value = 0;
		}
		#endregion

		#region Events

		public event PropertyChangedEventHandler PropertyChanged;

		public void InvokePropertyChanged(PropertyChangedEventArgs e)
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null) handler(this, e);
		}

		#endregion
	}
}
