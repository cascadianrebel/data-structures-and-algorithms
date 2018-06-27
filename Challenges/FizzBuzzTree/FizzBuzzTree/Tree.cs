using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTreeChallenge
{
    public class Tree
    {
        public void Add(Node root, Node node)
        {

            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();

                if (front.LeftChild == null)
                {
                    front.LeftChild = node;
                }
                if (front.RightChild == null)
                {
                    front.RightChild = node;
                }
                if (front.LeftChild != null)
                {
                    breadth.Enqueue(front.LeftChild);
                }
                if (front.RightChild != null)
                {
                    breadth.Enqueue(front.RightChild);
                }
            }
        }
        /// <summary>
        /// root first ordering. Output will be the nodes left to right starting at the root node
        /// </summary>
        /// <param name="node"></param>
        public void PreOrder(Node node)
        {
            Console.WriteLine(node.Value);

            if (node.LeftChild != null)
            {
                PreOrder(node.LeftChild);
            }

            if (node.RightChild != null)
            {
                PreOrder(node.RightChild);
            }
        }

    }
}
