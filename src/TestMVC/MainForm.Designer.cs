namespace TestMVC
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
			this._dataGrid = new System.Windows.Forms.DataGridView();
			this._idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._fullNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._txtFullname = new System.Windows.Forms.TextBox();
			this._btnAddNewStudentMetadata = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this._dataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// _dataGrid
			// 
			this._dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._idColumn,
            this._fullNameColumn});
			this._dataGrid.Location = new System.Drawing.Point(0, 0);
			this._dataGrid.Name = "_dataGrid";
			this._dataGrid.Size = new System.Drawing.Size(284, 155);
			this._dataGrid.TabIndex = 0;
			// 
			// _idColumn
			// 
			this._idColumn.HeaderText = "ID";
			this._idColumn.Name = "_idColumn";
			// 
			// _fullNameColumn
			// 
			this._fullNameColumn.HeaderText = "Full name";
			this._fullNameColumn.Name = "_fullNameColumn";
			// 
			// _txtFullname
			// 
			this._txtFullname.Location = new System.Drawing.Point(12, 161);
			this._txtFullname.Name = "_txtFullname";
			this._txtFullname.Size = new System.Drawing.Size(100, 20);
			this._txtFullname.TabIndex = 1;
			// 
			// _btnAddNewStudentMetadata
			// 
			this._btnAddNewStudentMetadata.Location = new System.Drawing.Point(118, 161);
			this._btnAddNewStudentMetadata.Name = "_btnAddNewStudentMetadata";
			this._btnAddNewStudentMetadata.Size = new System.Drawing.Size(75, 23);
			this._btnAddNewStudentMetadata.TabIndex = 2;
			this._btnAddNewStudentMetadata.Text = "Add";
			this._btnAddNewStudentMetadata.UseVisualStyleBackColor = true;
			this._btnAddNewStudentMetadata.Click += new System.EventHandler(this.OnAddNewStudentMetadataClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this._btnAddNewStudentMetadata);
			this.Controls.Add(this._txtFullname);
			this.Controls.Add(this._dataGrid);
			this.Name = "MainForm";
			this.Text = "MainForm";
			((System.ComponentModel.ISupportInitialize)(this._dataGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView _dataGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn _idColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn _fullNameColumn;
		private System.Windows.Forms.TextBox _txtFullname;
		private System.Windows.Forms.Button _btnAddNewStudentMetadata;
	}
}

