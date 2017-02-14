using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.LinkedLists
{
    public class RemoveDupes
    {
        //Remove duplicates from a linked list
        public void RemoveDuplicates(LNode head)
        {
            //we're going to do this without a buffer. Slower in execution speed, lighter in memory (also maybe harder to do). If we used a buffer, we could just keep a hashset and check if the thing already exists
            while (head.Next != null)
            {
                //need to keep track of the previous record so we can remove the node.  Starting off, the previous node is the head
                var runner = head.Next;
                var previous = head;
                while (runner.Next != null)
                {

                    if (runner.Value == head.Value)
                    {
                        previous.Next = runner.Next;
                    }
                    previous = previous.Next;
                    runner = previous.Next;
                }
                head = head.Next;
            }
        }
    }
}
