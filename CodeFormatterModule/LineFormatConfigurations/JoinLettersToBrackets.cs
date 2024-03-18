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
         public string JoinLettersToBrackets(string line) 
         { 
             string pattern = @"(\w+)\s*([\(\{\[])"; 
         
             line = Regex.Replace(line, pattern, "$1$2"); 
         
             return line; 
         } 
     
     } 
 }