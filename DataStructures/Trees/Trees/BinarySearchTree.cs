using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    public class BinarySearchTree : BinaryTree
    {
        
        
        /// <summary>
        /// overrides the method from the BinaryTree's search and returns the node requested
        /// </summary>
        /// <param name="root">root node</param>
        /// <param name="value"> number value of requested node</param>
        /// <returns>requested node</returns>
        public override Node Search(Node root, int value)
        {
            while (root != null)
            {
                if (value == root.Value)
                {
                    return root;
                }
                if (value < root.Value)
                {
                    return Search(root.LeftChild, value);
                }
                if (value > root.Value)
                {
                    return Search(root.RightChild, value);
                }
            }
            return null;
        }

        /// <summary>
        /// overrides the method from BinaryTree.cs to add a node to the tree in a specific placement
        /// </summary>
        /// <param name="root">root node</param>
        /// <param name="node">new node to be added</param>
        public override void Add(Node root, Node node)
        {
            Console.WriteLine("hit add function bst");
            if (root.Value == node.Value)
            {
                root = new Node(node.Value);
            }
            if (root.Value > node.Value)
            {
                if (root.LeftChild == null)
                {
                    root.LeftChild = node;
                }
                Add(root.LeftChild, node);
            }
            if (root.Value < node.Value)
            {
                if (root.RightChild == null)
                {
                    root.RightChild = node;
                }
                Add(root.RightChild, node);
            }

        }
    }
}
