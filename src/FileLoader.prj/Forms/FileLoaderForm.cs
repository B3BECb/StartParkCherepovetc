using System;
using System.Windows.Forms;

using FileLoader.ViewModels;

namespace FileLoader
{
	public partial class FileLoaderForm : Form
	{
		#region Data

		private FileLoaderViewModel _viewModel;

		#endregion

		#region .ctor

		public FileLoaderForm()
		{
			InitializeComponent();

			_viewModel = new FileLoaderViewModel();

			_txtFilePath.DataBindings.Add("Text",
								_viewModel,
								nameof(_viewModel.FilePath),
								false,
								DataSourceUpdateMode.OnPropertyChanged);
		}

		#endregion

		#region handlers

		private void OnBtnSelectFile(object sender, EventArgs e)
		{
			_viewModel.SelectFile();
		}

		#endregion
	}
}
