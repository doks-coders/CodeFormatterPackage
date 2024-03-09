using System;
using System.Collections.Generic;
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

		public void FormatCodeFile(string? path= "test.cs") 
		{
			if(string.IsNullOrEmpty(path)) return;
			string formerFile =  _directoryUtilites.GetFileDetails(path);
			string formattedFile = _utilities.GetFormattedCode(formerFile);
			_directoryUtilites.WriteFileText(path, formattedFile);
		}
		public void FormatCodeFile(string?[] path)
		{
			if(path.Length == 0) return;	
			foreach( var item in path)
			{
				if (File.Exists(item)){
					string formerFile = _directoryUtilites.GetFileDetails(item);
					string formattedFile = _utilities.GetFormattedCode(formerFile);
					_directoryUtilites.WriteFileText(item, formattedFile);
				}
				else
				{
					Console.WriteLine($"{item} does not exist");
				}
				
			}
		}




	}
}

