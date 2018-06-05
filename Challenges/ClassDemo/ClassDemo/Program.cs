using System;

namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine($"What is your favorite color");
            string color = Console.ReadLine();
            FavoriteColor(color);
        }
        static void FavoriteColor(string color)
        {
            Console.WriteLine($"Your favorite color is {color}");

        }
    }
}
