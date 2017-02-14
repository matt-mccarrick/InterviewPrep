using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    public class UniqueCharacters
    {
        //See if a string has all unique characters, allowing use of an external data structure
        public bool HasUniqueCharactersExternalData(string input)
        {
            var hash = new HashSet<char>();
            if (string.IsNullOrEmpty(input)) return true;
            foreach (var c in input)
            {
                if (hash.Contains(c))
                    return false;

                hash.Add(c);
            }
            return true;
        }

        //See if a string has all unique characters, no external data structure
        public bool HasUniqueCharactersInPlace(string input)
        {
            if (string.IsNullOrEmpty(input)) return true;
            for (var i = 0; i < input.Length; i++)
            {
                var character = input[i];
                for (var j = i + 1; j < input.Length; j++)
                {
                    if (input[j] == character)
                        return false;
                }
            }
            return true;
        }
    }
}
