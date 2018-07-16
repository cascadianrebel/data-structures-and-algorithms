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
            HashTables.Hashtable testHashtable = new HashTables.Hashtable();

            testHashtable.AddBucket("testKey", "testValue");

            int
                indexTest = Hashtable.GetHash("testKey");

        }
    }
}
