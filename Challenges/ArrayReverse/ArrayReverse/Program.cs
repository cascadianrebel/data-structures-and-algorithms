using System;

namespace ArrayReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayReverse();
        }

        public static int[] ArrayReverse()
        {
            int[] givenArr = new int[] { 7, 6, 5, 4, 3, 2, 1 };
            int[] ReverseArray = new int[givenArr.Length];

            for (var i = givenArr.Length - 1; i >= 0; i--)
            {
                ReverseArray[i] = givenArr[i];
                Console.WriteLine(ReverseArray[i]);
            }
                return ReverseArray;
        }
    }
}

