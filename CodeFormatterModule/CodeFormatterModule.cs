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
			string res = new CodeFormatterModule().formatCode.GetFileDetails("Test/Book.cs");

			string formattedRes = new CodeFormatterModule().GetFormattedCode(res);
			Console.WriteLine(new CodeFormatterModule().GetFormattedCode(res));

			new CodeFormatterModule().formatCode.WriteFileText("Test/Book.cs",formattedRes);

			//await new TextFormatterModule().FormatFile("Test.cs");
		}

		
		public string GetFormattedCode(string text) {
			return formatCode.GetFormattedCode(text);
		}

		public async Task FormatFile(string path)
		{
			var res = await File.ReadAllTextAsync(path);
			Console.WriteLine(res);
		}
		public async Task FormatFile(string[] path)
		{

		}

		
	}
}
