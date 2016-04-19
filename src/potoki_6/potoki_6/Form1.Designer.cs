namespace potoki_6
{
    partial class Form1
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
            if (disposing && (components != null))
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
            this._prbProces = new System.Windows.Forms.ProgressBar();
            this._btnreset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _prbProces
            // 
            this._prbProces.Location = new System.Drawing.Point(12, 12);
            this._prbProces.Name = "_prbProces";
            this._prbProces.Size = new System.Drawing.Size(268, 23);
            this._prbProces.TabIndex = 0;
            // 
            // _btnreset
            // 
            this._btnreset.Location = new System.Drawing.Point(12, 41);
            this._btnreset.Name = "_btnreset";
            this._btnreset.Size = new System.Drawing.Size(268, 23);
            this._btnreset.TabIndex = 1;
            this._btnreset.Text = "Start";
            this._btnreset.UseVisualStyleBackColor = true;
            this._btnreset.Click += new System.EventHandler(this._btnreset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(292, 78);
            this.Controls.Add(this._btnreset);
            this.Controls.Add(this._prbProces);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Поток";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar _prbProces;
        private System.Windows.Forms.Button _btnreset;
    }
}

