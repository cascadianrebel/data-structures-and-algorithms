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
            BinarySearchTree BSTree = new BinarySearchTree();

            //create new binary tree
            BinaryTree biTree = new BinaryTree();

            //add to binary search tree
            Console.WriteLine("adding some nodes to binary search tree");
            BSTree.AddToBST(treeRoot, new Node(17));
            BSTree.AddToBST(treeRoot, new Node(15));
            BSTree.AddToBST(treeRoot, new Node(10));
            BSTree.AddToBST(treeRoot, new Node(9));
            BSTree.AddToBST(treeRoot, new Node(5));
            BSTree.AddToBST(treeRoot, new Node(3));

            //add to binary tree
            //Console.WriteLine("adding some nodes to binary tree");
            //biTree.AddToBT(treeRoot, new Node(3));
            //biTree.AddToBT(treeRoot, new Node(5));
            //biTree.AddToBT(treeRoot, new Node(9));
            //biTree.AddToBT(treeRoot, new Node(10));
            //biTree.AddToBT(treeRoot, new Node(15));
            //biTree.AddToBT(treeRoot, new Node(17));

            // expected output 20, 3, 5, 9, 10, 15, 17
            Console.WriteLine("Binary Search Tree- PreOrdered: ");
            BSTree.PreOrder(treeRoot);
            //biTree.PreOrder(treeRoot);


            // expected output 
            Console.WriteLine("Binary Search Tree- InOrdered: ");
            BSTree.InOrder(treeRoot);
            //biTree.InOrder(treeRoot);

            // expected output
            Console.WriteLine("Binary Search Tree- PostOrdered: ");
            BSTree.PostOrder(treeRoot);
            //biTree.PostOrder(treeRoot);

            // expected output
            Console.WriteLine("Binary Search Tree- BreadthFirst: ");
            BSTree.BreadthFirst(treeRoot);
            //biTree.BreadthFirst(treeRoot);

        }

    }
}
