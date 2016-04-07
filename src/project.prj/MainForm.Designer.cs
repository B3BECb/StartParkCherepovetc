namespace Project
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this._prgBar = new System.Windows.Forms.ProgressBar();
			this._btnAction = new System.Windows.Forms.Button();
			this._btnReset = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// _prgBar
			// 
			this._prgBar.Location = new System.Drawing.Point(12, 12);
			this._prgBar.Name = "_prgBar";
			this._prgBar.Size = new System.Drawing.Size(392, 33);
			this._prgBar.Step = 1;
			this._prgBar.TabIndex = 0;
			// 
			// _btnAction
			// 
			this._btnAction.Location = new System.Drawing.Point(12, 66);
			this._btnAction.Name = "_btnAction";
			this._btnAction.Size = new System.Drawing.Size(117, 33);
			this._btnAction.TabIndex = 1;
			this._btnAction.Text = "Запуск";
			this._btnAction.UseVisualStyleBackColor = true;
			// 
			// _btnReset
			// 
			this._btnReset.Location = new System.Drawing.Point(151, 66);
			this._btnReset.Name = "_btnReset";
			this._btnReset.Size = new System.Drawing.Size(117, 33);
			this._btnReset.TabIndex = 2;
			this._btnReset.Text = "Сброс";
			this._btnReset.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 121);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "© 2016";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(416, 145);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._btnReset);
			this.Controls.Add(this._btnAction);
			this.Controls.Add(this._prgBar);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "Главное окошечко";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExitApplication);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ProgressBar _prgBar;
		private System.Windows.Forms.Button _btnAction;
		private System.Windows.Forms.Button _btnReset;
		private System.Windows.Forms.Label label1;
	}
}

