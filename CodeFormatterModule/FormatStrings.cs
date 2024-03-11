using CodeFormatterModule.LineFormatConfigurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFormatterModule;

internal class FormatStrings
{
	/// <summary>
	/// This gets the formatted code from the string
	/// </summary>
	/// <param name="codePage"></param>
	/// <returns>string</returns>
	#region GetFormattedCode 
	public string GetFormattedCode(string codePage)
	{
		string[] str = codePage.Split('\n');
		int level = 0;
		string formattedString = "";
		foreach (string s in str)
		{

			if ((s.Trim().IndexOf("}") > -1 && s.Trim().Length == 1) //means only } is on the line
			||
			s.Trim().IndexOf("}") == s.Trim().Length - 1) //means } is the last element on the line
			{
				level--;
			}

			formattedString += $"{GetSpaces(4 * level)}{new GetFormattedStrings(s).formattedStrings} \n";


			if ((s.Trim().IndexOf("{") > -1 && s.Trim().Length == 1) //means only { is on the line
			||
			s.Trim().IndexOf("{") == s.Trim().Length - 1) // means { is the last element on the line
			{
				level++;
			}
		}
		return formattedString;
	}
	#endregion

	/// <summary>
	/// Adds returns string with specified number of spaces
	/// </summary>
	/// <param name="spaces"></param>
	/// <returns></returns>
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
