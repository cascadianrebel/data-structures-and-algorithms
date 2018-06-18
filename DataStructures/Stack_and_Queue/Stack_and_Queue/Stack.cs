using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_and_Queue
{
    class Stack
    {
        // create the Top node property
        public Node Top { get; set; }

        //Constructor to guarantee that at least one node exists in the list
        public void InitialStack(Node node)
        {
            Top = node;
        }

        // add node to stack
        public void Push(Node node)
        {
            node.Next = Top;
            Top = node;
        }
        // removes and returns top node to stack
        public Node Pop()
        {
            Node temp = Top;
            Top = Top.Next;
            temp.Next = null;
            return temp;
        }
        // returns the top node on the stack
        public Node Peek()
        {
            return Top;
        }
    }
}
