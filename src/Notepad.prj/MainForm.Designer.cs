namespace Notepad
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._menuStrip = new System.Windows.Forms.MenuStrip();
			this._fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._txtContent = new System.Windows.Forms.TextBox();
			this._statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this._progress = new System.Windows.Forms.ToolStripProgressBar();
			this._menuStrip.SuspendLayout();
			this._statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// _menuStrip
			// 
			this._menuStrip.BackColor = System.Drawing.SystemColors.Control;
			this._menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._fileToolStripMenuItem});
			this._menuStrip.Location = new System.Drawing.Point(0, 0);
			this._menuStrip.Name = "_menuStrip";
			this._menuStrip.Size = new System.Drawing.Size(644, 24);
			this._menuStrip.TabIndex = 0;
			this._menuStrip.Text = "menuStrip1";
			// 
			// _fileToolStripMenuItem
			// 
			this._fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._openToolStripMenuItem});
			this._fileToolStripMenuItem.Name = "_fileToolStripMenuItem";
			this._fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this._fileToolStripMenuItem.Text = "Файл";
			// 
			// _openToolStripMenuItem
			// 
			this._openToolStripMenuItem.Name = "_openToolStripMenuItem";
			this._openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this._openToolStripMenuItem.Text = "Открыть";
			this._openToolStripMenuItem.Click += new System.EventHandler(this.OnOpenToolStripMenuItemClick);
			// 
			// _txtContent
			// 
			this._txtContent.AcceptsTab = true;
			this._txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
			this._txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._txtContent.Location = new System.Drawing.Point(0, 24);
			this._txtContent.Multiline = true;
			this._txtContent.Name = "_txtContent";
			this._txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this._txtContent.Size = new System.Drawing.Size(644, 303);
			this._txtContent.TabIndex = 1;
			// 
			// _statusStrip
			// 
			this._statusStrip.BackColor = System.Drawing.SystemColors.Control;
			this._statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusLabel1,
            this._progress});
			this._statusStrip.Location = new System.Drawing.Point(0, 305);
			this._statusStrip.Name = "_statusStrip";
			this._statusStrip.Size = new System.Drawing.Size(644, 22);
			this._statusStrip.TabIndex = 2;
			this._statusStrip.Text = "statusStrip1";
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(45, 17);
			this.toolStripStatusLabel.Text = "Готово";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
			// 
			// _progress
			// 
			this._progress.Name = "_progress";
			this._progress.Size = new System.Drawing.Size(100, 16);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(644, 327);
			this.Controls.Add(this._statusStrip);
			this.Controls.Add(this._txtContent);
			this.Controls.Add(this._menuStrip);
			this.MainMenuStrip = this._menuStrip;
			this.Name = "MainForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Блокнот";
			this._menuStrip.ResumeLayout(false);
			this._menuStrip.PerformLayout();
			this._statusStrip.ResumeLayout(false);
			this._statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip _menuStrip;
		private System.Windows.Forms.ToolStripMenuItem _fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem _openToolStripMenuItem;
		private System.Windows.Forms.TextBox _txtContent;
		private System.Windows.Forms.StatusStrip _statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripProgressBar _progress;
	}
}

