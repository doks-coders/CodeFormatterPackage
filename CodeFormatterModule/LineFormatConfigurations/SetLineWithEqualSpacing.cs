using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
 
namespace CodeFormatterModule.LineFormatConfigurations 
{ 
    internal partial class GetFormattedStrings 
    { 
     
        /// <summary> 
        /// This method makes the lines to have equal spaces in between characters
        /// </summary> 
        /// <param name="line"></param> 
        /// <returns></returns> 
        #region Set Equal Spaces 
        public string SetLineWithEqualSpacing(string line) 
        { 
            string[] lineArray = line.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries); 
            int foundItem = 0; 
            string itemsFound = ""; 
         
            for (int i = 0; i < lineArray.Length; i++) 
            { 
                lineArray[i] = lineArray[i].Trim(); 
             
                if (IsNotEmpty(lineArray[i])) 
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
     
        #region IsNotEmpty 
        public bool IsNotEmpty(string s) 
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
 
 
 
 
 
 
 
 
