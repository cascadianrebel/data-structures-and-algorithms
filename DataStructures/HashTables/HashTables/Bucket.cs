using System;
using System.Collections.Generic;
using System.Text;

namespace HashTables
{

    public class Bucket
    {
        /// <summary>
        /// properties shared by buckets in hashtables
        /// </summary>
        public string Key { get; set; }
        public string Value { get; set; }
        public Bucket Next { get; set; }
    }
}
