using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Prep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "Pakistan";
            char[] characters = a.ToCharArray();

            Dictionary<char, int> charFrequency = new Dictionary<char, int>();


            foreach (char c in characters)
            {
                if (charFrequency.ContainsKey(c))
                {
                    charFrequency[c]++;
                }
                else
                {
                    charFrequency[c] = 1;
                }

            }
            
            foreach (var kvp in charFrequency)
            {
                if (kvp.Value > 1)
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value} occurrences");
                }
            }

            //FindDuplicates(array);

            //int[] arrayTwo = { 43, 97, 11, 90, 53, 32 };
            //findMaxMin(arrayTwo);
            //findMaxMinBySort(arrayTwo);
        }
        static void FindDuplicates(int[] array)
        {
            HashSet<int> seen = new HashSet<int>();
            HashSet<int> found = new HashSet<int>();

            foreach (int i in array)
            {
                if (!seen.Add(i))
                {
                    found.Add(i);
                }
            }

            Console.WriteLine(seen);
            foreach (int dup in found)
            {
                Console.WriteLine(dup);
            }
        }

        static void findMaxMin(int[] arrayTwo)
        {
            if (arrayTwo.Length == 0)
            {
                Console.WriteLine("Array is Empty");
            }


            int Max = arrayTwo[0];
            int Min = arrayTwo[0];

            for (int i = 1; i < arrayTwo.Length; i++)
            {
                if (arrayTwo[i] > Max)
                {
                    Max = arrayTwo[i];
                }
                else if (arrayTwo[i] < Min)
                {
                    Min = arrayTwo[i];
                }
            }
            Console.WriteLine($"Max Value {Max}");
            Console.WriteLine($"Min Value {Min}");
        }

        static void findMaxMinBySort(int[] arrayTwo)
        {
            if (arrayTwo.Length == 0)
            {
                Console.WriteLine("Array is Empty");
            }

            Array.Sort(arrayTwo);

            int Max = arrayTwo[0];
            int Min = arrayTwo[arrayTwo.Length - 1];

            Console.WriteLine($"Max Value {Max}");
            Console.WriteLine($"Min Value {Min}");
        }


    }
}
