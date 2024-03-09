using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFormatterModule
{
	public class FormatCode
	{
		private readonly Utilities _utilities;
		private readonly DirectoryUtilities _directoryUtilites;
		public FormatCode()
		{
			_utilities = new Utilities();
			_directoryUtilites = new DirectoryUtilities();
		}

		public void FormatCodeFile(string? path)
		{
			if (string.IsNullOrEmpty(path)) return;
			if (File.Exists(_directoryUtilites.GetRelativeFileDirectory(path)))
			{
				RetrieveAndFormatCode(path);
			}
			else
			{
				Console.WriteLine($"{path} does not exist");
			}
		}


		public void FormatCodeFile(string?[] paths)
		{
			if (paths.Length == 0) return;
			foreach (var path in paths)
			{
				if (File.Exists(_directoryUtilites.GetRelativeFileDirectory(path)))
				{
					RetrieveAndFormatCode(path);
				}
				else
				{
					Console.WriteLine($"{path} does not exist");
				}

			}
		}


		public void FormatCodeFile(string? fileDirectory, bool children = true)
		{
			if (fileDirectory == null) return;

			List<string> paths = _directoryUtilites.GetAllFilesWithSubFiles(fileDirectory);

			foreach (var path in paths)
			{
				if (File.Exists(path))
				{
					RetrieveAndFormatCode(path, true);
				}
				else
				{
					Console.WriteLine($"{path} does not exist");
				}

			}
		}


		public void RetrieveAndFormatCode(string path, bool realPath = false)
		{
			var fileContent = _directoryUtilites.GetFileDetails(path, realPath);
			string formattedFile = _utilities.GetFormattedCode(fileContent);
			_directoryUtilites.WriteFileText(path, formattedFile, realPath);
		}




	}
}

