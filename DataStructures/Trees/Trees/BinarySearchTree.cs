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
        /// <param name="NewNode">new node to be added</param>
        public void AddToBST(Node root, Node NewNode)
        {
            if (Root == null)
            {
                Root = NewNode;
                Console.WriteLine("adding new node");
            }
            if (root.Value > NewNode.Value)
            {
                if (root.LeftChild == null)
                {
                    root.LeftChild = NewNode;
                }
                AddToBST(root.LeftChild, NewNode);
            }
            if (root.Value < NewNode.Value)
            {
                if (root.RightChild == null)
                {
                    root.RightChild = NewNode;
                }
                AddToBST(root.RightChild, NewNode);
            }

        }
    }
}
