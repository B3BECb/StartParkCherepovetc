using System;
using System.IO;

using StartPark;

using FileLoader.Core.Enums;

namespace FileLoader.Core
{
	public static class Loader
	{
		/// <summary>Загружает файл.</summary>
		/// <param name="path">Путь к файлу.</param>
		/// <returns>Возвращает строку, которая содержит текст файла.</returns>
		public static string LoadFile(string path)
		{
			Verify.Argument.IsNeitherNullNorEmpty(path, nameof(path));

			throw new NotImplementedException();
		}

		/// <summary>Проверяет допустимость пути.</summary>
		/// <param name="path">Путь к файлу.</param>
		/// <returns>Возвращает состояние валидации пути.</returns>
		public static VerifyState VerifyPath(string path)
		{
			Verify.Argument.IsNeitherNullNorEmpty(path, nameof(path));

			if(File.Exists(path)) return VerifyState.FileExists;
			if(Directory.Exists(path)) return VerifyState.DirectoryExists;
			return VerifyState.InvalidPath;
		}
	}
}
