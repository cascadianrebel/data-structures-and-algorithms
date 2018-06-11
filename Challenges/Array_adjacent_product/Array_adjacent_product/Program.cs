using System;

namespace Array_adjacent_product
{
    class Program
    {
        public static int[,] array2d = new int[,] 
            {
                {1,2,1},
                {2,4,2},
                {3,6,8},
                {7,8,1}
            };
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine($"My number is {LargestProduct}");

            LargestProduct(array2d);
        }

        public static int max = 0;


        static int LargestProduct(arr Array) 
        {for (i = 0; i < Array.GetLength(0); i++ )
            {
                for (k = 0; k < Array.Length(1); k++)
                {
                    if (Array[i,k]*Array[i, k+1] > max)
                    { int max = Array[i, k] * Array[i, k + 1};
                    if (Array[I]
                }
            }

            return maxProduct;
        }

    }
}
