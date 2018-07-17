using System;

namespace repeated_word
{
    class Program
    {
        static void Main(string[] args)
        {
            public string LongString = "Once upon a time, there lived a beautiful princess. She lived happily ever after.";


       

            public string RepeatedWord(string lengthyString)
            {
                Array longStringHash = new Array[1024];

               Array longStringArray = lengthyString.Split(" ");



            foreach(string word in longStringArray)
            {

            }
            }
        public int GetHash(string word)
        {
            int index = 0;
            foreach( char x in word)
            {
                index += x; 
            }
            int hashValue = (index * 599) / 1024;
            return Math.Floor(hashValue);
                }
        }
    }
}
