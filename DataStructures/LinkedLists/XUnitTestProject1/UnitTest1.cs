using System;
using Xunit;
using LinkedLists;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddNode()
        {
            //Arrange
            LinkLists ll = new LinkList(new Node(4));
            Node node = new Node(8);
            Node node2 = new Node(15);

            //Act
            ll.Add(node);
            ll.Add(node2);

            //Assert
            Assert.Equal(ll.Head.Value, node2.Value);
        }
    }
}
