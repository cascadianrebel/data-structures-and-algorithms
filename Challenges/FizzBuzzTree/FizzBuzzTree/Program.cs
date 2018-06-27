using System;

namespace FizzBuzzTreeChallenge
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Fizz Buzz Tree!");
            FizzBuzzTree();
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
