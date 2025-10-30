using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubbleSortdsa
{
    internal class bubbleSortdsa
    {
        //Simple demo program explains the concept of bubble sorting done in array problem of 'Sorting'
        static void Main(string[] args)
        {
            int[] elements = { 8, 1, 10, 6, 3, 11, 0, 2 };
            Console.WriteLine("Before Sorting the elements are...");
            PrintArray(elements);
            //Logic of Bubble Sort
            for(int i=0; i<elements.Length-1; i++)//Outer loop handles the where to starts and ends the accessing array elements 
            {
               for(int j=0; j<elements.Length-i-1; j++)//Inner loop
                {
                    if (elements[j] > elements[j+1])
                    {
                        int temp = elements[j];
                        elements[j] = elements[j + 1];//Swapping of elements large to end & small to first
                        elements[j + 1] = temp;
                    }//Bubble sorting the method solves the problem by swap the largest numbers at end of the array and moves small numbers to front of the array
                }
                
            }
            Console.WriteLine("After Sorting the Numbers are:");
            PrintArray(elements);

        }
        static void PrintArray(int[] arr)
        {
            foreach(int num in arr)
            {
                Console.WriteLine(num + " ");
            }
            Console.WriteLine();
        }
    }
}
