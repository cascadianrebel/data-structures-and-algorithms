using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public class Graph
    {
        public List<Node> Vertices { get; set; }

        public Graph(Node root)
        {
            Vertices = new List<Node>();
            Vertices.Add(root);
        }


        /// <summary>
        /// add new node to graph
        /// </summary>
        /// <param name="root">vertex for which the child will attach</param>
        /// <param name="child">new vertex</param>
        public void AddEdge(Node root, Node child)
        {
            child.Children.Add(root);
            root.Children.Add(child);

            if (!Vertices.Contains(root))
            {
                Vertices.Add(root);
            }
            if (!Vertices.Contains(child))
            {
                Vertices.Add(child);
            }
        }

        /// <summary>
        /// show all vertices
        /// </summary>
        /// <param name="root">the root node</param>
        /// <returns>list of nodes</returns>
        public List<Node> GetNodes(Node root)
        {
            return Vertices;
        }

        /// <summary>
        /// show all neighbors of root
        /// </summary>
        /// <param name="root">targetted vertex</param>
        /// <returns>list of all neighbors</returns>
        public List<Node> GetNeighbors(Node root)
        {
            
            return root.Children;
        }

        /// <summary>
        /// shows amount of vertices in graph
        /// </summary>
        /// <param name="root">root node</param>
        /// <returns>number of nodes in graph</returns>
        public int Size()
        {
            return Vertices.Count;
        }

        /// <summary>
        /// traverses graph by placing vertices in queue and then in a list after dequeuing
        /// </summary>
        /// <param name="root">root node</param>
        /// <returns> list of all nodes</returns>
        public List<Node> BreadthFirst(Node root)
        {
            List<Node> order = new List<Node>();
            Queue<Node> breadth = new Queue<Node>();
            root.Visited = true;
            breadth.Enqueue(root);

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();
                order.Add(front);

                foreach (Node child in front.Children)
                {
                    if (!child.Visited)
                    {
                        child.Visited = true;
                        breadth.Enqueue(child);
                    }
                }
            }
            return order;
        }

        public List<Node> DepthFirst(Node root)
        {
            List<Node> order = new List<Node>();
            Stack<Node> depth = new Stack<Node>();
            root.Visited = true;
            depth.Push(root);

            while (depth.TryPeek(out root))
            {
                Node top = depth.Pop();
                order.Add(top);

                foreach (Node child in top.Children)
                {
                    if (!child.Visited)
                    {
                        child.Visited = true;
                        depth.Push(child);
                    }
                }
            }
            return order;
        }

    }
}
