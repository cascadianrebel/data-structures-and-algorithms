using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] UnsortedArray = { 8, 6, 7, 5, 3, 0, 9 };

            Console.WriteLine("The unsorted array: ");
            foreach (var i in UnsortedArray)
            {
                Console.Write(i);
            }
            Console.Read();

            AlgoQuickSort(UnsortedArray, 0, UnsortedArray.Length-1);
            Console.WriteLine("The array sorted by quicksort: ");
            foreach (var i in UnsortedArray)
            {
                Console.Write(i);
            }
        }

        public static int Partition(int[] Uarray, int Lo, int Hi)
        {
            int pivot = Uarray[Lo];
            while (true)
            {
                while (Uarray[Lo] < pivot)
                {
                    Lo++;
                }
                while (Uarray[Hi] > pivot)
                {
                    Hi--;
                }
                if (Lo < Hi)
                {
                    if (Uarray[Lo] == Uarray[Hi])
                    {
                        return Hi;
                    }
                    int x = Uarray[Lo];
                    Uarray[Lo] = Uarray[Hi];
                    Uarray[Hi] = x;
                }
                else
                    return Hi;
            }
        }

        public static int[] AlgoQuickSort(int[] Uarray, int Lo, int Hi)
        {
            if (Lo < Hi)
            {
                int pivot = Partition(Uarray, Lo, Hi);
                if (pivot > 1)
                {
                    AlgoQuickSort(Uarray, Lo, pivot - 1);
                }
                if (pivot +1 < Hi)
                {
                    AlgoQuickSort(Uarray, pivot + 1, Hi);
                }
            }
            return Uarray;
        }
    }
}
