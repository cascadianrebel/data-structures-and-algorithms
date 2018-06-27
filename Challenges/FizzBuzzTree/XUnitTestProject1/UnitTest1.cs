using FizzBuzzTreeChallenge;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]        
        public void FizzBuzzWorks()
        {
            Node initialNode = new Node("1");
            Tree FBTree = new Tree();
            FBTree.Add(initialNode, new Node("5"));

            //FBTree.Add(initialNode, new Node("7"));
            //FBTree.Add(initialNode, new Node("6"));
            //FBTree.Add(initialNode, new Node("2"));
            //FBTree.Add(initialNode, new Node("15"));
            //FBTree.Add(initialNode, new Node("11"));

            //Assert.Equal(("1","Buzz", "7", "Fizz", "2", "FizzBuzz", "11" ), FBTree.PreOrder(initialNode))
            Assert.Equal("Buzz", FBTree.
        }
    }
}
