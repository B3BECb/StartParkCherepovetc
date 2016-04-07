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
			this._pictureBox.Location = new System.Drawing.Point(16, 50);
			this._pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this._pictureBox.Name = "_pictureBox";
			this._pictureBox.Size = new System.Drawing.Size(460, 249);
			this._pictureBox.TabIndex = 0;
			this._pictureBox.TabStop = false;
			// 
			// _btnLoading
			// 
			this._btnLoading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._btnLoading.Location = new System.Drawing.Point(16, 15);
			this._btnLoading.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this._btnLoading.Name = "_btnLoading";
			this._btnLoading.Size = new System.Drawing.Size(460, 28);
			this._btnLoading.TabIndex = 1;
			this._btnLoading.Text = "Загрузить";
			this._btnLoading.UseVisualStyleBackColor = true;
			this._btnLoading.Click += new System.EventHandler(this._btnLoading_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(492, 314);
			this.Controls.Add(this._btnLoading);
			this.Controls.Add(this._pictureBox);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

