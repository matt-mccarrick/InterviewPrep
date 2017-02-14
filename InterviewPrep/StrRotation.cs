using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    public class StrRotation
    {
        //Given two strings determine whether "toCheck" is a rotation of "start"
        //example "blah" "ahbl" should output true
        public bool IsRotation(string start, string toCheck)
        {
            //if I double the string to check, it should have the base string ie "blah" and "ahbl": "blah" is a substring of "ahblahbl"
            var temp = toCheck + toCheck;
            return temp.Contains(start);
        }
    }
}
