using FileLoader.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileLoader.Forms
{
	sealed class FileLoaderViewModel : INotifyPropertyChanged
	{
		#region Properties

		/// <summary>Возвращает и задаёт путь к файлу.</summary>
		public string FilePath { get { return _filePath; } set { _filePath = value; VerifyPath(); } }

		/// <summary>Возвращает результат валидации.</summary>
		public string ValidationResult { get; private set; } = "Указан неверный путь";

		/// <summary>Включна ли кнопка.</summary>
		public bool IsLoadFileEnabled { get; private set; }

		#endregion

		#region Data

		private string _filePath;

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
					VerifyPath();
				}
			}
		}

		/// <summary>Выполняет загрузку файла в новое окно.</summary>
		public void LoadFile()
		{
			var content = Loader.LoadFile(FilePath);

			new LoadedFile(System.IO.Path.GetFileName(FilePath), content).Show();
		}

		/// <summary>Валидирует путь к файлу.</summary>
		public void VerifyPath()
		{
			if(!string.IsNullOrEmpty(FilePath))
			{
				switch(Loader.VerifyPath(FilePath))
				{
					case Core.Enums.VerifyState.FileExists:
						ValidationResult = "";
						IsLoadFileEnabled = true;
						break;
					case Core.Enums.VerifyState.DirectoryExists:
						ValidationResult = "Файл не существует или не указан";
						IsLoadFileEnabled = false;
						break;
					case Core.Enums.VerifyState.InvalidPath:
						ValidationResult = "Указан неверный путь";
						IsLoadFileEnabled = false;
						break;
				}

				OnPropertyChanged(nameof(ValidationResult));
				OnPropertyChanged(nameof(IsLoadFileEnabled));
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
