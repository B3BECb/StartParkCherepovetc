﻿namespace WindowsFormsApplication1
{
	partial class Form1
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
			if(disposing && (components != null))
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
			this._btnAdd = new System.Windows.Forms.Button();
			this._btnDelete = new System.Windows.Forms.Button();
			this.dgvTable = new System.Windows.Forms.DataGridView();
			this.сWriter = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
			this.SuspendLayout();
			// 
			// _btnAdd
			// 
			this._btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._btnAdd.Location = new System.Drawing.Point(12, 293);
			this._btnAdd.Name = "_btnAdd";
			this._btnAdd.Size = new System.Drawing.Size(114, 29);
			this._btnAdd.TabIndex = 1;
			this._btnAdd.Text = "Добавить";
			this._btnAdd.UseVisualStyleBackColor = true;
			this._btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// _btnDelete
			// 
			this._btnDelete.Location = new System.Drawing.Point(342, 293);
			this._btnDelete.Name = "_btnDelete";
			this._btnDelete.Size = new System.Drawing.Size(114, 29);
			this._btnDelete.TabIndex = 2;
			this._btnDelete.Text = "Удалить";
			this._btnDelete.UseVisualStyleBackColor = true;
			this._btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// dgvTable
			// 
			this.dgvTable.AllowUserToAddRows = false;
			this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.сWriter,
            this.cName,
            this.cYear});
			this.dgvTable.Location = new System.Drawing.Point(12, 12);
			this.dgvTable.Name = "dgvTable";
			this.dgvTable.Size = new System.Drawing.Size(444, 257);
			this.dgvTable.TabIndex = 0;
			// 
			// сWriter
			// 
			this.сWriter.HeaderText = "Автор";
			this.сWriter.Name = "сWriter";
			this.сWriter.Width = 150;
			// 
			// cName
			// 
			this.cName.HeaderText = "Название";
			this.cName.Name = "cName";
			this.cName.Width = 150;
			// 
			// cYear
			// 
			this.cYear.HeaderText = "Год";
			this.cYear.Name = "cYear";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(468, 334);
			this.Controls.Add(this.dgvTable);
			this.Controls.Add(this._btnDelete);
			this.Controls.Add(this._btnAdd);
			this.Name = "Form1";
			this.Text = "Книги";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button _btnAdd;
		private System.Windows.Forms.Button _btnDelete;
		private System.Windows.Forms.DataGridViewTextBoxColumn сWriter;
		private System.Windows.Forms.DataGridViewTextBoxColumn cName;
		private System.Windows.Forms.DataGridViewTextBoxColumn cYear;
		public System.Windows.Forms.DataGridView dgvTable;
	}
}
