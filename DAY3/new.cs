using System;


namespace RAM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Okay");
            int[] val = { 1, 2, 3 }; // dynamic array

            int[] val2 = new int[7] { 1, 2, 3, 4, 5, 6 ,7 }; //static
                                                             //
                                                             //indexing - defines positional values of the same
            string[] val3 = { "Ram", "Shyam", "Geeta" };
            Console.WriteLine(val3[0]); 

            for (int i = 0; i < val3.Length; i++)
            {
                 string element = val3[i];
                Console.WriteLine("Element at index " + i + ": " + element);

            }
            //Sort alphabetical
            Array.Sort(val3);
            for(int i = 0;i < val3.Length; i++) 
            {
                Console.WriteLine(val3[i]);
            
            }

            string[] strings = { "apple", "banana", "orange", "grape", "kiwi" };

            string maxString = strings.Max();
            string minString = strings.Min();

            Console.WriteLine("Max String: " + maxString);
            Console.WriteLine("Min String: " + minString);
        }
    }
}
