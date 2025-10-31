using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonRepeatCharsdsa
{
    internal class NonRepeatCharsdsa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Word of Characters :");
            string words = Console.ReadLine();
            //Create a Dictionary
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (char ch in words)
            {
                if (charCount.ContainsKey(ch))
                    charCount[ch]++;//If the characters is found again it count will increased
                else
                    charCount[ch] = 1;//If not it remain '1' as same
                
            }
            //Find the First Non-Repeating Character
            char result = '\0';
            foreach(char ch in words)
            {
                if (charCount[ch] == 1)
                {
                    result = ch;
                    break;
                }
            }
            if (result != '\0')
                Console.WriteLine($"The First Non-Repeating Character is {result}");
            else
                Console.WriteLine("No Non-Repeating Character is Found");

        }
    }
}
