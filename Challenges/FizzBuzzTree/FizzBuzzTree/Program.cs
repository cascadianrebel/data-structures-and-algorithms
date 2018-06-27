using System;

namespace FizzBuzzTreeChallenge
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Fizz Buzz Tree!");
            Node initialNode = new Node("1");
            Tree FBTree = new Tree();
            FBTree.Add(initialNode, new Node("5"));
            FBTree.Add(initialNode, new Node("7"));
            FBTree.Add(initialNode, new Node("6"));
            FBTree.Add(initialNode, new Node("2"));
            FBTree.Add(initialNode, new Node("15"));
            FBTree.Add(initialNode, new Node("11"));

            FizzBuzzTree(initialNode);
        }

        public static Node FizzBuzzTree (Node root)
        {
           int rootInt = Convert.ToInt32(root.Value);

            if (rootInt %5 == 0 && rootInt %3 == 0)
            {
                root.Value = "FizzBuzz";
            }
            else if (rootInt %5 == 0)
            {
                root.Value = "Buzz";
            }
            else if (rootInt %3 == 0)
            {
                root.Value = "Fizz";
            }
            if (root.LeftChild != null)
            {
                FizzBuzzTree(root.LeftChild);
            }
            if (root.RightChild != null)
            {
                FizzBuzzTree(root.RightChild);
            }
            return root;
        }
    }
}
