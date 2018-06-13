using System;


namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            TestLL();

        }
        static void TestLL()
        {
           LinkList ll = new LinkList(new Node(10));

            ll.Add(new Node(15));
            ll.Add(new Node(20));

            ll.Print();

            //20 -> 15 -> 10
        }
    }
}
