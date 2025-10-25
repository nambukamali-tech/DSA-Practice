using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    internal class palindrome
    {
        static void Main(string[] args)
        {
            //Simple demo code apply the DSA problem in string via palindrome
            Console.WriteLine("Enter the Words:");
            string words = Console.ReadLine();
            string lowerwords = words.ToLower();//Convert the words to lowercase letters
            //Convert the String to Char datatypes
            char[] chars = words.ToCharArray();//For reverse the string we must convert the string -> characters
            //Reverse the String
            Array.Reverse(chars);
            string reversedchars = new string(chars);
            if(reversedchars == lowerwords)
            {
                Console.WriteLine("The Word is Palindrome");
            }
            else
            {
                Console.WriteLine("The Word is not Palindrome");
            }
        }
    }
}
