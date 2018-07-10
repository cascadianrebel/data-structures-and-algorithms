using Graphs;
using System;
using System.Collections.Generic;
using Xunit;

namespace GraphTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanCreateGraph()
        {
            Node test1 = new Node("1");
            Graph graph = new Graph(test1);

            Assert.Equal(1, graph.Size());
        }

        [Fact]
        public void CanAddToGraph()
        {
            Node test1 = new Node("1");
            Node test2 = new Node("2");
            Graph graph = new Graph(test1);
            graph.AddEdge(test1, test2);

            Assert.Equal(2, graph.Size());
        }

        [Fact]
        public void CanReturnGraph()
        {
            Node test1 = new Node("1");
            Node test2 = new Node("2");
            Graph graph = new Graph(test1);
            graph.AddEdge(test1, test2);

            Assert.IsType<List<Node>>(graph.GetNodes(test1));
        }


        [Fact]
        public void CanGetNeighbors()
        {

                Node root = new Node("1");
                Node node2 = new Node("2");
                Node node3 = new Node("3");
                Node node4 = new Node("4");
                Node node5 = new Node("5");

                Graph graph = new Graph(root);
                graph.AddEdge(root, node2);
                graph.AddEdge(root, node3);
                graph.AddEdge(node2, node3);
                graph.AddEdge(node3, node4);
                graph.AddEdge(node2, node4);
                graph.AddEdge(node4, node5);

            Assert.Equal("2", graph.GetNeighbors(root).Count.ToString());
        }

        [Fact]
        public void CanBreadthFirst()
        {

            Node root = new Node("1");
            Node node2 = new Node("2");
            Node node3 = new Node("3");
            Node node4 = new Node("4");
            Node node5 = new Node("5");

            Graph graph = new Graph(root);
            graph.AddEdge(root, node2);
            graph.AddEdge(root, node3);
            graph.AddEdge(node2, node3);
            graph.AddEdge(node3, node4);
            graph.AddEdge(node2, node4);
            graph.AddEdge(node4, node5);

            Assert.IsType<List<Node>>(graph.BreadthFirst(root));
            Assert.Equal(5, graph.Size());
        }

        [Fact]
        public void CanDepthFirst()
        {

            Node root = new Node("1");
            Node node2 = new Node("2");
            Node node3 = new Node("3");
            Node node4 = new Node("4");
            Node node5 = new Node("5");

            Graph graph = new Graph(root);
            graph.AddEdge(root, node2);
            graph.AddEdge(root, node3);
            graph.AddEdge(node2, node3);
            graph.AddEdge(node3, node4);
            graph.AddEdge(node2, node4);
            graph.AddEdge(node4, node5);

            Assert.Equal(5, graph.Size());
            Assert.IsType<List<Node>>(graph.DepthFirst(root));
        }
    }
}
