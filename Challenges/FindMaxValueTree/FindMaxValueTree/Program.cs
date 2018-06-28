using System;
using System.Collections.Generic;

namespace FindMaxValueTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node rootNode = new Node(2);
            BinaryTree biTree = new BinaryTree(rootNode);

            biTree.Root.LeftChild = new Node(7);

            biTree.Root.RightChild = new Node(5);

            biTree.Root.LeftChild.LeftChild = new Node(2);
            biTree.Root.LeftChild.RightChild = new Node(6);
            biTree.Root.RightChild.RightChild = new Node(9);
            biTree.Root.LeftChild.LeftChild.LeftChild = new Node(5);
            biTree.Root.LeftChild.LeftChild.RightChild = new Node(11);
            biTree.Root.RightChild.RightChild.LeftChild = new Node(4);
            

            FindMax(rootNode);

        }

        public static int FindMax(Node root)
        {
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);
            int max = root.Value;
            while(breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();

                if (front.Value > max)
                {
                    max = front.Value;
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
            Console.WriteLine($"the max is {max}");
            return max;
        }

    }
}
