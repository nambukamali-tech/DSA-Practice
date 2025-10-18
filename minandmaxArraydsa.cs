// See https://aka.ms/new-console-template for more information
class minandmaxArraydsa
{
    public static void Main(String[] args)
    {
        int[] elements = { 10, 1, 3, 6, 7, 8 };
        minandmax(elements);
    }
    static void minandmax(int[] elements)
    {

        int minNum = elements[0];
        int maxNum = elements[0];
        foreach(int element in elements)
        {
            if (element < minNum)
                minNum = element;
            if (element > maxNum)
                maxNum = element;
        }
        Console.WriteLine("The Max value in array" + maxNum);
        Console.WriteLine("The Min Value in array" + minNum);

    }
}
