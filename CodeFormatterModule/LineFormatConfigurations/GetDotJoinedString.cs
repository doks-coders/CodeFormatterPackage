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
         #region GetDotJoinedString 
         public string GetDotJoinedString(string demoString) 
         { 
             string[] demoArray = demoString.Split(" ", StringSplitOptions.RemoveEmptyEntries); 
          
             var demoList = demoArray.ToList(); 
             var dotIndex = demoList.IndexOf("."); 
          
              var dotStart = demoList.FindIndex(e => Regex.IsMatch(e, "^\\.")); //abc. 
             var dotEnd = demoList.FindIndex(e => Regex.IsMatch(e, "\\.$"));//.abc 
          
             if (dotIndex == -1 && dotStart == -1 && dotEnd == -1) 
             { 
                 return demoString.Trim(); 
             } 
             if (dotIndex > -1) 
             { 
                 if ((dotIndex + 1) <= demoList.Count() - 1) 
                 { 
                     string a = ""; string b = ""; string c = ""; 
                     (a, b, c) = (demoList[dotIndex - 1], demoList[dotIndex], demoList[dotIndex + 1]); 
                     demoList.RemoveRange(dotIndex - 1, 3); 
                     demoList.Insert(dotIndex - 1, (a + b + c)); 
                     string item = string.Join(" ", demoList); 
                     return GetDotJoinedString(item); 
                 } 
             } 
          
          
             if (dotEnd > -1) 
             { 
                 if ((dotEnd + 1) <= demoList.Count() - 1) 
                 { 
                     string a = ""; string b = ""; 
                     (a, b) = (demoList[dotEnd], demoList[dotEnd + 1]); 
                     demoList.RemoveRange(dotEnd, 2); 
                     demoList.Insert(dotEnd, (a + b)); 
                     string item = string.Join(" ", demoList); 
                     return GetDotJoinedString(item); 
                 } 
             } 
          
             if (dotStart > -1) 
             { 
                 string a = ""; string b = ""; 
                 (a, b) = (demoList[dotStart - 1], demoList[dotStart]); 
                 demoList.RemoveRange(dotStart - 1, 2); 
                 demoList.Insert(dotStart - 1, (a + b)); 
                 string item = string.Join(" ", demoList); 
                 return GetDotJoinedString(item); 
             } 
          
             return demoString; 
          
         } 
         #endregion 
      
     } 
 } 
  
