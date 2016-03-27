using FileLoader.Core.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLoader.Core
{
	public static class Loader
	{
		public static string LoadFile(string path)
		{
			throw new NotImplementedException();
		}

		public static VerifyStates VerifyPath(string path)
		{
			if(File.Exists(path)) return VerifyStates.FileExists;
			if(Directory.Exists(path)) return VerifyStates.DirectoryExists;
			return VerifyStates.InvalidPath;
		}
	}
}
