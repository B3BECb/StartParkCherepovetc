using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileLoader.ViewModels
{
	sealed class FileLoaderViewModel : INotifyPropertyChanged
	{
		#region Properties

		public string FilePath { get; set; } = "Не указан";

		#endregion

		#region Events
		
		public event PropertyChangedEventHandler PropertyChanged;

		#endregion

		#region Public methoods
		/// <summary>Вызывает окно выбора файла.</summary>
		public void SelectFile()
		{
			using(var fileDlg = new OpenFileDialog() { Multiselect = false, Filter = "Текстовые файлы (*.txt)|*.txt" })
			{
				if(fileDlg.ShowDialog() == DialogResult.OK)
				{
					FilePath = fileDlg.FileName;
					OnPropertyChanged(nameof(FilePath));
				}
			}
		}

		#endregion

		#region Private methods

		private void OnPropertyChanged(string propertyName)
		{
			PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		#endregion
	}
}
