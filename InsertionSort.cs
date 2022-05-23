using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    internal class InsertionSort
    {
        public static void sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int temp = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = temp;
            }
            Console.WriteLine();
            Console.WriteLine("Insertion Sorted array is: ");
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.WriteLine(arr[i] + " ");
            }
            Console.Write("\n");
        }
    }
}
