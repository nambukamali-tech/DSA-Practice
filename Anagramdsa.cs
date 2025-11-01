using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagramdsa
{
    internal class Anagramdsa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String 1 :");
            string word1 = Console.ReadLine();
            Console.WriteLine("Enter the String 2 :");
            string word2 = Console.ReadLine();
            //Convert Both Words to Characters
            word1 = word1.ToLower();
            word2 = word2.ToLower();
            //Check if both the words are equal in length or not
            if(word1.Length != word2.Length)
            {
                Console.WriteLine("The Words are Not Anagrams");
                return;
            }
            //Convert the String to Char Arrays and Sort
            char[] array1 = word1.ToCharArray();
            char[] array2 = word2.ToCharArray();
            //Sort the Arrays
            Array.Sort(array1);
            Array.Sort(array2);
            //After the Sorting of Arrays the perform Anagram Condition
            if(new string(array1) == new string (array2))
            {
                Console.WriteLine("The Words are Anagrams");
            }
            else
            {
                Console.WriteLine("The Words are not Anagrams");
            }
        }
    }
}
