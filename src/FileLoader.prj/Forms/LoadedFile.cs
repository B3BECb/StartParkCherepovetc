using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileLoader.Forms
{
	public partial class LoadedFile : Form
	{
		/// <summary>инициализирует окно, отображающее загруженный файл.</summary>
		/// <param name="fileName">Имя загруженного файла.</param>
		/// <param name="fileContent">Содержание загруженного файла.</param>
		public LoadedFile(string fileName, string fileContent)
		{			
			InitializeComponent();

			Text = fileName;

			_txtFileContent.Text = fileContent;
		}
	}
}
