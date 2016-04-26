using System;
using System.Drawing;
using System.Windows.Forms;

namespace TestMVC
{
	public partial class MainForm : Form
	{
		#region Properties

		private MainController Controller { get; }

		private string Fullname
		{
			get { return _txtFullname.Text; }
		}

		#endregion

		public MainForm(MainController controller)
		{
			if(controller == null)
			{
				throw new ArgumentNullException(nameof(controller));
			}

			Controller = controller;

			InitializeComponent();

			_idColumn.DataPropertyName = nameof(StudenMetadataRecord.Id);
			_fullNameColumn.DataPropertyName = nameof(StudenMetadataRecord.Fullname);

			Font = SystemFonts.MessageBoxFont;
			BackColor = SystemColors.Window;

			_dataGrid.AutoGenerateColumns = false;
			_dataGrid.DataSource = controller.Records;
		}

		private void OnAddNewStudentMetadataClick(object sender, EventArgs e)
		{
			Controller.AddStudentMetadata(Fullname);
		}
	}
}
