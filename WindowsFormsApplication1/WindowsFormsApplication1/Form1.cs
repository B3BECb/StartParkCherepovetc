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
	public partial class Form1 : Form
	{

		/// <summary>
		/// Creating class object
		/// </summary>
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
		/// <summary>
		/// Opening Form2 and giving GridView to Form2
		/// </summary>
		private void btnAdd_Click(object sender, EventArgs e)
		{
			Form2 form2;
			form2 = new Form2(dgvTable);
			form2.ShowDialog();
			
		}

		/// <summary>
		/// Deleting current row from DataGrid
		/// </summary>
		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dgvTable.Rows.Count>0) //if DataGrid has rows
			{
				dgvTable.Rows.Remove(dgvTable.CurrentRow); //delete current row
			}
		}
	}
}
