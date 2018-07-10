using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public class Node
    {
        

        /// <summary>
        /// creates properties Value, Children, and Visitied
        /// </summary>
        public string Value { get; set; }
        public List<Node> Children { get; set; }
        public virtual bool Visited { get; set; }

        /// <summary>
        /// node constructor
        /// </summary>
        /// <param name="value">the node's value</param>
        public Node(string value)
        {
            Value = value;
            Visited = false;
            Children = new List<Node>();
        }

    }
}
