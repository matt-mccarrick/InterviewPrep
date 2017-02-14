using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    public class RecursiveStringPermutations
    {
        //Write a recursive function for generating all permutations of an input string. Return them as a set.
        //Don't worry about time or space complexity—if we wanted efficiency we'd write an iterative version.

        //To start, assume every character in the input string is unique.

        //Your function can have loops—it just needs to also be recursive.

        /*
         * Recursively call down on strings with length of one less than your current one.  Stop when you get strings of length = 1.  Return that as a set
         * Change order around of sets. Insert each smaller set returned at the beginning, end of your current substring
         * let that bubble up, returning all of those sets of substrings
         * --I think this is close, but maybe not quite there.
         */

        public List<string> FindAllPermutations(string input)
        {
            //might as well start with the one we know for sure
            var permutations = new List<string>() {input};
            
            
            
            return permutations;
        }

        public string GeneratePermutation(string input)
        {
            var newString = "";
            for (var i = 0; i < input.Length; i++)
            {
                newString += input[(i + 1) % input.Length];
            }
            return newString;
        }
    }
}
