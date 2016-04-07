namespace FileLoader.Core.Enums
{
	/// <summary>Перечисляет состояния валидации пути.</summary>
	public enum VerifyState
	{
		/// <summary>Директрия и файл существуют.</summary>
		FileExists,

		/// <summary>Существует только директория.</summary>
		DirectoryExists,

		/// <summary>Введён недопустимый путь.</summary>
		InvalidPath
	}
}
