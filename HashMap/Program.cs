using System;

namespace ConsolePlayground
{
    class Program
    {
        public static void Main(string[] args)
        {
            var hashmap = new HashMap();

            const string key1 = "Dylan";
            const string key2 = "Ringo";

            var pair1 = new KeyValue() { Key = key1, Value = "Field" };
            var pair2 = new KeyValue() { Key = key2, Value = "Starr" };

            Console.WriteLine("Add the following values to the hash table:");
            Console.WriteLine(pair1);
            Console.WriteLine(pair2);

            hashmap.Put(pair1);
            hashmap.Put(pair2);

            Console.WriteLine("Let's get the items:");
            Console.WriteLine(hashmap.Get(key1));
            Console.WriteLine(hashmap.Get(key2));

            Console.WriteLine("Remove 'Dylan'");
            hashmap.Remove(key1);
            Console.WriteLine("And try to get it");
            Console.WriteLine(hashmap.Get(key1));

            Console.WriteLine("Finally clear the hash table");
            hashmap.Clear();
            Console.WriteLine("Done");

            Console.ReadLine();
        }
    }
}
