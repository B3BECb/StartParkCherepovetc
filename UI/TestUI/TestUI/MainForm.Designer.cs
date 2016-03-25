namespace TestUI
{
	partial class MainForm
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
			this._txtUsername = new System.Windows.Forms.TextBox();
			this._txtPassword = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this._lblUsername = new System.Windows.Forms.Label();
			this._lblPassword = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this._footer = new System.Windows.Forms.Panel();
			this._btnOK = new System.Windows.Forms.Button();
			this._btnCancel = new System.Windows.Forms.Button();
			this._footerSeparator = new System.Windows.Forms.Panel();
			this.groupBox1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this._footer.SuspendLayout();
			this.SuspendLayout();
			// 
			// _txtUsername
			// 
			this._txtUsername.Location = new System.Drawing.Point(85, 19);
			this._txtUsername.Name = "_txtUsername";
			this._txtUsername.Size = new System.Drawing.Size(100, 20);
			this._txtUsername.TabIndex = 1;
			// 
			// _txtPassword
			// 
			this._txtPassword.Location = new System.Drawing.Point(85, 45);
			this._txtPassword.Name = "_txtPassword";
			this._txtPassword.Size = new System.Drawing.Size(100, 20);
			this._txtPassword.TabIndex = 3;
			this._txtPassword.UseSystemPasswordChar = true;
			this._txtPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this._lblPassword);
			this.groupBox1.Controls.Add(this._lblUsername);
			this.groupBox1.Controls.Add(this._txtUsername);
			this.groupBox1.Controls.Add(this._txtPassword);
			this.groupBox1.Location = new System.Drawing.Point(12, 45);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(353, 196);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// _lblUsername
			// 
			this._lblUsername.AutoSize = true;
			this._lblUsername.Location = new System.Drawing.Point(6, 22);
			this._lblUsername.Name = "_lblUsername";
			this._lblUsername.Size = new System.Drawing.Size(61, 13);
			this._lblUsername.TabIndex = 0;
			this._lblUsername.Text = "User name:";
			// 
			// _lblPassword
			// 
			this._lblPassword.AutoSize = true;
			this._lblPassword.Location = new System.Drawing.Point(6, 48);
			this._lblPassword.Name = "_lblPassword";
			this._lblPassword.Size = new System.Drawing.Size(56, 13);
			this._lblPassword.TabIndex = 2;
			this._lblPassword.Text = "Password:";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(417, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.выходToolStripMenuItem.Text = "Выход";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(9, 132);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(338, 20);
			this.textBox1.TabIndex = 4;
			this.textBox1.UseSystemPasswordChar = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 116);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Password:";
			// 
			// _footer
			// 
			this._footer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._footer.BackColor = System.Drawing.SystemColors.Control;
			this._footer.Controls.Add(this._footerSeparator);
			this._footer.Controls.Add(this._btnCancel);
			this._footer.Controls.Add(this._btnOK);
			this._footer.Location = new System.Drawing.Point(0, 277);
			this._footer.Margin = new System.Windows.Forms.Padding(0);
			this._footer.Name = "_footer";
			this._footer.Size = new System.Drawing.Size(417, 40);
			this._footer.TabIndex = 2;
			// 
			// _btnOK
			// 
			this._btnOK.Location = new System.Drawing.Point(258, 14);
			this._btnOK.Name = "_btnOK";
			this._btnOK.Size = new System.Drawing.Size(75, 23);
			this._btnOK.TabIndex = 1;
			this._btnOK.Text = "OK";
			this._btnOK.UseVisualStyleBackColor = true;
			this._btnOK.Click += button1_Click;
			// 
			// _btnCancel
			// 
			this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._btnCancel.Location = new System.Drawing.Point(339, 14);
			this._btnCancel.Name = "_btnCancel";
			this._btnCancel.Size = new System.Drawing.Size(75, 23);
			this._btnCancel.TabIndex = 2;
			this._btnCancel.Text = "Cancel";
			this._btnCancel.UseVisualStyleBackColor = true;
			this._btnCancel.Click += new System.EventHandler(this.button2_Click);
			// 
			// _footerSeparator
			// 
			this._footerSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._footerSeparator.BackColor = System.Drawing.SystemColors.ControlLight;
			this._footerSeparator.Location = new System.Drawing.Point(0, 0);
			this._footerSeparator.Name = "_footerSeparator";
			this._footerSeparator.Size = new System.Drawing.Size(417, 1);
			this._footerSeparator.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AcceptButton = this._btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.CancelButton = this._btnCancel;
			this.ClientSize = new System.Drawing.Size(417, 318);
			this.Controls.Add(this._footer);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Main Form";
			this.TopMost = true;
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this._footer.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox _txtUsername;
		private System.Windows.Forms.TextBox _txtPassword;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label _lblPassword;
		private System.Windows.Forms.Label _lblUsername;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Panel _footer;
		private System.Windows.Forms.Panel _footerSeparator;
		private System.Windows.Forms.Button _btnCancel;
		private System.Windows.Forms.Button _btnOK;
	}
}

