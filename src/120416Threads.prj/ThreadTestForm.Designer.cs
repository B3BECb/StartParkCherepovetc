namespace _120416Threads
{
	partial class ThreadTestForm
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
			this._btnStart = new System.Windows.Forms.Button();
			this._progressBar = new System.Windows.Forms.ProgressBar();
			this._btnStop = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// _btnStart
			// 
			this._btnStart.Location = new System.Drawing.Point(24, 172);
			this._btnStart.Name = "_btnStart";
			this._btnStart.Size = new System.Drawing.Size(75, 23);
			this._btnStart.TabIndex = 0;
			this._btnStart.Text = "Start";
			this._btnStart.UseVisualStyleBackColor = true;
			this._btnStart.Click += new System.EventHandler(this._btnStart_Click);
			// 
			// _progressBar
			// 
			this._progressBar.Location = new System.Drawing.Point(24, 114);
			this._progressBar.Name = "_progressBar";
			this._progressBar.Size = new System.Drawing.Size(236, 23);
			this._progressBar.TabIndex = 1;
			// 
			// _btnStop
			// 
			this._btnStop.Location = new System.Drawing.Point(185, 172);
			this._btnStop.Name = "_btnStop";
			this._btnStop.Size = new System.Drawing.Size(75, 23);
			this._btnStop.TabIndex = 2;
			this._btnStop.Text = "Stop";
			this._btnStop.UseVisualStyleBackColor = true;
			this._btnStop.Click += new System.EventHandler(this._btnStop_Click);
			// 
			// ThreadTestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this._btnStop);
			this.Controls.Add(this._progressBar);
			this.Controls.Add(this._btnStart);
			this.Name = "ThreadTestForm";
			this.Text = "Thread test";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button _btnStart;
		private System.Windows.Forms.ProgressBar _progressBar;
		private System.Windows.Forms.Button _btnStop;
	}
}

