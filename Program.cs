using System;

namespace InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n------------WELCOME TO THE INSERTION SORTING PROGRAM----------------\n\n");
            Console.Write("Enter the length of array : ");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            Console.WriteLine("Enter the element of array :");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            InsertionSort.sort(arr);
        }
    }
}
