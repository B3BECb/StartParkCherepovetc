using System;
using System.Windows.Forms;

using FileLoader.ViewModels;
using FileLoader.Core;

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

			_btnLoadFile.DataBindings.Add("Enabled",
								_viewModel,
								nameof(_viewModel.IsLoadFileEnabled),
								false,
								DataSourceUpdateMode.OnPropertyChanged); 

			_lblVerifyResult.DataBindings.Add("Text",
							_viewModel,
							nameof(_viewModel.ValidationResult),
							false,
							DataSourceUpdateMode.OnPropertyChanged);
		}

		#endregion

		#region handlers

		private void OnBtnSelectFile(object sender, EventArgs e) => _viewModel.SelectFile();

		private void _btnLoadFile_Click(object sender, EventArgs e) => _viewModel.LoadFile();

		#endregion
	}
}
