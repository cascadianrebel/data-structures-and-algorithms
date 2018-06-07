using System;

namespace Largest_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[ , ] arr2D = new int[,] 
            {
                {1, 2, 1 },
                {2, 4, 2 },
                {3, 6, 8 },
                {7, 8, 1 }
            };
            int answer = LargestProduct(arr2D);
            Console.WriteLine($"The correct answer is 64. You returned {answer}");
        }


        public static int LargestProduct(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0)-2; i++)
            {
                for (int j = 0; j < arr.GetLength(1) - 2; j++)
                {

                        int product1 = arr[i, j] * arr[i, j + 1];

                        int product2 = arr[i, j] * arr[i + 1, j];

                        int product3 = arr[i, j] * arr[i + 1, j + 1];

                        Console.WriteLine($"this is product 1: {product1}");
                        Console.WriteLine($"this is product 2: {product2}");
                        Console.WriteLine($"this is product 3: {product3}");

                }
            }
            return 100;
        }
    }
}
