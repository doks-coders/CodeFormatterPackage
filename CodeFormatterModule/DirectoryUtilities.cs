using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFormatterModule
{
	internal class DirectoryUtilities
	{
		public string GetParentDirectory()
		{
			string rootDirectory = Directory.GetCurrentDirectory();
			Enumerable.Range(0, 3).ToList().ForEach((e) =>
			{
				rootDirectory = Directory.GetParent(rootDirectory).FullName;
			});
			return rootDirectory;
		}


		
		public string GetFileDetails(string path,bool realPath=false)
		{
			if (realPath)
			{
				return File.ReadAllText(path);
			}
			path = GetRelativeFileDirectory(path);
			return File.ReadAllText(path);
		}

		public void WriteFileText(string path, string text, bool realPath=false)
		{
		
			if (realPath)
			{
				File.WriteAllText(path, text);
				return;
			}
			string newPath = GetRelativeFileDirectory(path);
			File.WriteAllText(newPath, text);
		}

		public List<string> GetAllFilesWithSubFiles(string directoryPath)
		{
	
			directoryPath = GetRelativeFileDirectory(directoryPath); ;

			List<string> allFiles = new List<string>();
			if (Directory.Exists(directoryPath))
			{
			
				string[] files = Directory.GetFiles(directoryPath);
				allFiles.AddRange(files);

				
				string[] subdirectories = Directory.GetDirectories(directoryPath);
				foreach (var subdirectory in subdirectories)
				{
					List<string> subdirectoryFiles = GetAllFilesWithSubFiles(subdirectory);
					allFiles.AddRange(subdirectoryFiles);
				}
			}

			return allFiles;
		}

		public string GetRelativeFileDirectory(string relativePath)
		{
			string parentPath = GetParentDirectory();
			return $"{parentPath}/{relativePath}";
		}

	}
}
