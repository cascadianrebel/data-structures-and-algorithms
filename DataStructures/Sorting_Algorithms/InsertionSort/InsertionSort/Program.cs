using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortAlgorithm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] exampleArr = { 51, 24, 34, 1, 90, 35, 38, 29 };
            
            Console.WriteLine("The following is an unsorted array: ");
            foreach( int i in exampleArr)
            {
                Console.Write($"{i} ");
            }
            InsertionSort1(exampleArr, exampleArr.Length-1);
            Console.WriteLine("press enter to sort");
            Console.ReadLine();

            Console.WriteLine("The following is the same array but sorted after using the InsertionSort Algorithm");
            foreach (int i in exampleArr)
            {
                Console.Write($"{i} ");
            }
            Console.Read();
        }
        /// <summary>
        /// Uses recursion to implement a sorting algorithm 
        /// </summary>
        /// <param name="array">the unsorted array</param>
        /// <param name="n">the last index position in the array</param>
        /// <returns>the sorted array</returns>
        public static int[] InsertionSort1(int[] arr, int n)
        {            
            if (n > 0)
            {
                InsertionSort1(arr, n - 1);
                int x = arr[n];
                int j = n - 1;
                while (j >= 0 && arr[j] > x)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = x;
            }

            return arr;
        }
    }
}
