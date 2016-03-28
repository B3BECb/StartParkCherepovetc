namespace TestUI
{
	partial class LoginForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this._txtUsername = new System.Windows.Forms.TextBox();
			this._txtPassword = new System.Windows.Forms.TextBox();
			this._lblPassword = new System.Windows.Forms.Label();
			this._lblUsername = new System.Windows.Forms.Label();
			this._footer = new System.Windows.Forms.Panel();
			this._footerSeparator = new System.Windows.Forms.Panel();
			this._btnCancel = new System.Windows.Forms.Button();
			this._btnOK = new System.Windows.Forms.Button();
			this._toolTip = new System.Windows.Forms.ToolTip(this.components);
			this._body = new System.Windows.Forms.Panel();
			this._footer.SuspendLayout();
			this._body.SuspendLayout();
			this.SuspendLayout();
			// 
			// _txtUsername
			// 
			this._txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._txtUsername.Location = new System.Drawing.Point(91, 6);
			this._txtUsername.Name = "_txtUsername";
			this._txtUsername.Size = new System.Drawing.Size(213, 20);
			this._txtUsername.TabIndex = 1;
			this._toolTip.SetToolTip(this._txtUsername, "User name input box");
			// 
			// _txtPassword
			// 
			this._txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._txtPassword.Location = new System.Drawing.Point(91, 35);
			this._txtPassword.Name = "_txtPassword";
			this._txtPassword.Size = new System.Drawing.Size(213, 20);
			this._txtPassword.TabIndex = 3;
			this._toolTip.SetToolTip(this._txtPassword, "Password input box");
			this._txtPassword.UseSystemPasswordChar = true;
			// 
			// _lblPassword
			// 
			this._lblPassword.AutoSize = true;
			this._lblPassword.Location = new System.Drawing.Point(12, 38);
			this._lblPassword.Name = "_lblPassword";
			this._lblPassword.Size = new System.Drawing.Size(56, 13);
			this._lblPassword.TabIndex = 2;
			this._lblPassword.Text = "Password:";
			// 
			// _lblUsername
			// 
			this._lblUsername.AutoSize = true;
			this._lblUsername.Location = new System.Drawing.Point(12, 9);
			this._lblUsername.Name = "_lblUsername";
			this._lblUsername.Size = new System.Drawing.Size(61, 13);
			this._lblUsername.TabIndex = 0;
			this._lblUsername.Text = "User name:";
			// 
			// _footer
			// 
			this._footer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._footer.BackColor = System.Drawing.SystemColors.Control;
			this._footer.Controls.Add(this._footerSeparator);
			this._footer.Controls.Add(this._btnCancel);
			this._footer.Controls.Add(this._btnOK);
			this._footer.Location = new System.Drawing.Point(0, 66);
			this._footer.Margin = new System.Windows.Forms.Padding(0);
			this._footer.Name = "_footer";
			this._footer.Size = new System.Drawing.Size(312, 39);
			this._footer.TabIndex = 1;
			// 
			// _footerSeparator
			// 
			this._footerSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._footerSeparator.BackColor = System.Drawing.SystemColors.ControlLight;
			this._footerSeparator.Location = new System.Drawing.Point(0, 0);
			this._footerSeparator.Name = "_footerSeparator";
			this._footerSeparator.Size = new System.Drawing.Size(312, 1);
			this._footerSeparator.TabIndex = 0;
			// 
			// _btnCancel
			// 
			this._btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._btnCancel.Location = new System.Drawing.Point(230, 9);
			this._btnCancel.Name = "_btnCancel";
			this._btnCancel.Size = new System.Drawing.Size(75, 23);
			this._btnCancel.TabIndex = 2;
			this._btnCancel.Text = "Cancel";
			this._btnCancel.UseVisualStyleBackColor = true;
			// 
			// _btnOK
			// 
			this._btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
			this._btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this._btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._btnOK.Location = new System.Drawing.Point(149, 9);
			this._btnOK.Name = "_btnOK";
			this._btnOK.Size = new System.Drawing.Size(75, 23);
			this._btnOK.TabIndex = 1;
			this._btnOK.Text = "OK";
			this._btnOK.UseVisualStyleBackColor = true;
			// 
			// _body
			// 
			this._body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._body.Controls.Add(this._lblPassword);
			this._body.Controls.Add(this._lblUsername);
			this._body.Controls.Add(this._txtPassword);
			this._body.Controls.Add(this._txtUsername);
			this._body.Location = new System.Drawing.Point(0, 0);
			this._body.Margin = new System.Windows.Forms.Padding(0);
			this._body.Name = "_body";
			this._body.Size = new System.Drawing.Size(312, 66);
			this._body.TabIndex = 0;
			// 
			// LoginForm
			// 
			this.AcceptButton = this._btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.CancelButton = this._btnCancel;
			this.ClientSize = new System.Drawing.Size(312, 106);
			this.Controls.Add(this._body);
			this.Controls.Add(this._footer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LoginForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Login";
			this._footer.ResumeLayout(false);
			this._body.ResumeLayout(false);
			this._body.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox _txtUsername;
		private System.Windows.Forms.TextBox _txtPassword;
		private System.Windows.Forms.Label _lblPassword;
		private System.Windows.Forms.Label _lblUsername;
		private System.Windows.Forms.Panel _footer;
		private System.Windows.Forms.Panel _footerSeparator;
		private System.Windows.Forms.Button _btnCancel;
		private System.Windows.Forms.Button _btnOK;
        private System.Windows.Forms.ToolTip _toolTip;
		private System.Windows.Forms.Panel _body;
	}
}

