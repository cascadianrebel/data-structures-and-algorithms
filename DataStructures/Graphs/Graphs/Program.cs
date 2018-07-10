using System;
using System.Collections.Generic;
using Graphs;

namespace Graphs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CreateGraph();
            Console.ReadLine();
        }

        public static void CreateGraph()
        {
            Node root = new Node("1");
            Node node2 = new Node("2");
            Node node3 = new Node("3");
            Node node4 = new Node("4");
            Node node5 = new Node("5");

            Graph graph = new Graph(root);
            graph.AddEdge(root, node2);

            Console.WriteLine($"Created Graph with two vertices that share an edge: {root.Value} and {node2.Value}");

            graph.AddEdge(root, node3);

            Console.WriteLine($"Added additional Node, {node3.Value}, that shares also shares an edge with {root.Value}");

            Console.WriteLine($"The root vertex has the following neighbors:");

            foreach(var vertex in graph.GetNeighbors(root))
            {
                Console.Write($" {vertex.Value}");
            }

            graph.AddEdge(node2, node3);
            graph.AddEdge(node3, node4);
            graph.AddEdge(node2, node4);
            graph.AddEdge(node4, node5);

            Console.WriteLine($"The following nodes were added to the graph: {node4.Value}, {node5.Value}. {node4.Value} shares edges with");

            foreach (var vertex in graph.GetNeighbors(node4))
            {
                Console.Write($" {vertex.Value}");
            }

            Console.WriteLine($"and {node5.Value} shares edges with:");
            foreach (var vertex in graph.GetNeighbors(node5))
            {
                Console.Write($" {vertex.Value}");
            }

            Console.WriteLine($"The Graph now has {graph.Size()} nodes. Using the BreadthFirst Traversal, the order is :");

            foreach (var vertex in graph.BreadthFirst(root))
            {
                Console.Write($" {vertex.Value}");
            }

            Console.ReadLine();
        }
    }
}
