namespace ChatRoom
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
            this._footer = new System.Windows.Forms.Panel();
            this._btnOK = new System.Windows.Forms.Button();
            this._btnDelete = new System.Windows.Forms.Button();
            this._footerSeparator = new System.Windows.Forms.Panel();
            this._lstMessageList = new System.Windows.Forms.ListBox();
            this._txtMessageBox = new System.Windows.Forms.RichTextBox();
            this._footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // _footer
            // 
            this._footer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._footer.BackColor = System.Drawing.SystemColors.Control;
            this._footer.Controls.Add(this._txtMessageBox);
            this._footer.Controls.Add(this._btnOK);
            this._footer.Controls.Add(this._btnDelete);
            this._footer.Location = new System.Drawing.Point(-1, 273);
            this._footer.Name = "_footer";
            this._footer.Size = new System.Drawing.Size(390, 41);
            this._footer.TabIndex = 0;
            // 
            // _btnOK
            // 
            this._btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnOK.Location = new System.Drawing.Point(226, 6);
            this._btnOK.Name = "_btnOK";
            this._btnOK.Size = new System.Drawing.Size(75, 23);
            this._btnOK.TabIndex = 2;
            this._btnOK.Text = "OK";
            this._btnOK.UseVisualStyleBackColor = true;
            this._btnOK.Click += new System.EventHandler(this._btnOK_Click);
            // 
            // _btnDelete
            // 
            this._btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnDelete.Location = new System.Drawing.Point(307, 6);
            this._btnDelete.Name = "_btnDelete";
            this._btnDelete.Size = new System.Drawing.Size(70, 23);
            this._btnDelete.TabIndex = 3;
            this._btnDelete.Text = "Delete";
            this._btnDelete.UseVisualStyleBackColor = true;
            this._btnDelete.Click += new System.EventHandler(this._btnDelete_Click);
            // 
            // _footerSeparator
            // 
            this._footerSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._footerSeparator.BackColor = System.Drawing.SystemColors.ControlLight;
            this._footerSeparator.Location = new System.Drawing.Point(1, 272);
            this._footerSeparator.Name = "_footerSeparator";
            this._footerSeparator.Size = new System.Drawing.Size(388, 1);
            this._footerSeparator.TabIndex = 1;
            this._footerSeparator.Paint += new System.Windows.Forms.PaintEventHandler(this._footerSeparator_Paint);
            // 
            // _lstMessageList
            // 
            this._lstMessageList.FormattingEnabled = true;
            this._lstMessageList.Location = new System.Drawing.Point(12, 12);
            this._lstMessageList.Name = "_lstMessageList";
            this._lstMessageList.Size = new System.Drawing.Size(364, 251);
            this._lstMessageList.TabIndex = 0;
            // 
            // _txtMessageBox
            // 
            this._txtMessageBox.Location = new System.Drawing.Point(13, 8);
            this._txtMessageBox.Name = "_txtMessageBox";
            this._txtMessageBox.Size = new System.Drawing.Size(207, 24);
            this._txtMessageBox.TabIndex = 4;
            this._txtMessageBox.Text = "";
            this._txtMessageBox.TextChanged += new System.EventHandler(this._txtMessageBox_TextChanged);
            // 
            // MainForm
            // 
            this.AcceptButton = this._btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(388, 313);
            this.Controls.Add(this._lstMessageList);
            this.Controls.Add(this._footerSeparator);
            this.Controls.Add(this._footer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Form1";
            this._footer.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel _footer;
		private System.Windows.Forms.Panel _footerSeparator;
		private System.Windows.Forms.Button _btnOK;
		private System.Windows.Forms.Button _btnDelete;
		private System.Windows.Forms.ListBox _lstMessageList;
        private System.Windows.Forms.RichTextBox _txtMessageBox;
    }
}

