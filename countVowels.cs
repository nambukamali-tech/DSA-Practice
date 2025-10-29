using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countVowels
{
    //Demo code of Counting the Number of vowels letters in given string
    internal class countVowels
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Word :");
            string word = Console.ReadLine();
            int count = 0;
            foreach(char c in word.ToLower())//Convert the String to Characters
            {
                if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' )//If any of the letters 'a e i o u' the count will updated
                {
                    count++;
                }
            }
            Console.WriteLine("The Number of Vowels in Word is" + count);
        }
    }
}
