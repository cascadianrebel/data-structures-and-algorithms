using System;
using Xunit;
using QuickSort;

namespace XUnitTestQuickSort
{
    public class UnitTest1
    {
        [Fact]
        public void CanSortUnorderedArrayPositiveIntegers()
        {
            int[] UnsortedArray = { 8, 6, 7, 5, 3, 1, 9 };
            int[] SortedArray = { 1, 3, 5, 6, 7, 8, 9 };
            Program.AlgoQuickSort(UnsortedArray, 0, UnsortedArray.Length - 1);

            Assert.Equal(  SortedArray, UnsortedArray );
        }

        [Fact]
        public void CanSortUnorderedArrayNegativeIntegers()
        {
            int[] UnsortedArray = { 8, 6, 7, 5, 3, 1, -9 };
            int[] SortedArray = { -9, 1, 3, 5, 6, 7, 8 };
            Program.AlgoQuickSort(UnsortedArray, 0, UnsortedArray.Length - 1);

            Assert.Equal(SortedArray, UnsortedArray);
        }

        [Fact]
        public void CanMaintainOrderedArray()
        {
            int[] UnsortedArray = { -9, 1, 3, 5, 6, 7, 8 };
            int[] SortedArray = { -9, 1, 3, 5, 6, 7, 8 };
            Program.AlgoQuickSort(UnsortedArray, 0, UnsortedArray.Length - 1);

            Assert.Equal(SortedArray, UnsortedArray);
        }
    }
}
