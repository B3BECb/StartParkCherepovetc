namespace WindowsFormsApplication1
{
	partial class Form2
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
			this._txtWriter = new System.Windows.Forms.TextBox();
			this._txtName = new System.Windows.Forms.TextBox();
			this._txtYear = new System.Windows.Forms.TextBox();
			this._btnAdd = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this._btnClear = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// _txtWriter
			// 
			this._txtWriter.Location = new System.Drawing.Point(12, 16);
			this._txtWriter.Name = "_txtWriter";
			this._txtWriter.Size = new System.Drawing.Size(100, 20);
			this._txtWriter.TabIndex = 0;
			this._txtWriter.TextChanged += new System.EventHandler(this.txtWriter_TextChanged);
			// 
			// _txtName
			// 
			this._txtName.Location = new System.Drawing.Point(118, 16);
			this._txtName.Name = "_txtName";
			this._txtName.Size = new System.Drawing.Size(100, 20);
			this._txtName.TabIndex = 1;
			this._txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
			// 
			// _txtYear
			// 
			this._txtYear.Location = new System.Drawing.Point(224, 16);
			this._txtYear.Name = "_txtYear";
			this._txtYear.Size = new System.Drawing.Size(100, 20);
			this._txtYear.TabIndex = 2;
			this._txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
			// 
			// _btnAdd
			// 
			this._btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._btnAdd.Location = new System.Drawing.Point(12, 42);
			this._btnAdd.Name = "_btnAdd";
			this._btnAdd.Size = new System.Drawing.Size(75, 23);
			this._btnAdd.TabIndex = 3;
			this._btnAdd.Text = "Добавить";
			this._btnAdd.UseVisualStyleBackColor = true;
			this._btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Автор";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(119, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Название";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(224, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Год";
			// 
			// _btnClear
			// 
			this._btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._btnClear.Location = new System.Drawing.Point(248, 41);
			this._btnClear.Name = "_btnClear";
			this._btnClear.Size = new System.Drawing.Size(75, 23);
			this._btnClear.TabIndex = 4;
			this._btnClear.Text = "Очистить";
			this._btnClear.UseVisualStyleBackColor = true;
			this._btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(341, 77);
			this.Controls.Add(this._btnClear);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._btnAdd);
			this.Controls.Add(this._txtYear);
			this.Controls.Add(this._txtName);
			this.Controls.Add(this._txtWriter);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form2";
			this.Text = "Добавление";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button _btnAdd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button _btnClear;
		private System.Windows.Forms.TextBox _txtWriter;
		private System.Windows.Forms.TextBox _txtName;
		private System.Windows.Forms.TextBox _txtYear;
	}
}