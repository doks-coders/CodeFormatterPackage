using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeFormatterModule
{
	public class CodeFormatterModule
    {
		public readonly FormatCode formatCode;
		public CodeFormatterModule()
		{
			formatCode = new FormatCode();
		}
		public bool NoSpaces { get; set; } = false;

		public static async Task Main(string[] args)
		{
			//new CodeFormatterModule().formatCode.FormatCodeFile("Test",true);
			var code =  new CodeFormatterModule();
			code.formatCode.FormatCodeFile("Test.cs");
			
			/*
			string demoString = "let i = Console              .   . . .   log   ()       Daniel  .  Peter   Simon . David  . Kiok   John. Pleb  .";

			Console.Write(code.GetDotJoinedString(demoString));
			*/
		
		}

		

	}
}



/*
			var indexList = demoList.Where(e => e.IndexOf(".") > -1)
				.Select((e) => demoList.IndexOf(".")).ToList();
			*/


/**
 
			//get position of .,
			//get position first .


			string[] demoArray = demoString.Split(" ",StringSplitOptions.RemoveEmptyEntries);

			var demoList =  demoArray.ToList();
			var dotIndex =  demoList.IndexOf(".");
		
			(string a, string b, string c) = (demoList[dotIndex - 1], demoList[dotIndex], demoList[dotIndex + 1]);
			Console.WriteLine(a + b + c);
			demoList.RemoveRange(dotIndex-1,3);
			demoList.Insert(dotIndex-1, (a + b + c));
			string item =  string.Join(" ", demoList);
			Console.WriteLine(item);
 
 */