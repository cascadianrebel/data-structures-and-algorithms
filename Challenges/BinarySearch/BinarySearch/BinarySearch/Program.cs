using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] givenArr = new int[] { 1,3,5,7,11,13,17,23};
            int searchKey = 17;
            BinarySearchApp( givenArr, searchKey);
        }
        
        static int BinarySearchApp( int[] givenArr , int searchKey)
        {
            int start = 0;
            int end = givenArr.Length - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                Console.WriteLine($"between {start} and {end} is {mid}. The SearchKey is {searchKey}");
                if (searchKey == givenArr[mid])
                {
                    return mid;
                }
                else if (searchKey < givenArr[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return -1;
        }
    }
}
