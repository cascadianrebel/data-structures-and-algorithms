using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
     public class LinkList
    {
        //Declaring the Head property
        public Node Head { get; set; }

        //Declaring the Current Property
        public Node Current { get; set; }

        //the constructor setting the Head and Current Properties as nodes
        /// <summary>
        /// constructor making the Head and Current properties each a node. 
        /// </summary>
        /// <param name="node">a node object must be used in the paramaters</param>
        public LinkList(Node node)
        {
            //sets the first node as the Head and Current
            Head = node;
            Current = node;
        }

        //Adding a Node O(1)
        /// <summary>
        /// adds a new node
        /// </summary>
        /// <param name="node"> ensures that a node is being added</param>
        public void Add(Node node)
        {
            Current = Head;
            node.Next = Head;
            Head = node;
            Current = Head;
        }

        // Find a Node O(n)
        /// <summary>
        /// Finds a node with a specified value
        /// </summary>
        /// <param name="value">Value of the search</param>
        /// <returns>Node thqat contains the value</returns>
        public Node Find(int value)
        {
            Current = Head;
            while (Current.Next !=null)
            {
                if (Current.Value == value)
                {
                    return Current;
                }
                Current = Current.Next;
            }
            return Current.Value == value ? Current : null;
        }

        // Print out Nodes O(n)
        /// <summary>
        /// displays the "node tree" on the console
        /// </summary>
        public void Print()
        {
            Current = Head;

            while (Current.Next != null)
            {
                Console.Write($"{Current.Value}--> ");
                Current = Current.Next;
            }
            Console.Write($"{Current.Value} --> NULL  ");
        }

        // add before O(n)
        /// <summary>
        /// adds a node to a specific position within the list
        /// </summary>
        /// <param name="newNode">the node being added to the list</param>
        /// <param name="existingNode">the node for which the newNode will be placed in front of</param>
        /// 
        public void AddBefore(Node newNode, Node existingNode)
        {
            //Reset our current to the beginning of the linked list
            Current = Head;

            //edge case where the newNode is placed before the Head node
            if (Head.Value == existingNode.Value)
            {
                Add(newNode);
                return;
            }

            while (Current.Next != null)
            {
                if (Current.Next.Value == existingNode.Value)
                {
                    newNode.Next = existingNode;
                    Current.Next = newNode;
                    return;
                }
                Current = Current.Next;
            }
        }
        
        //add after O(n)
        /// <summary>
        /// Add a new node after the specified existing node
        /// </summary>
        /// <param name="newNode">the new node being added</param>
        /// <param name="existingNode">the exisiting node for which the new node will follow</param>
        public void AddAfter(Node newNode, Node existingNode) 
        {
            Current = Head;
            if(existingNode.Next == null) 
            {
                existingNode.Next = newNode;
            }

            while(Current.Next != null) 
            {
                if(Current.Value == existingNode.Value) 
                {
                    Add(newNode);
                    return;
                }
                Current= Current.Next;
            }

        }


        // add Last O(n)
        /// <summary>
        /// adds node to the end of the list
        /// </summary>
        /// <param name="newMode">the node being added</param>
        public void AddLast(Node newNode)
        {
            Current = Head;
            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = newNode;
        }

        

    }
}
