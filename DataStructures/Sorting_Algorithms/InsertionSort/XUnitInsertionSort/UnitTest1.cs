using InsertionSortAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XUnitInsertionSort
{
    public class UnitTest1
    {
        [Fact]
        public void CanOrderArray()
        {
            int[] exampleArr = { 51, 24, 34, 1, 90, 35, 38, 29 };
            Program.InsertionSort1(exampleArr, exampleArr.Length - 1);

            int[] sortedArr = { 1, 24, 29, 34, 35, 38, 51, 90 };
            Assert.Equal(exampleArr, sortedArr);
        }

        [Fact]
        public void CanOrderWithZeroAsAValue()
        {
            int[] exampleArr = { 51, 24, 34, 0, 90, 35, 38, 29 };
            Program.InsertionSort1(exampleArr, exampleArr.Length - 1);

            int[] sortedArr = { 0, 24, 29, 34, 35, 38, 51, 90 };
            Assert.Equal(exampleArr, sortedArr);
        }

        [Fact]
        public void CanSortWithNegativesIncluded()
        {
            int[] exampleArr = { 51, -24, 34, -1, 90, 35, 38, 29 };
            Program.InsertionSort1(exampleArr, exampleArr.Length - 1);

            int[] sortedArr = { -24, -1, 29, 34, 35, 38, 51, 90 };
            Assert.Equal(exampleArr, sortedArr);
        }

    }
}
