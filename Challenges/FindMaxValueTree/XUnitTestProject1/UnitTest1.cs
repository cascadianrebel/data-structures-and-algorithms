using FindMaxValueTree;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void FindMaxWorks()
        {
            Node testRootNode = new Node(2);
            BinaryTree testBiTree = new BinaryTree(testRootNode);

            testBiTree.Root.LeftChild = new Node(7);
            testBiTree.Root.RightChild = new Node(5);
            testBiTree.Root.LeftChild.LeftChild = new Node(2);
            testBiTree.Root.LeftChild.RightChild = new Node(6);
            testBiTree.Root.RightChild.RightChild = new Node(9);
            testBiTree.Root.LeftChild.LeftChild.LeftChild = new Node(5);
            testBiTree.Root.LeftChild.LeftChild.RightChild = new Node(11);
            testBiTree.Root.RightChild.RightChild.LeftChild = new Node(4);

            Assert.Equal(11, Program.FindMax(testRootNode));


            Node testRootNode2 = new Node(12);
            BinaryTree biTree = new BinaryTree(testRootNode);

            biTree.Root.LeftChild = new Node(14);
            biTree.Root.RightChild = new Node(83);
            biTree.Root.LeftChild.LeftChild = new Node(11);
            biTree.Root.LeftChild.RightChild = new Node(17);
            biTree.Root.RightChild.RightChild = new Node(19);
            biTree.Root.LeftChild.LeftChild.LeftChild = new Node(50);
            biTree.Root.LeftChild.LeftChild.RightChild = new Node(0);
            biTree.Root.RightChild.RightChild.LeftChild = new Node(4);

            Assert.Equal(83, Program.FindMax(testRootNode));

            Node testRootNode3 = new Node(12);
            BinaryTree biTree2 = new BinaryTree(testRootNode);

            biTree2.Root.LeftChild = new Node(14);
            biTree2.Root.RightChild = new Node(-83);
            biTree2.Root.LeftChild.LeftChild = new Node(11);
            biTree2.Root.LeftChild.RightChild = new Node(17);
            biTree2.Root.RightChild.RightChild = new Node(19);
            biTree2.Root.LeftChild.LeftChild.LeftChild = new Node(50);
            biTree2.Root.LeftChild.LeftChild.RightChild = new Node(0);
            biTree2.Root.RightChild.RightChild.LeftChild = new Node(4);

            Assert.Equal(50, Program.FindMax(testRootNode));
        }
    }
}
