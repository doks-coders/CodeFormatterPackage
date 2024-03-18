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
	internal static class TestModule
    {
		internal static async Task Main(string[] args)
		{
			FormatCode formatCode = new();
			formatCode.FormatCodeFile("Test", children:true);
		}
	}
}