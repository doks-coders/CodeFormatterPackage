using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFormatterModule.LineFormatConfigurations
{
	internal partial class GetFormattedStrings
	{
		public string formattedStrings;
		public GetFormattedStrings(string s)
		{
			formattedStrings = s;
			FormattedStringSequence();
		}

		public void FormattedStringSequence()
		{
			formattedStrings = SetLineWithEqualSpacing(formattedStrings);

			formattedStrings = GetDotJoinedString(formattedStrings);
		}
	}
}
