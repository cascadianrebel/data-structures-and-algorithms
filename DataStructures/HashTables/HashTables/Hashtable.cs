using System;
using System.Collections.Generic;
using System.Text;

namespace HashTables
{
    public class Hashtable
    {
        public Bucket[] BucketArray { get; set; }

        /// <summary>
        /// create a hashtable made up of an 1024 sized array of buckets
        /// </summary>
        public Hashtable()
        {
            BucketArray = new Bucket[1024];
        }

        /// <summary>
        /// find the index position of the a particular key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public int GetHash(string key)
        {
            decimal charNumValue = 0;
            foreach(char letter in key)
            {
                charNumValue += letter;
            }
            return (int)Math.Floor((charNumValue * 599) / 1024);
        }



        /// <summary>
        /// add a key value pair to the hashtable
        /// </summary>
        /// <param name="key">the key as an string</param>
        /// <param name="value">the value as a string</param>
        public void AddBucket(string key, string value)
        {
            //creates the new bucket
            Bucket bucket = new Bucket
            {
                Key = key,
                Value = value
            };

            int indexPos = GetHash(key);

            BucketArray[indexPos] = bucket;
            
        }
    }
}
