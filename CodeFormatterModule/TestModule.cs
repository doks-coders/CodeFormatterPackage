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
	public class TestModule
    {
		public readonly FormatCode formatCode;
		public TestModule()
		{
			formatCode = new FormatCode();
		}

		public static async Task Main(string[] args)
		{
			var code =  new TestModule();
			code.formatCode.FormatCodeFile("Test",children:true);
			
		}
	}
}


