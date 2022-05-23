using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortProgram
{
    internal class BubbleSort
    {
        public static void BubbleSorting(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])   //its for descending order  And if(arr[j] > arr[j + 1]) ascending order
                    {
                        // swap temp and arr[i]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            //Display unit
            Console.WriteLine("Bubble Sorted array is: ");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
