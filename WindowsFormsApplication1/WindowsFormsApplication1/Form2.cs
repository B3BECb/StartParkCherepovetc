using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class NewBookForm : Form
	{
		public string BookName
		{
			get { return _txtName.Text; }
			private set
			{
				_txtName.Text = value;
            }
		}
		//private DataGridView _dgv;  //variable - GridView pointer

		/// <summary>
		/// Giving access to GridView on Form2
		/// </summary>
		/// <param name="_dgv">GridView pointer</param>
		public NewBookForm()
		{
			InitializeComponent();
			//if(_dgv != null) this._dgv = _dgv;
		}

		/// <summary>
		/// Adding data in GridView
		/// </summary>
		private void btnAdd_Click(object sender, EventArgs e)
		{
			
			if (_txtWriter.Text=="") //if textbox not empty
			{
				_txtWriter.BackColor = Color.Red;
			}
			

			else if(_txtName.Text == "")
			{
				_txtName.BackColor = Color.Red;
			}

			else if(_txtYear.Text == "")
			{
				_txtYear.BackColor = Color.Red;

			}

			else
			{
				//_dgv.Rows.Add(new object[] { _txtWriter.Text, _txtName.Text, _txtYear.Text }); //add data in GridView

			}

			DialogResult = DialogResult.OK;
		}

		/// <summary>
		/// Return white color of TextBox when writing Writer
		/// </summary>
		private void txtWriter_TextChanged(object sender, EventArgs e)
		{
			_txtWriter.BackColor = Color.White;
		}

		/// <summary>
		/// Return white color of TextBox when writing Name
		/// </summary>
		private void txtName_TextChanged(object sender, EventArgs e)
		{
			_txtName.BackColor = Color.White;
		}

		/// <summary>
		/// Return white color of TextBox when writing Year
		/// </summary>
		private void txtYear_TextChanged(object sender, EventArgs e)
		{
			_txtYear.BackColor = Color.White;
		}

		/// <summary>
		/// Clear all TextBoxs
		/// </summary>
		private void btnClear_Click(object sender, EventArgs e)
		{
			_txtName.Clear();
			_txtWriter.Clear();
			_txtYear.Clear();
		}
	}
}
