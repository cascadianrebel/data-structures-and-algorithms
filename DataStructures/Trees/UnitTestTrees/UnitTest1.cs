using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTrees
{
    [TestClass]
    public class UnitTest1
    {
        // 1. Add node to BST
        // 2. Find node in BST
        // 3. find node in BT
        [Fact]
        public void CanAddToBSTree()
        {

            binarySearch.Add(treeRoot, new Node(3));
            binarySearch.Add(treeRoot, new Node(5));
            binarySearch.Add(treeRoot, new Node(9));
            binarySearch.Add(treeRoot, new Node(10));
            binarySearch.Add(treeRoot, new Node(15));
            binarySearch.Add(treeRoot, new Node(17));
        }
    }
}
