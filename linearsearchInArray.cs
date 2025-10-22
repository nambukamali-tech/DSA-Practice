// See https://aka.ms/new-console-template for more information
//Demo Code Explains the concept of Linear Search performing in Array
int[] searchnums = { 10, 30, 20, 50, 80, 90 };//Array of elements
bool found = false;
Console.WriteLine("Enter the Number you want to search ");
int targetNum = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < searchnums.Length; i++)//Loops through each element in array and finds the target one
{
    if (searchnums[i] == targetNum)//Condition check the targetNumber and SearchNumber in array index are equal
    {
        Console.WriteLine($"The Element found in Index is {i}");//Print the index matched 
        found = true;
        break;
    }
}
    if (!found)
    {
        Console.WriteLine("The Element Not Found!");
    }
    Console.ReadLine();
