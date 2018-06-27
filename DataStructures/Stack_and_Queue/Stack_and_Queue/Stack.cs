using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_and_Queue
{
    public class Stack
    {
        /// <summary>
        /// creates the top node property
        /// </summary>
        public Node Top { get; set; }

        /// <summary>
        /// construtor to guarantee that at least one node exists in the stack
        /// </summary>
        /// <param name="node">the first node in the stack</param>
        public Stack(Node node)
        {
            Top = node;
        }

       
        /// <summary>
        /// add a node to the stack
        /// </summary>
        /// <param name="node">node to add</param>
        public void Push(Node node)
        {
            node.Next = Top;
            Top = node;
        }

        /// <summary>
        /// removes top node off stack
        /// </summary>
        /// <returns>top node of stack</returns>
        public Node Pop()
        {
            Node temp = Top;
            Top = Top.Next;
            temp.Next = null;
            return temp;
        }

        /// <summary>
        /// view top node of stack
        /// </summary>
        /// <returns> the value of the top node of the stack</returns>
        public Node Peek()
        {
            return Top;
        }
    }
}
