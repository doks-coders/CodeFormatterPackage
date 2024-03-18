 using System; 
 using System.Collections.Generic; 
 using System.Linq; 
 using System.Text; 
 using System.Text.RegularExpressions; 
 using System.Threading.Tasks; 
 
 namespace CodeFormatterModule.LineFormatConfigurations; 
 
 internal partial class GetFormattedStrings 
 { 
     /// <summary> 
     /// This method joins the elements before and after "." to the ".".Example: Console.Write() => Console.Write() 
     /// </summary> 
     /// <param name="line"></param> 
     /// <returns></returns> 
     #region GetDotJoinedString 
     /* 
     public string GetDotJoinedString(string line) 
     { 
         string[] lineArray = line.Split(" ", StringSplitOptions.RemoveEmptyEntries); 
     
         var lineList = lineArray.ToList(); 
     
         var dotIndex = lineList.IndexOf("."); 
     
         var dotStart = lineList.FindIndex(e => Regex.IsMatch(e, "^\\.")); 
         var dotEnd = lineList.FindIndex(e => Regex.IsMatch(e, "\\.$")); 
     
         if(dotIndex == -1 && dotStart == -1 && dotEnd == -1) 
         { 
             return line.Trim(); 
         } 
         if(dotIndex > -1) 
         { 
             if((dotIndex + 1) <= lineList.Count() - 1) 
             { 
                 string a = ""; string b = ""; string c = ""; 
                 (a, b, c) = (lineList[dotIndex - 1], lineList[dotIndex], lineList[dotIndex + 1]); 
                 lineList.RemoveRange(dotIndex - 1, 3); 
                 lineList.Insert(dotIndex - 1, (a + b + c)); 
                 string item = string.Join(" ", lineList); 
                 return GetDotJoinedString(item); 
             } 
         } 
     
     
         if(dotEnd > -1) 
         { 
             if((dotEnd + 1) <= lineList.Count() - 1) 
             { 
                 string a = ""; string b = ""; 
                 (a, b) = (lineList[dotEnd], lineList[dotEnd + 1]); 
                 lineList.RemoveRange(dotEnd, 2); 
                 lineList.Insert(dotEnd, (a + b)); 
                 string item = string.Join(" ", lineList); 
                 return GetDotJoinedString(item); 
             } 
         } 
     
         if(dotStart > -1) 
         { 
             string a = ""; string b = ""; 
             (a, b) = (lineList[dotStart - 1], lineList[dotStart]); 
             lineList.RemoveRange(dotStart - 1, 2); 
             lineList.Insert(dotStart - 1, (a + b)); 
             string item = string.Join(" ", lineList); 
             return GetDotJoinedString(item); 
         } 
     
         return line; 
     
     } 
     */ 
 
     #endregion 
 
     public string GetDotJoinedString(string line) 
     { 
         string pattern = @"\s*(\.\s*)"; 
     
         // Replace extra whitespace with a single space 
         line = Regex.Replace(line, pattern, "."); 
         return line; 
     } 
 
 
 
 }