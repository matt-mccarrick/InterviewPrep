using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    public class StringPatternChecker
    {
        //given a pattern in the format of [1,2,2,1] see if a string follows that pattern, ie: "cat dog dog cat"

        public bool isPatternMatch(int[] pattern, string stringInput)
        {
            //dictionary keeps track of string->pattern mapping
            var patternDict = new Dictionary<string, int>();
            //get string as array of words
            var words = stringInput.Split(' ');
            if (words.Length != pattern.Length)
                return false;
            for(int i=0; i<words.Length; i++)
            {
                //if the word's already in the dictionary, make sure it matches with the pattern
                if (patternDict.ContainsKey(words[i]))
                {
                    //does the pattern mapping for the word at this index match the expected value given in the pattern at this index?
                    if (patternDict[words[i]] != pattern[i])
                        return false;
                }
                //otherwise add it to the dictionary
                else
                {
                    patternDict[words[i]] = pattern[i];
                }
            }
            return true;
        }
    }
}
