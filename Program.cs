using System;

namespace BubbleSortProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n-----------------Welcome to BubbleSort Program------------\n\n");
            Console.Write("Please enter the length of the Array: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Please enter the array elements : ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            BubbleSort.BubbleSorting(arr);
        }
    }
}
