using System;

namespace Stack_and_Queue
{
    class Program
    {
        static void Main(string[] args)
        {

            Node exampleNode = new Node(3);
            Node exampleNode2 = new Node(5);
            Node exampleNode3 = new Node(7);
            Node exampleNode4 = new Node(9);
            Node exampleNode5 = new Node(11);
            Stack exampleStack = new Stack(exampleNode);
            Console.WriteLine($"Stack Created  {exampleNode5.Value}-> {exampleNode4.Value} -> {exampleNode3.Value} -> {exampleNode2.Value} -> {exampleNode.Value}");

            exampleStack.Push(exampleNode2);
            exampleStack.Push(exampleNode3);
            exampleStack.Push(exampleNode4);
            exampleStack.Push(exampleNode5);

            Console.WriteLine("Press enter to display the stack's top node value");
            Console.ReadLine();
            Console.WriteLine(exampleStack.Peek().Value);
            Console.WriteLine("Press enter to remove and return the stack's top node");
            Console.ReadLine();
            
            Console.WriteLine($"{exampleStack.Pop().Value} was removed. The new top node in the stack is {exampleStack.Peek().Value}");
            Console.ReadLine();
            Console.WriteLine("Press enter to create a Queue");
            Console.ReadLine();

            
            Queue exampleQueue = new Queue(exampleNode);


            exampleQueue.Enqueue(exampleNode2);
            exampleQueue.Enqueue(exampleNode3);
            exampleQueue.Enqueue(exampleNode4);
            exampleQueue.Enqueue(exampleNode5);

            Console.WriteLine($"Queue Created  {exampleNode.Value}-> {exampleNode2.Value} -> {exampleNode3.Value} -> {exampleNode4.Value} -> {exampleNode5.Value}");

            Console.WriteLine("Press enter to display the Queue's front node value");
            Console.ReadLine();
            Console.WriteLine($"{exampleQueue.Peek().Value}");
            Console.WriteLine("Press enter to remove and return the Queue's front node");
            Console.ReadLine();
            
            Console.WriteLine($"{exampleQueue.Dequeue().Value} was removed. The new front node in the stack is {exampleQueue.Peek().Value}");
                       

        }

        
    }
}
