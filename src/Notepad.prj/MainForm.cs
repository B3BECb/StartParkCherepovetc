using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Notepad
{
	/// <summary>Главная форма приложения.</summary>
	public sealed partial class MainForm : Form
	{
		#region .ctor

		/// <summary>Создает <see cref="MainForm"/>.</summary>
		public MainForm()
		{
			InitializeComponent();

			_txtContent.Enabled = false;
			Font = SystemFonts.MessageBoxFont;
			Progress = new Progress<ProgressArgs>();
			Progress.ProgressChanged += OnProgressChanged;
		}

		#endregion
		
		#region Properties

		private Progress<ProgressArgs> Progress { get; }

		/// <summary>Возвращает и задает путь к файлу.</summary>
		/// <value>Полный путь к файлу.</value>
		public string FilePath { get; set; }

		/// <summary>
		/// Содержимое открытого файла
		/// </summary>
		public string FileContent { get; set; }
		#endregion

		#region Handlers

		private async void OnOpenToolStripMenuItemClick(object sender, EventArgs e)
		{
			using (var dlg = new OpenFileDialog())
			{
				dlg.Multiselect = false;
				dlg.Filter = "Текстовый файл | *.txt";
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					FilePath = dlg.FileName;
					await LoadFileAsync();
				}
			}
		}

		private void OnProgressChanged(object sender, ProgressArgs e)
		{
			_progress.Value = e.Percent;
		}

		#endregion

		#region Overrided methods

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			// Корректный размер окна в dpi-режиме
			MinimumSize = Size;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				Progress.ProgressChanged -= OnProgressChanged;

				components?.Dispose();
			}
			base.Dispose(disposing);
		}

		#endregion

		#region Methods

		/// <summary> Проверяет корректность пути к файлу.</summary>
		/// <param name="filePath">Путь к файлу</param>
		/// <returns>Возвращает значение true, если путь существует и false, если нет</returns>
		public static bool VerifyPath(string filePath)
		{
			if (filePath == null || 
				filePath == String.Empty || 
				!File.Exists(filePath))
				return false;
			else 
				return true;
		}

		/// <summary>Выполняет асинхронную загрузку содержимого файла на форму.</summary>
		/// <returns>Задача загрузки содержимого файла на форму</returns>
		private async Task LoadFileAsync()
		{
			if (VerifyPath(FilePath))
			{
				Text = String.Format("{0} - {1}", FilePath, Text);
				using(var fs = new FileStream(FilePath, FileMode.Open, FileAccess.Read,
					FileShare.Read, 4096, true))
				using(var sr = new StreamReader(fs, Encoding.Default))
				{
					_statusStrip.Items[0].Text = "Загрузка...";
					_menuStrip.Enabled = false;
					_txtContent.Enabled = false;

					FileContent = await sr.ReadToEndAsync();
					_txtContent.Text = FileContent;
					_menuStrip.Enabled = true;
					_txtContent.Enabled = true;
					_statusStrip.Items[0].Text = "Готово";
				}
				// Асинхронный запуск прогресс-бара
				await CopyFilesAsync(Progress);
			}
			else
			{
				MessageBox.Show(this, "Файл не существует.", "Ошибка",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		/// <summary>Не реализовано</summary>
		public async void SaveFileAsync()
		{
			throw new NotImplementedException();
		}
		
		/// <summary>Выполняет асинхронное заполнение прогресс-бара.</summary>
		public async Task CopyFilesAsync(IProgress<ProgressArgs> progress)
		{
			for (var i = 1; i < 100; i++)
			{
				await Task.Delay(1000);
				progress.Report(new ProgressArgs(i));
			}
		}

		#endregion
	}
}
