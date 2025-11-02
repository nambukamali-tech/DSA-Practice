using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary
{
    internal class binarySearchdsa
    {
        static void Main(string[] args)
        {
            int[] SortedElements = { 10, 20, 30, 40, 50, 60, 70, 80 };
            Console.WriteLine("Enter the Key to Search : ");
            int SortedKey = int.Parse(Console.ReadLine());
            //Assign Three Variables
            int first = 0;//Refer the First Index
            int last = SortedElements.Length - 1;//Refer the Last Index
            bool searchResult = false;//For Found key or Not Found key
            //Check if the First Index value less than Last Index value
            while(first <= last)
            {
                int mid = (first + last) / 2;
                if (SortedElements[mid] == SortedKey)
                {
                    Console.WriteLine("Element is Found at index!" + mid);
                    searchResult = true;
                    return;
                }
                else if (SortedElements[mid] < SortedKey)
                {
                    first = mid + 1;//Search in Right Half
                }
                else
                {
                    last = mid - 1;
                }

            }
            if(!searchResult)
            {
                Console.WriteLine("OOPS..Element Not Found at Array!");
            }
        }
    }
}
