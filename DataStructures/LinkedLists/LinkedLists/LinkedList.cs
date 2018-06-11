using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
    public class LinkedList
    {
        // add before O(n)
        public void AddBefore(Node newNode, Node existingNode)
        {
            //Reset our current to the beginning of the linked list
            Current = Head;

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
        // add after O(n)
        public void AddLast(Node newMode)
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
