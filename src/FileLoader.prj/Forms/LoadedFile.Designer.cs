namespace FileLoader.Forms
{
	partial class LoadedFile
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
			this._txtFileContent = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// _txtFileContent
			// 
			this._txtFileContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._txtFileContent.Location = new System.Drawing.Point(12, 12);
			this._txtFileContent.Multiline = true;
			this._txtFileContent.Name = "_txtFileContent";
			this._txtFileContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this._txtFileContent.Size = new System.Drawing.Size(393, 292);
			this._txtFileContent.TabIndex = 0;
			// 
			// LoadedFile
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(417, 316);
			this.Controls.Add(this._txtFileContent);
			this.Name = "LoadedFile";
			this.Text = "%LoadedFile%";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox _txtFileContent;
	}
}