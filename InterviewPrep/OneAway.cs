using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    public class OneAway
    {
        //See if one string is one change away from another string
        public bool IsOneAway(string str1, string str2)
        {
            //removal
            if(str1.Length + 1 == str2.Length)
                return IsInsertionOrRemoval(str2, str1);
            if(str1.Length -1  == str2.Length)
                return IsInsertionOrRemoval(str1, str2);
            if (str1.Length == str2.Length)
                return IsReplace(str1, str2);

            return false;
        }

        private bool IsInsertionOrRemoval(string str1, string str2)
        {
            //must have one difference in length, might not be helpful
            if (Math.Abs(str1.Length - str2.Length) != 1)
                return false;
            var str2Index = 0;
            var numAdjustments = 0;
            for (int str1Index = 0; str1Index < str1.Length; str1Index++)
            {
                if (str2Index < str2.Length)
                {
                    if (str1[str1Index] != str2[str2Index])
                    {
                        str2Index++;
                        numAdjustments++;
                    }
                    str2Index++;
                }
                else
                {
                    numAdjustments++;
                }
            }
            return numAdjustments <= 1;
        }

        private bool IsReplace(string str1, string str2)
        {
            //must have no difference in length, might not be helpful
            if (Math.Abs(str1.Length - str2.Length) != 0)
                return false;
            var numAdjustments = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    numAdjustments++;
                }
            }
            return numAdjustments <= 1;
        }
    }
}
