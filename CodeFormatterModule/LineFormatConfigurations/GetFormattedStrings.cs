 using System; 
 using System.Collections.Generic; 
 using System.Linq; 
 using System.Text; 
 using System.Threading.Tasks; 
 
 namespace CodeFormatterModule.LineFormatConfigurations; 
 
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
         //formattedStrings = PutSpaceBetweenAllSpecialCharacters(formattedStrings); 
     
         //Level 2 
         formattedStrings = SetLineWithEqualSpacing(formattedStrings); 
     
         //level 3 
         formattedStrings = GetDotJoinedString(formattedStrings); 
     
         //level 4 
         formattedStrings = RemoveSpacesBetweenBrackets(formattedStrings); 
     
         //level 5 
         formattedStrings = JoinLettersToBrackets(formattedStrings); 
     
         //Other levels go here 
     } 
     #endregion 
 }