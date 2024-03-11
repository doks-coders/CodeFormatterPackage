using CodeFormatterModule.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFormatterModule.Utilities
{
    internal class DirectoryUtilities:IDirectoryUtilities
    {

        #region Get the Parent Directory
        public string GetParentDirectory()
        {
            string rootDirectory = Directory.GetCurrentDirectory();
            Enumerable.Range(0, 3).ToList().ForEach((e) =>
            {
                rootDirectory = Directory.GetParent(rootDirectory).FullName;
            });
            return rootDirectory;
        }
        #endregion

        #region Get File Details
        public string GetFileDetails(string path, bool realPath = false)
        {
            if (realPath)
            {
                return File.ReadAllText(path);
            }
            path = GetRelativeFileDirectory(path);
            return File.ReadAllText(path);
        }
        #endregion

        #region Write Text To File
        public void WriteFileText(string path, string text, bool realPath = false)
        {
            if (realPath)
            {
                File.WriteAllText(path, text);
                return;
            }
            string newPath = GetRelativeFileDirectory(path);
            File.WriteAllText(newPath, text);
        }
        #endregion

        #region Get Files and Sub Files
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
        #endregion

        #region Get Relative File Directory
        public string GetRelativeFileDirectory(string relativePath)
        {
            string parentPath = GetParentDirectory();
            return $"{parentPath}/{relativePath}";
        }
        #endregion

    }
}
