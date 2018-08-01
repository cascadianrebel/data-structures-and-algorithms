using System;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();

            hashtable.AddBucket("Washington", "Olympia");
            hashtable.AddBucket("California", "Sacramento");
            hashtable.AddBucket("Hawaii", "Honolulu");
            hashtable.AddBucket("Oregon", "Salem");
            hashtable.AddBucket("Alaska", "Juneau");

            Console.WriteLine("Added States and Capitals of West Coast to Hashtable");
            Console.Read();

            int WAHash = hashtable.GetHash("Washington");
            int ORHash = hashtable.GetHash("Oregon");
            int AKHash = hashtable.GetHash("Alaska");


            Console.WriteLine($"Washington hashed out is {WAHash} and Oregon hashed out is {ORHash}");
            Console.Read();

            hashtable.AddBucket("Washington", "Seattle");
            hashtable.AddBucket("Oregon", "Portland");

            Console.WriteLine("Added Oregon and Washington's largest Cities");

            Console.WriteLine($"Washington: {hashtable.BucketArray[WAHash].Next.Value} and {hashtable.BucketArray[WAHash].Value}");

            Console.WriteLine($"Oregon: {hashtable.BucketArray[ORHash].Next.Value} and {hashtable.BucketArray[ORHash].Value}");

            string CACapital = hashtable.Find("California");
            Console.WriteLine($"The Capital of California is {CACapital}");

            Console.WriteLine($"The Capital(Value) of Alaska (Key) is {hashtable.BucketArray[AKHash].Value}");
            Console.Read();

            bool HIincluded = hashtable.Contains("Hawaii");
            Console.WriteLine($"Hawaii is included in the West Coast States: {HIincluded}");

            Console.Read();
        }
    }
}
