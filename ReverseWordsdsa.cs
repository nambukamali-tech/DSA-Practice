using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentence");
            string words = Console.ReadLine();
            string resultWords = ReverseWords(words);
            Console.WriteLine(resultWords);

        }
        static string ReverseWords(string str)
        {
            string[] RevWords = str.Split(' ');
            Array.Reverse(RevWords);
            string FinalWords = string.Join(" ", RevWords);
            return FinalWords;
        }
    }
}
