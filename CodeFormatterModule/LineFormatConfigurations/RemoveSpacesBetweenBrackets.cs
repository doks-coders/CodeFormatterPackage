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
     
         public string RemoveSpacesBetweenBrackets(string line) 
         { 
         
             string pattern = @"\(\s+|\s+\)"; 
         
             line = Regex.Replace(line, pattern, m => m.Value.Trim()); 
         
             return line; 
         } 
     
     } 
 } 
 
 /* 
 
 string pattern = @"(\s+)(?=[^\(\)]*\))|(?<=[^\(\)]*\s)(\s+)"; 
 
 line = Regex.Replace(line, pattern, ""); 
 */