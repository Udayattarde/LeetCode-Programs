using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.Strivers.Arrays
{
    public class SecondLargest
    {
        public static void SecondSmallest()
        {
            int[] arr = { 1, 2, 4, 7, 7, 5 };
            int n = arr.Length;
            int small = int.MaxValue;
            int secondSmall = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] < small)
                {
                    secondSmall = small;
                    small = arr[i];
                }
                else if (arr[i] < secondSmall && arr[i] != small)
                {
                    secondSmall = arr[i];
                }
            }

            Console.WriteLine("The second small element in the array is: " + secondSmall);
        }

        public static void SecondLargestValue()
        {

            int[] arr = { 1, 2, 4, 7, 7, 5 };
            int n = arr.Length;
            int large = int.MinValue;
            int secondLarge = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] > large)
                {
                    secondLarge = large;
                    large = arr[i];
                }
                else if (arr[i] > secondLarge && arr[i] != large)
                {
                    secondLarge = arr[i];
                }
            }

            Console.WriteLine("The second largest element in the array is: " + secondLarge);
        }


    }
}
