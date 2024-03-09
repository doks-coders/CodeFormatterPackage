using System;
using System.Collections.Generic;
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


		public string GetFileDetails(string path)
		{
			string parentPath = GetParentDirectory();
			string newPath = $"{parentPath}/{path}";
			return File.ReadAllText(newPath);
		}

		public void WriteFileText(string path, string text)
		{
			string parentPath = GetParentDirectory();
			string newPath = $"{parentPath}/{path}";
			File.WriteAllText(newPath, text);
		}
	}
}
