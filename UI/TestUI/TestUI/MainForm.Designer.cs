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
            if (disposing && (components != null))
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
			this._btnLogin = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// _btnLogin
			// 
			this._btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this._btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._btnLogin.Location = new System.Drawing.Point(120, 106);
			this._btnLogin.Name = "_btnLogin";
			this._btnLogin.Size = new System.Drawing.Size(75, 23);
			this._btnLogin.TabIndex = 0;
			this._btnLogin.Text = "Login";
			this._btnLogin.UseVisualStyleBackColor = true;
			this._btnLogin.Click += new System.EventHandler(this.OnLoginClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this._btnLogin);
			this.Name = "MainForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Main Form";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnLogin;
    }
}