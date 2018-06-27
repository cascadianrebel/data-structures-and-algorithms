using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_and_Queue
{
    public class Node
    {
        /// <summary>
        /// creates properties of Value and Next
        /// </summary>
        public int Value { get; set; }
        public Node Next { get; set; }

        /// <summary>
        /// node constructor
        /// </summary>
        /// <param name="value">the node's value</param>
        public Node (int value)
        {
            Value = value;
        }

    }
}
