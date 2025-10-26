using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicates
{
    internal class RemoveDuplicatedsa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String");
            string DuplicateWord = Console.ReadLine();

            string RefinedWord = RemoveDuplicates(DuplicateWord);
            Console.WriteLine("The Removed Duplicates word is" + RefinedWord);
            Console.ReadLine();
        }
        static string RemoveDuplicates(string words)
        {
            string RefinedWord = "";
            foreach ( char c in words)
            {
                if(!RefinedWord.Contains(c))
                {
                    RefinedWord += c;
                }
            }
            return RefinedWord;

        }
    }
}
