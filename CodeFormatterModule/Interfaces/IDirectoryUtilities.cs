using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFormatterModule.Interfaces
{
	internal interface IDirectoryUtilities
	{
		/// <summary>
		/// Get's the parent directory of the project
		/// </summary>
		/// <returns></returns>
		string GetParentDirectory();


		/// <summary>
		/// This gets the UTF8 information from the file
		/// </summary>
		/// <param name="path"></param>
		/// <param name="realPath"></param>
		/// <returns></returns>
		string GetFileDetails(string path, bool realPath = false);

		/// <summary>
		/// This writes the string to the file
		/// </summary>
		/// <param name="path"></param>
		/// <param name="text"></param>
		/// <param name="realPath"></param>
		void WriteFileText(string path, string text, bool realPath = false);

		/// <summary>
		/// This is used for getting the files in a directory and subdirectories
		/// </summary>
		/// <param name="directoryPath"></param>
		/// <returns></returns>
		List<string> GetAllFilesWithSubFiles(string directoryPath);

		/// <summary>
		/// This gets the relative directory path from the path provided
		/// </summary>
		/// <param name="relativePath"></param>
		/// <returns></returns>
		string GetRelativeFileDirectory(string relativePath);
	}
}
