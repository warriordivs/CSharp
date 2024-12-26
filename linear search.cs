using System;

class Program
{
    public static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                return i; // Element found, return index
            }
        }
        return -1; // Element not found
    }

    static void Main(string[] args)
    {
        int[] arr = { 10, 20, 30, 40, 50 };
        int target = 30;

        int result = LinearSearch(arr, target);

        if (result != -1)
            Console.WriteLine("Element found at index: " + result);
        else
            Console.WriteLine("Element not found.");
    }
}
