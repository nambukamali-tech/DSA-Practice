using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondLargeNumberdsa
{
    internal class secondLargeNumberdsa
    {
        //Demo program to find the second largest element in array
        static void Main(string[] args)
        {
            int[] elements = { 10, 30, 40, 20, 50 };
            int first = int.MinValue;
            int second = int.MinValue;//MinValue is default it automatically set the value
            //Using loop for accessing the array elements
            foreach(int newElement in elements)
            {
                if(newElement > first)
                {
                    second = first;
                    first = newElement;
                }
                else if(newElement < first && newElement > second)//Always ensures that the second element smaller than first one because we find the second largest one
                {
                    second = newElement;
                }
               
            }
            if (second == int.MinValue)
                Console.WriteLine("No second largest Element is found");
            else
                Console.WriteLine("Second Largest Element is :" + second);
        }
    }
}
