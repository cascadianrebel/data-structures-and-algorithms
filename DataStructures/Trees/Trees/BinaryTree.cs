using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    public class BinaryTree
    {
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

        /// <summary>
        /// ordering from the left to the right until the root is reached, then right to left. 
        /// </summary>
        /// <param name="node"></param>
        public void InOrder(Node node)
        {
            if (node.LeftChild != null)
            {
                InOrder(node.LeftChild);
            }

            Console.WriteLine(node.Value);

            if (node.RightChild != null)
            {
                InOrder(node.RightChild);
            }
        }

        /// <summary>
        /// out puts the order which the tree can be deleted starting at the lowest level of nodes and moving upward not to delete a root node before all children are removed
        /// </summary>
        /// <param name="node"></param>
        public void PostOrder(Node node)
        {
            if (node.LeftChild != null)
            {
                PostOrder(node.LeftChild);
            }

            if (node.RightChild != null)
            {
                PostOrder(node.RightChild);
            }

            Console.WriteLine(node.Value);

        }
        /// <summary>
        /// leverages a queue to output the nodes from left to right starting at the root node traversing left to right then top down
        /// </summary>
        /// <param name="root"> the root node</param>
        public void BreadthFirst(Node root)
        {
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();
                Console.Write(front.Value);
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
        /// leverages the queue push the requested value to the front; this is a virtual method because the binary search tree is going to return a different value.
        /// </summary>
        /// <param name="root"> the root node</param>
        /// <param name="value"> the value of the requested node</param>
        /// <returns>the requested node</returns>        
        public virtual Node Search (Node root, int value)
        {
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();

                if (front.Value== value)
                {
                    return front;
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
            //when the value does not exist
            return null;
        }

        /// <summary>
        /// adds a node to the tree
        /// </summary>
        /// <param name="root">root node</param>
        /// <param name="node"> node to add</param>
        public virtual void Add(Node root, Node node)
        {
            Console.WriteLine("hit add node function");
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
    }

}
