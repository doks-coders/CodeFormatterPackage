 using System; 
 using System.Collections.Generic; 
 using System.Linq; 
 using System.Text; 
 using System.Text.RegularExpressions; 
 using System.Threading.Tasks; 
 
 namespace CodeFormatterModule.LineFormatConfigurations 
 { 
     internal partial class GetFormattedStrings 
     { 
         #region[Chatgpt Generated] 
         public string PutSpaceBetweenAllSpecialCharacters(string line) 
         { 
             string pattern = @"([\W_])"; 
         
             line = Regex.Replace(line, pattern, " $1 "); 
         
             return line; 
         } 
         #endregion 
     
     } 
 }