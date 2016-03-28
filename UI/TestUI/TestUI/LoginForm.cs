using System;
using System.Drawing;
using System.Windows.Forms;

namespace TestUI
{
	public sealed partial class LoginForm : Form
	{
		#region Properties

		public string Username
		{
			get { return _txtUsername.Text; }
			private set
			{
				if(value == null)
				{
					throw new ArgumentNullException(value, nameof(value));
				}
				if(value != _txtUsername.Text)
				{
					_txtUsername.Text = value;
				}
			}
		}

		public string Password
		{
			get { return _txtPassword.Text; }
			private set
			{
				if(value == null)
				{
					throw new ArgumentNullException(value, nameof(value));
				}
				if(value != _txtPassword.Text)
				{
					_txtPassword.Text = value;
				}
			}
		}

		#endregion

		#region .ctor

		public LoginForm()
		{
			InitializeComponent();

			Font = SystemFonts.MessageBoxFont;
		}

		#endregion

		#region override

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			MinimumSize = Size;
		}

		#endregion
	}
}
