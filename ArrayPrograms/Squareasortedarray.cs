using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    internal class Squareasortedarray
    {

        static int[] sortArray(int[] arr)
        {
            int start = 0;
            int end = arr.Length-1;

            while (start <= end) {
                if (arr[start] * arr[start] > arr[end] * arr[end])
                {
                    int t = arr[start];
                    arr[start] = arr[end];
                    arr[end] = t;
                }

                arr[end] = arr[end] * arr[end];
                end--;
                         
            }

            return arr;
        }
        static void Main(string[] args)
        {
            int[] arr = { -4, -2, -1, 3, 5 };

            var res = sortArray(arr);

            Console.WriteLine(String.Join(", ",res));
        }

        //time : o(n) in one pass. brute soln is mutliply each element and then sort time will be O(n logn) for sorting at last
        //space : O(1) no space 
    }
}
