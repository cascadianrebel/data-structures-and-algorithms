using System;


namespace Trees
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
            //declare and define the tree root for both
            Node treeRoot = new Node(20);

            //create new Binary Search Tree
            BinarySearchTree binarySearch = new BinarySearchTree();

            //create new binary tree
            BinaryTree biTree = new BinaryTree();

            //add to binary search tree
            Console.WriteLine("adding some nodes to binary search tree");
            binarySearch.Add(treeRoot, new Node(17));
            binarySearch.Add(treeRoot, new Node(15));
            binarySearch.Add(treeRoot, new Node(10));
            binarySearch.Add(treeRoot, new Node(9));
            binarySearch.Add(treeRoot, new Node(5));
            binarySearch.Add(treeRoot, new Node(3));

            //add to binary tree
            Console.WriteLine("adding some nodes to binary tree");
            biTree.Add(treeRoot, new Node(3));
            biTree.Add(treeRoot, new Node(5));
            biTree.Add(treeRoot, new Node(9));
            biTree.Add(treeRoot, new Node(10));
            biTree.Add(treeRoot, new Node(15));
            biTree.Add(treeRoot, new Node(17));

            // expected output 20, 3, 5, 9, 10, 15, 17
            binarySearch.PreOrder(treeRoot);
            biTree.PreOrder(treeRoot);


            // expected output 
            biTree.InOrder(treeRoot);

            // expected output
            biTree.PostOrder(treeRoot);

            // expected output
            biTree.BreadthFirst(treeRoot);

        }

    }
}
