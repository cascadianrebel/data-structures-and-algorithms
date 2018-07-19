using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree_intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public List<int> TreeIntersection( LinkedListNode<int> tree1, LinkedListNode<int> tree2)
        {
            HashSet<LinkedListNode<int>> hashtable = new HashSet<LinkedListNode<int>> { };
            List<int> Duplicates = new List<int> { };

            for(var i = 0; i < tree1.List.Count; i++)
            {
                hashtable.Add(tree1.List.FirstOrDefault(a => a.GetHashCode();
            }

            return Duplicates;
        }
    }
}
