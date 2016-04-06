namespace FileLoader
{
	partial class FileLoaderForm
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
			this.label1 = new System.Windows.Forms.Label();
			this._btnSelectFile = new System.Windows.Forms.Button();
			this._btnLoadFile = new System.Windows.Forms.Button();
			this._lblVerifyResult = new System.Windows.Forms.Label();
			this._txtFilePath = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Путь к файлу:";
			// 
			// _btnSelectFile
			// 
			this._btnSelectFile.Location = new System.Drawing.Point(250, 23);
			this._btnSelectFile.Name = "_btnSelectFile";
			this._btnSelectFile.Size = new System.Drawing.Size(29, 23);
			this._btnSelectFile.TabIndex = 2;
			this._btnSelectFile.Text = "...";
			this._btnSelectFile.UseVisualStyleBackColor = true;
			this._btnSelectFile.Click += new System.EventHandler(this.OnBtnSelectFile);
			// 
			// _btnLoadFile
			// 
			this._btnLoadFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this._btnLoadFile.Enabled = false;
			this._btnLoadFile.Location = new System.Drawing.Point(106, 79);
			this._btnLoadFile.Name = "_btnLoadFile";
			this._btnLoadFile.Size = new System.Drawing.Size(75, 23);
			this._btnLoadFile.TabIndex = 3;
			this._btnLoadFile.Text = "Загрузить";
			this._btnLoadFile.UseVisualStyleBackColor = true;
			this._btnLoadFile.Click += new System.EventHandler(this._btnLoadFile_Click);
			// 
			// _lblVerifyResult
			// 
			this._lblVerifyResult.AutoSize = true;
			this._lblVerifyResult.Location = new System.Drawing.Point(9, 49);
			this._lblVerifyResult.Name = "_lblVerifyResult";
			this._lblVerifyResult.Size = new System.Drawing.Size(123, 13);
			this._lblVerifyResult.TabIndex = 5;
			this._lblVerifyResult.Text = "Указан неверный путь";
			// 
			// _txtFilePath
			// 
			this._txtFilePath.Location = new System.Drawing.Point(12, 25);
			this._txtFilePath.Name = "_txtFilePath";
			this._txtFilePath.Size = new System.Drawing.Size(232, 20);
			this._txtFilePath.TabIndex = 6;
			// 
			// FileLoaderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(284, 114);
			this.Controls.Add(this._txtFilePath);
			this.Controls.Add(this._lblVerifyResult);
			this.Controls.Add(this._btnLoadFile);
			this.Controls.Add(this._btnSelectFile);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FileLoaderForm";
			this.Text = "Загрузчик файлов";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button _btnSelectFile;
		private System.Windows.Forms.Button _btnLoadFile;
		private System.Windows.Forms.Label _lblVerifyResult;
		private System.Windows.Forms.TextBox _txtFilePath;
	}
}

