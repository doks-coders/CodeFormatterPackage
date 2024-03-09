using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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

		public static async Task Main(string[] args)
		{
			new CodeFormatterModule().formatCode.FormatCodeFile("Test/Book.cs");
			Console.WriteLine("Done");
			//await new TextFormatterModule().FormatFile("Test.cs");
		}

		
		
		
	}
}
