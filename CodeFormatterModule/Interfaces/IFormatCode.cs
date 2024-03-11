using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFormatterModule.Interfaces
{
	public interface IFormatCode
	{
		/// <summary>
		/// This is used formatting the file path
		/// </summary>
		/// <param name="path"></param>
		void FormatCodeFile(string? path);

		/// <summary>
		/// This is used formatting an array of paths
		/// </summary>
		/// <param name="paths"></param>
		void FormatCodeFile(string?[] paths);

		/// <summary>
		/// This is used for formatting whole directories
		/// </summary>
		/// <param name="fileDirectory"></param>
		/// <param name="children"></param>
		void FormatCodeFile(string? fileDirectory, bool children = true);
	}
}
