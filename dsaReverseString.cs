using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayReverseString
{
    internal class arrayReverseString
    {
        static void Main(string[] args)
        {
            string[] names = { "Dotnet", "Csharp", "ASP", "MVC" };
            Console.WriteLine("The Original Values are:");
            Console.WriteLine(string.Join(",", names));
            for(int i=0; i<names.Length;i++)
            {
                names[i] = reverse_string(names[i]);//stores the reversed string back to the names array
            }
            Console.WriteLine("The Reversed Values are:");
            Console.WriteLine(string.Join(",", names));//Join () method for print string values with seperator ','


        }
         public static string reverse_string(string values)//Using 'string' because the function returns the 'string' values
        {
            char[] chars = values.ToCharArray();//Using ToCharArray() for take all string values converted to characters
            int start = 0;
            int end = chars.Length - 1;//Two pointer method for reverse the string
            while(start < end)
            {
                char swap = chars[start];//create only Character variable
                chars[start] = chars[end];
                chars[end] = swap;
                start++;//move forward
                end--;//move backward
            }
            return new string(chars);//convert all char values back to string
            

        }
    }
}
