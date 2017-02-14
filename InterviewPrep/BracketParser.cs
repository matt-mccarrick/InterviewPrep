using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    public class BracketParser
    {
        //Let's say:

        //'(', '{', '[' are called "openers."
        //')', '}', ']' are called "closers."
        //Write an efficient function that tells us whether or not an input string's openers and closers are properly nested.

        //Examples:

        //"{ [ ] ( ) }" should return true
        //"{ [ ( ] ) }" should return false
        //"{ [ }" should return false
        public bool IsNestedProperly(string bracketString)
        {
            var charStack = new Stack<char>();
            var bracketDictionary = new Dictionary<char, char>()
            {
                {'{','}'},
                {'(', ')'},
                {'[',']' }
            };
            var openers = bracketDictionary.Keys;
            var closers = bracketDictionary.Values;
            foreach (var character in bracketString)
            {
                if (openers.Contains(character))
                {
                    charStack.Push(character);
                }
                else if (closers.Contains(character))
                {
                    if (charStack.Count == 0 || bracketDictionary[charStack.Pop()] != character)
                    {
                        return false;
                    }
                }

            }
            return true;
        }
    }
}
