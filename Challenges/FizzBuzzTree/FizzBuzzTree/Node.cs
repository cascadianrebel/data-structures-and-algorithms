using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTreeChallenge
{
    public class Node
    {
        public string Value {get; set;}
        public Node RightChild { get; set; }
        public Node LeftChild { get; set; }

        public Node (string value)
        {
            Value = value;
        }
    }
}
