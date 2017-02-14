using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.LinkedLists
{
    public class KthToLast
    {
        public LNode ReturnKthToLast(LNode head, int k)
        {
            int counter = 0;
            var runner = head;
            while (runner != null)
            {
                if (counter == k)
                {
                    head = head.Next;
                }
                else
                {
                    counter ++;
                }
                runner = runner.Next;
            }
            return head;
        }
    }
}
