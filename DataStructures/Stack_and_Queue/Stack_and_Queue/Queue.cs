using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_and_Queue
{
    public class Queue
    {
        //create the Front and Rear node properties
        public Node Front { get; set; }
        public Node Rear { get; set; }

        //Constructor to guarantee that you have at least one node starting out. 
        public Queue(Node node)
        {
            Front = node;
            Rear = Front;
        }

        //add node to the queue
        public void Enqueue(Node node)
        {
            Rear.Next = node;
            Rear = node;
        }
        // remove and return the front node of the queue
        public Node Dequeue()
        {
            Node temp = Front;
            Front = Front.Next;
            temp.Next = null;

            return temp;
        }
        // return the front node of the queue
        public Node Peek()
        {
            return Front;
        }
    }
}
