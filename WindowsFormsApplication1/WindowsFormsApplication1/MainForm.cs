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
	
	public sealed partial class MainForm : Form
	{
		#region Data

		private readonly BindingList<Book> _books;

		#endregion

		/// <summary>
		/// Creating class object
		/// </summary>
		public MainForm()
		{
			InitializeComponent();

			Font = SystemFonts.MessageBoxFont;

			_booksTable.AutoGenerateColumns = false;
			_booksTable.MultiSelect = false;
			_booksTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			_booksTable.RowHeadersVisible = false;
			_booksTable.BackgroundColor = SystemColors.Window;
			cName.DataPropertyName = nameof(Book.Name);

			_books = new BindingList<Book>();
			_books.Add(new Book() { Name = "fafasf" });

			_booksTable.DataSource = _books;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			MinimumSize = Size;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
		/// <summary>
		/// Opening Form2 and giving GridView to Form2
		/// </summary>
		private void btnAdd_Click(object sender, EventArgs e)
		{
			using(var form = new NewBookForm())
			{
				switch(form.ShowDialog(this))
				{
					case DialogResult.OK:
						{
							var newBook = new Book()
							{
								Name = form.BookName,
							};

							_books.Add(newBook);

							break;
						}
					default:
					case DialogResult.Cancel:
						{
							break;
						}
				}
			}
		}

		/// <summary>
		/// Deleting current row from DataGrid
		/// </summary>
		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (_booksTable.Rows.Count>0) //if DataGrid has rows
			{
				if(_booksTable.SelectedRows.Count > 0)
				{
					var selectedBook = (Book)_booksTable.SelectedRows[0].DataBoundItem;
					if(selectedBook != null)
					{
						_books.Remove(selectedBook);
					}
				}
				//_booksTable.Rows.Remove(_booksTable.CurrentRow); //delete current row
			}
		}

		public class Book
		{
			public string Name { get; set; }
		}
	}
}
