using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeFormatterModule
{
	public class Utilities
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

				formattedString += $" {GetSpaces(4 * level)}{GetDotJoinedString(SetLineWithEqualSpacing(s))} \n";


				if ((s.Trim().IndexOf("{") > -1 && s.Trim().Length == 1)
				||
				s.Trim().IndexOf("{") == s.Trim().Length - 1)
				{
					level++;
				}
			}
			Console.WriteLine(formattedString);
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

		#region Set Equal Spaces 
		public string SetLineWithEqualSpacing(string line)
		{
			string[] lineArray = line.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);
			int foundItem = 0;
			string itemsFound = "";

			for (int i = 0; i < lineArray.Length; i++)
			{
				lineArray[i] = lineArray[i].Trim();

				if (IsLetter(lineArray[i]))
				{
					foundItem++;
					if (foundItem > 0)
					{
						itemsFound += " ";
					}
					itemsFound += lineArray[i];
				}
			}
			return itemsFound;
		}
		#endregion

		#region IsLetter 
		public bool IsLetter(string s)
		{
			if (string.IsNullOrEmpty(s))
			{
				return false;
			}
			return true;


		}
		#endregion

		#region GetDotJoinedString
		public string GetDotJoinedString(string demoString)
		{
			string[] demoArray = demoString.Split(" ", StringSplitOptions.RemoveEmptyEntries);

			var demoList = demoArray.ToList();
			var dotIndex = demoList.IndexOf(".");

			var dotStart = demoList.FindIndex(e => Regex.IsMatch(e, "^\\.")); //abc.
			var dotEnd = demoList.FindIndex(e => Regex.IsMatch(e, "\\.$"));//.abc

			if (dotIndex == -1 && dotStart == -1 && dotEnd == -1)
			{
				return demoString.Trim();
			}
			if (dotIndex > -1)
			{
				if ((dotIndex + 1) <= demoList.Count() - 1)
				{
					string a = ""; string b = ""; string c = "";
					(a, b, c) = (demoList[dotIndex - 1], demoList[dotIndex], demoList[dotIndex + 1]);
					demoList.RemoveRange(dotIndex - 1, 3);
					demoList.Insert(dotIndex - 1, (a + b + c));
					string item = string.Join(" ", demoList);
					return GetDotJoinedString(item);
				}
			}


			if (dotEnd > -1)
			{
				if ((dotEnd + 1) <= demoList.Count() - 1)
				{
					string a = ""; string b = "";
					(a, b) = (demoList[dotEnd], demoList[dotEnd + 1]);
					demoList.RemoveRange(dotEnd, 2);
					demoList.Insert(dotEnd, (a + b));
					string item = string.Join(" ", demoList);
					return GetDotJoinedString(item);
				}
			}

			if (dotStart > -1)
			{
				string a = ""; string b = "";
				(a, b) = (demoList[dotStart - 1], demoList[dotStart]);
				demoList.RemoveRange(dotStart - 1, 2);
				demoList.Insert(dotStart - 1, (a + b));
				string item = string.Join(" ", demoList);
				return GetDotJoinedString(item);
			}

			return demoString;

		}
		#endregion

	}
}




