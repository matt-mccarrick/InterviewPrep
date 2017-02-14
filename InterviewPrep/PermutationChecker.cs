using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    public class PermutationChecker 
    {
        //check that there are two of every character
        //other way to do it would be to sort each string alphabetically, then check them char by char
        public bool IsPermutation(string input1,  string input2)
        {
            if (input1.Length != input2.Length)
                return false;
            var hash = new Dictionary<char, int>();
            for (int i = 0; i < input1.Length; i++)
            {
                if(hash.ContainsKey(input1[i]))
                    hash[input1[i]]++;
                else
                    hash.Add(input1[i], 1);
                if (hash.ContainsKey(input2[i]))
                    hash[input2[i]]++;
                else
                    hash.Add(input2[i], 1);
            }
            return hash.Keys.All(key => hash[key]%2 == 0);
        } 
    }
}
