using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    internal class FindMinSubarrayLength
    {

        public static int FindMin(int[] arr)
        {
            if (arr.Length == 0)
            {
                return -1;
            }

            int start = 0;
            while (start < arr.Length - 1 && arr[start] <= arr[start + 1])
            {
                start++;
            }

            if (start == arr.Length - 1)
            {
                return 0;
            }

            int end = arr.Length - 1;
            while (end > 0 && arr[end - 1] <= arr[end])
            {
                end--;
            }

            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = start; i <= end; i++)
            {
                min = Math.Min(min, arr[i]);
                max = Math.Max(max, arr[i]);
            }

            while (start > 0 && arr[start - 1] > min)
            {
                start--;
            }

            while (end < arr.Length - 1 && arr[end + 1] < max)
            {
                end++;
            }

            return end - start + 1;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 5, 3, 0, 12, 13, 8, 15, 18 };

            int res = FindMin(arr);

            Console.WriteLine("smallest sublength" + res);

        }
        //time : O(n)
        //space: O(1)
    }
}
