namespace Picture
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
			this._pictureBox = new System.Windows.Forms.PictureBox();
			this._btnLoading = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this._pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// _pictureBox
			// 
			this._pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._pictureBox.Location = new System.Drawing.Point(12, 41);
			this._pictureBox.Name = "_pictureBox";
			this._pictureBox.Size = new System.Drawing.Size(345, 202);
			this._pictureBox.TabIndex = 0;
			this._pictureBox.TabStop = false;
			// 
			// _btnLoading
			// 
			this._btnLoading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._btnLoading.Location = new System.Drawing.Point(12, 12);
			this._btnLoading.Name = "_btnLoading";
			this._btnLoading.Size = new System.Drawing.Size(345, 23);
			this._btnLoading.TabIndex = 1;
			this._btnLoading.Text = "Загрузить";
			this._btnLoading.UseVisualStyleBackColor = true;
			this._btnLoading.Click += new System.EventHandler(this._btnLoading_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(369, 255);
			this.Controls.Add(this._btnLoading);
			this.Controls.Add(this._pictureBox);
			this.Name = "MainForm";
			this.Text = "Загрузка изображения";
			((System.ComponentModel.ISupportInitialize)(this._pictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox _pictureBox;
		private System.Windows.Forms.Button _btnLoading;
	}
}

