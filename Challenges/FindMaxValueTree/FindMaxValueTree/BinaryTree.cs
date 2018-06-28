using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxValueTree
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        public BinaryTree(Node root)
        {
            Root = root;
        }

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
            Console.WriteLine("node added");

        }
    }
}
