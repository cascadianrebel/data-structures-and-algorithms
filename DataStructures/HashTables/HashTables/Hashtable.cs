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
        /// <returns>the Hash Nunmber</returns>
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

            int i = GetHash(key);
            //if collision, place in next value
            if (BucketArray[i] != null)
            {
                bucket.Next = BucketArray[i];
            }

            BucketArray[i] = bucket;          
        }

        /// <summary>
        /// finds the value of the provided key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string Find(string key)
        {
            int i = GetHash(key);

            if (BucketArray[i].Key == key)
            {
                return BucketArray[i].Value;
            }

            Bucket bucket = BucketArray[i];
            while (bucket.Next != null)
            {
                if (bucket.Key == key)
                {
                    return bucket.Value;
                }
             bucket = bucket.Next;
            }

            return bucket.Value;
        }
        
        /// <summary>
        /// searches through hashtable, if the key is present 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Contains(string key)
        {
            int i = GetHash(key);
            if (BucketArray[i].Key == key && BucketArray[i].Value != null)
            {
                return true;
            }
            else return false;
        }

    }
}
