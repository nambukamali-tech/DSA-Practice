using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseString
{
    internal class LoopReverseString
    {
        static void Main(string[] args)
        {
            string project = "Dotnet";
            string reversed_project = "";
            for(int i=project.Length-1;i>=0;i-- )//Loop method to Reverse the String
            {
                reversed_project += project[i];
            }
            Console.WriteLine("Original project is :" + project);
            Console.WriteLine("Reversed project is :" + reversed_project);
            
        }

    }
}
