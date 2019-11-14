using System;
using System.Collections.Generic;

namespace LearningHashSets
{
    class Program
    {
        static void Main(string[] args)
        {

            // Hash sets help remove duplicate elements in an array.
            var myHash = new HashSet<String>();
            myHash.Add("hello");
            myHash.Add("hello");

            Console.WriteLine(myHash.Count);

            //Overlaps can also be used in Hashsets to see if any of the elements in the two compared arrays are the same.
            String[] s = new string[] { "hello", "Goodbye" };
            // This will show true because "hello" is in both myHash and the array named 's'.
            Console.WriteLine(myHash.Overlaps(s));
        }
    }
}
