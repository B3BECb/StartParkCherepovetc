using System;
using System.Drawing;
using System.Windows.Forms;

namespace TestUI
{
    public sealed partial class MainForm : Form
    {
        #region .ctor

        public MainForm()
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

        #region handlers

        private void OnLoginClick(object sender, EventArgs e)
        {
            using (var loginForm = new LoginForm())
            {
                switch(loginForm.ShowDialog(this))
                {
                    case DialogResult.OK:
                        {
                            break;
                        }
                    default:
                    case DialogResult.Cancel:
                        {
                            break;
                        }
                }
            }
        }

        #endregion
    }
}
