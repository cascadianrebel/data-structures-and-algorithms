using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_and_Queue
{
    public class Queue
    {
        
        /// <summary>
        /// Front and Rear node properties are created
        /// </summary>
        public Node Front { get; set; }
        public Node Rear { get; set; }

        /// <summary>
        /// Constructor to guarantee that you have at least one node starting out
        /// </summary>
        /// <param name="node"></param>
        public Queue(Node node)
        {
            Front = node;
            Rear = Front;
        }

        /// <summary>
        /// add node to the queue
        /// </summary>
        /// <param name="node">node to add to queue</param>
        public void Enqueue(Node node)
        {
            Rear.Next = node;
            Rear = node;
        }
        // remove and return the front node of the queue
        /// <summary>
        /// remove the front node of the queue
        /// </summary>
        /// <returns>the front node in the queue</returns>
        public Node Dequeue()
        {
            Node temp = Front;
            Front = Front.Next;
            temp.Next = null;

            return temp;
        }
        
        /// <summary>
        /// view the front node of the queue
        /// </summary>
        /// <returns></returns>
        public Node Peek()
        {
            return Front;
        }
    }
}
