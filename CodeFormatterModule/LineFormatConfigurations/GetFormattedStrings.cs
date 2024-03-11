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
     
        /// <summary> 
        /// The each line is parsed using these sequence of methods 
        /// </summary> 
     
        #region FormattedStringSequence 
        public void FormattedStringSequence() 
        { 
            //Level 1 
            formattedStrings = SetLineWithEqualSpacing(formattedStrings); 
         
            //Level 2 
            formattedStrings = GetDotJoinedString(formattedStrings); 
         
            //Other levels go here 
        } 
        #endregion 
    } 
} 
 
 
 
 
 
 
 
 
