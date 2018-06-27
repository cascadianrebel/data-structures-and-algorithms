using System;
using Xunit;
using Stack_and_Queue;


namespace XUnitTestStackQueue
{
    public class UnitTest1 
    {

        /// <summary>
        /// The stack can be created
        /// </summary>
        [Fact]
        public void CanCreateStack()
        {
            Node testNode = new Node(3);

            Stack testStack = new Stack(testNode);

            Assert.NotNull(testStack);
        }

        /// <summary>
        /// the stack can have nodes added
        /// </summary>
        [Fact]
        public void CanPushToStack()
        {
            Node testNode = new Node(3);
            Stack testStack = new Stack(testNode);
            

            Node testNode2 = new Node(5);
            Node testNode3 = new Node(7);
            Node testNode4 = new Node(9);
            Node testNode5 = new Node(11);

            testStack.Push(testNode2);
            testStack.Push(testNode3);
            testStack.Push(testNode4);
            testStack.Push(testNode5);

            Assert.Equal(testStack.Peek(), testNode5);
        }
        /// <summary>
        /// the stack can have nodes removed
        /// </summary>
        [Fact]
        public void CanPopFromStack()
        {
            Node testNode = new Node(3);
            Stack testStack = new Stack(testNode);


            Node testNode2 = new Node(5);
            Node testNode3 = new Node(7);
            Node testNode4 = new Node(9);
            Node testNode5 = new Node(11);

            testStack.Push(testNode2);
            testStack.Push(testNode3);
            testStack.Push(testNode4);
            testStack.Push(testNode5);

            Assert.Equal(testStack.Pop(), testNode5);
        }

        /// <summary>
        /// a node can be added to the queue
        /// </summary>
        [Fact]
        public void CanEnqueueNode()
        {
            Node testNode = new Node(3);
            Queue testQueue = new Queue(testNode);


            Node testNode2 = new Node(5);
            Node testNode3 = new Node(7);
            Node testNode4 = new Node(9);
            Node testNode5 = new Node(11);

            testQueue.Enqueue(testNode2);
            testQueue.Enqueue(testNode3);
            testQueue.Enqueue(testNode4);
            testQueue.Enqueue(testNode5);

            Assert.Equal(testQueue.Rear, testNode5);
        }

        /// <summary>
        /// a node can be removed from the queue
        /// </summary>
        [Fact]
        public void CanDequeueNode()
        {
            Node testNode = new Node(3);
            Queue testQueue = new Queue(testNode);


            Node testNode2 = new Node(5);
            Node testNode3 = new Node(7);
            Node testNode4 = new Node(9);
            Node testNode5 = new Node(11);

            testQueue.Enqueue(testNode2);
            testQueue.Enqueue(testNode3);
            testQueue.Enqueue(testNode4);
            testQueue.Enqueue(testNode5);

            testQueue.Dequeue();

            Assert.Equal(testQueue.Front, testNode2);

        }

        /// <summary>
        /// front of the queue can be viewed
        /// </summary>
        [Fact]
        public void CanPeekQueue()
        {
            Node testNode = new Node(3);
            Queue testQueue = new Queue(testNode);


            Node testNode2 = new Node(5);
            Node testNode3 = new Node(7);
            Node testNode4 = new Node(9);
            Node testNode5 = new Node(11);

            testQueue.Enqueue(testNode2);
            testQueue.Enqueue(testNode3);
            testQueue.Enqueue(testNode4);
            testQueue.Enqueue(testNode5);

            Assert.Equal(testQueue.Peek(), testNode);
        }
    }
}
