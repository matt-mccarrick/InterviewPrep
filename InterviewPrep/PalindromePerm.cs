using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    public class PalindromePerm
    {
        //Write an efficient function that checks whether any permutation ↴ of an input string is a palindrome ↴ .
        //Examples:

        //"civic" should return true
        //"ivicc" should return true
        //"civil" should return false
        //"livci" should return false
        public bool isPalindrome(string input)
        {
            //palindromes can't have more than one odd number of letters. We'll use that to our advantage keeping count of occurrences of a letter
            var charCountDictionary = new Dictionary<char, int>();
            var numberOfCharactersWithOddFrequency = 0;
            foreach(var character in input)
            {
                //increment the count for the character
                charCountDictionary[character]++;
            }
            foreach(var character in charCountDictionary.Keys)
            {
                //Is the frequency of this character odd?
                if (charCountDictionary[character] % 2 != 0)
                    numberOfCharactersWithOddFrequency++;
            }
            //We can only allow one character with an odd frequency ie: "12121" 1 has frequency of 3, 2 has frequency of 2
            return numberOfCharactersWithOddFrequency>1;

            //Runs in O(n) time with O(1) space

        }
    }
}
