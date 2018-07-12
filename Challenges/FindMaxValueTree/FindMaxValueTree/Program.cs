using System;
using System.Collections.Generic;

namespace FindMaxValueTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Max Value Tree!");

            //create root node
            Node rootNode = new Node(2);
            //create tree with root node as parameter
            BinaryTree biTree = new BinaryTree(rootNode);
            //add nodes to the tree
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
            //create queue called breadth
            Queue<Node> breadth = new Queue<Node>();
            //add the root as the first and only node in the queue
            breadth.Enqueue(root);
            //create a max variable that will be updated inside the while loop
            int max = root.Value;
            //while the queue has nodes
            while(breadth.TryPeek(out root))
            {
                //dequeue the front
                Node front = breadth.Dequeue();
                //if the front is larger than the max, reassign max value
                if (front.Value > max)
                {
                    max = front.Value;
                }
                //continue adding nodes to the queue that will eventually move to the front
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
            //return the max value of the node with the highest value
            return max;
        }

    }
}
