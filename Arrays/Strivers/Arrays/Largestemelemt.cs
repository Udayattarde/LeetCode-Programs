using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.Strivers.Arrays
{
    public static class Largestemelemt
    {
        public static void FindLargestElement()
        {
            int[] arr = { 2, 5, 1, 3, 0 };
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("The largest element in the array is: " + max);
        }
    }
}
