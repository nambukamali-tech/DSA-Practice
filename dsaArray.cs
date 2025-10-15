using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10] {3,4,5,6,1,2,8,9,10,11};//Initialize and Declaring Array
            Console.WriteLine("The Original Array Values are:");
            Console.WriteLine(string.Join(",", numbers));//Using Built-in Join() for print the array values by using seperator ','
            //call the function with passing arguments
            Reverse_Array(numbers);
            Console.WriteLine("The Reversed Array Values are:");
            Console.WriteLine(string.Join(",", numbers));

        }
        static void Reverse_Array(int[] numbers)//Create reverse_Array Function with passing the array 'numbers' as parameter
        {
            int start = 0, end = numbers.Length-1;
            while(start < end)
            {
                int reversing = numbers[start];//Swapping 
                numbers[start] = numbers[end];
                numbers[end] = reversing;
                start++;//Increment of 'start' like 0 , 1 , 2 ...'move forward'
                end--;//Decrement of 'end' like 9, 8 , 7 ....'move backward'

            }
        }
    }
}
