using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    public class BSNode
    {
        public BSNode(int nodeValue)
        {
            NodeValue = nodeValue;
        }

        public BSNode Left { get; set; }
        public BSNode Right { get; set; }
        public int NodeValue { get; set; }

        public void Insert(int value)
        {
            if (NodeValue < value)
            {
                if (Left == null)
                    Left = new BSNode(value);
                else
                    Left.Insert(value);
            }
            else if (NodeValue > value)
            {
                if(Right == null)
                    Right = new BSNode(value);
                else
                    Right.Insert(value);
            }
        }

    }

    public class BSTree
    {
        public BSNode Root { get; set; }

        public void Insert(int value)
        {
            if (Root == null)
                Root = new BSNode(value);
            else
                Root.Insert(value);   
            
        }

        public int FindSecondLargestElement()
        {
            var currentNode = Root;
            BSNode parentNode = null;
            while (currentNode.Right != null)
            {
                parentNode = currentNode;
                currentNode = currentNode.Right;
            }
            //we're at the largest node being the current node
            //check if there's a left node.  If so, find the rightmost node on the left branch
            if (currentNode.Left != null)
            {
                currentNode = currentNode.Left;
                while (currentNode.Right != null)
                {
                    parentNode = currentNode;
                    currentNode = currentNode.Right;
                }
            }          
           return parentNode.NodeValue;
        }

        public int FindDeepestLeaf(BSNode startingNode, int startingDepth = 0)
        {
            int deepest = startingDepth;
            if (startingNode.Left == null && startingNode.Right == null)
            {
                deepest = startingDepth;
            }
            if (startingNode.Left != null)
            {
                deepest = FindDeepestLeaf(startingNode.Left, startingDepth + 1);
            }
            else if (startingNode.Right != null)
            {
                deepest = FindDeepestLeaf(startingNode.Right, startingDepth + 1);
            }
            return deepest;
        }
    }
}
