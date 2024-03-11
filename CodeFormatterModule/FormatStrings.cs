using CodeFormatterModule.LineFormatConfigurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFormatterModule
{
	internal class FormatStrings
	{
		
		#region GetFormattedCode 
		public string GetFormattedCode(string codePage)
		{
			string[] str = codePage.Split('\n');
			int level = 0;
			string formattedString = "";
			foreach (string s in str)
			{

				if ((s.Trim().IndexOf("}") > -1 && s.Trim().Length == 1)
				||
				s.Trim().IndexOf("}") == s.Trim().Length - 1)
				{
					level--;
				}

				formattedString += $" {GetSpaces(4 * level)}{new GetFormattedStrings(s).formattedStrings} \n";


				if ((s.Trim().IndexOf("{") > -1 && s.Trim().Length == 1)
				||
				s.Trim().IndexOf("{") == s.Trim().Length - 1)
				{
					level++;
				}
			}
			return formattedString;
		}
		#endregion


		#region GetSpaces 
		public string GetSpaces(int spaces)
		{
			if (spaces > 0)
			{
				string emptySpace = "";
				Enumerable.Range(0, spaces).ToList().ForEach(x =>
				{
					emptySpace += " ";
				});
				return emptySpace;
			}
			return "";
		}
		#endregion
	}
}
