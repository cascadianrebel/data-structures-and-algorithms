using HashTables;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddBucketToTable()
        {
            Hashtable testTable = new Hashtable();

            testTable.AddBucket("TestKey", "TestValue");

            Assert.Equal("TestValue", testTable.Find("TestKey"));
        }

        [Fact]
        public void CanCheckTableToContainKey()
        {
            Hashtable testTable = new Hashtable();

            testTable.AddBucket("TestKey", "TestValue");

            Assert.True(testTable.Contains("TestKey"));
        }

        [Fact]
        public void CollisionsAllowed()
        {
            Hashtable testTable = new Hashtable();

            testTable.AddBucket("TestKey", "TestValue");

            testTable.AddBucket("TestKey", "Collision!");

            int testBucket = testTable.GetHash("TestKey");

            Assert.Equal("TestValue", testTable.BucketArray[testBucket].Next.Value);

            Assert.Equal("Collision!", testTable.BucketArray[testBucket].Value);
        }

        [Fact]
        public void MultipleCollisionsAllowed()
        {
            Hashtable testTable = new Hashtable();

            testTable.AddBucket("TestKey", "TestValue");

            testTable.AddBucket("TestKey", "Collision!");

            testTable.AddBucket("TestKey", "Another Collision!");

            int testBucket = testTable.GetHash("TestKey");

            Assert.Equal("TestValue", testTable.BucketArray[testBucket].Next.Next.Value);

            Assert.Equal("Collision!", testTable.BucketArray[testBucket].Next.Value);

            Assert.Equal("Another Collision!", testTable.BucketArray[testBucket].Value);
        }



    }
}
