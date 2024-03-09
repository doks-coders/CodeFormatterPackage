  using System; 
  using System.Collections.Generic; 
  using System.Linq; 
  using System.Text; 
  using System.Threading.Tasks; 
  
  namespace CodeFormatterModule 
  { 
      public class Utilities 
      { 
          #region GetFormattedCode 
          public string GetFormattedCode(string codePage) 
          { 
              string[] str = codePage. Split('\n'); 
              int level = 0; 
              string formattedString = ""; 
              foreach (string s in str) 
              { 
              
                  if ((s.Trim().IndexOf("}") > -1 && s.Trim().Length == 1) 
                  || 
                  s.Trim().IndexOf("}") == s.Trim().Length - 1) 
                  { 
                      level--; 
                  } 
              
                  formattedString += $" {GetSpaces(4 * level)}{SetLineWithEqualSpacing(s)} \n"; 
              
              
                  if ((s.Trim().IndexOf("{") > -1 && s.Trim().Length == 1) 
                  || 
                  s.Trim().IndexOf("{") == s.Trim().Length - 1) 
                  { 
                      level++; 
                  } 
              } 
              return formattedString; 
          } 
          #endregion 
      
          #region GetSpaces 
          public string GetSpaces(int spaces) 
          { 
              if (spaces > 0) 
              { 
                  string emptySpace = ""; 
                  Enumerable.Range(0, spaces).ToList().ForEach(x => 
                  { 
                      emptySpace += " "; 
                      }); 
                      return emptySpace; 
                  } 
                  return ""; 
              } 
              #endregion 
          
              #region Set Equal Spaces 
              public string SetLineWithEqualSpacing(string line) 
              { 
                  string[] lineArray = line.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries); 
                  int foundItem = 0; 
                  string itemsFound = ""; 
                  int intialSpacesFound = 0; 
                  for (int i = 0; i < lineArray.Length; i++) 
                  { 
                      lineArray[i] = lineArray[i].Trim(); 
                      if (foundItem < 1) 
                      { 
                          intialSpacesFound++; 
                      } 
                      var res = IsLetter(lineArray[i]); 
                      if (res) 
                      { 
                          foundItem++; 
                          if (foundItem > 0) 
                          { 
                              itemsFound += " "; 
                          } 
                          itemsFound += lineArray[i]; 
                      } 
                  } 
                  return itemsFound; 
              } 
              #endregion 
          
              #region IsLetter 
              public bool IsLetter(string s) 
              { 
                  if (string.IsNullOrEmpty(s)) 
                  { 
                      return false; 
                  } 
                  return true; 
              
              
              } 
              #endregion 
          } 
      } 
  
  
  
  
