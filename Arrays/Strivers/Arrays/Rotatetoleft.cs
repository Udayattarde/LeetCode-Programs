using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Strivers.Arrays
{
    public static class Rotatetoleft
    {

        public static void LeftRotateByOne()
        {
            int n = 7;
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
    

            int[] temp = new int[n];

            for (int i = 1; i < n; i++)
            {
                temp[i - 1] = arr[i];
            }
            temp[n - 1] = arr[0];


            //linq
            // temp = arr.Skip(1).Concat(arr.Take(1)).ToArray();
            Console.WriteLine(string.Join(" ", temp));




        }
        public static void LeftRotateByK()
        {
            int n = 7;
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int k = 2;

            if (n == 0)
                return;

            k = k % n;

            if (k > n)
                return;


            //for (int idx = 0; idx < n; idx++)
            //{
            //    Console.Write(arr[idx]);
            //}

            //int[] temp  = new int[k];
            //for (int i = 0; i < k; i++)
            //{
            //    temp[i] = arr[i];
            //}

            //for(int i = k; i < n; i++)
            //{
            //    arr[i - k] = arr[i];
            //}

            //int j = 0;

            //for(int i = n-k; i<n; i++)
            //{
            //    arr[i] = temp[j];
            //    j++;
            //}


            //Console.WriteLine("\nafter rotation");
            //Console.WriteLine(string.Join(" ", arr));


            //Time Complexity: O(n)

            // Space Complexity: O(k) since k array element needs to be stored in temp array



            //------------------------ Optimal One -------------------
            Reverse(arr, 0, k - 1);
            // Reverse last n-k elements
            Reverse(arr, k, n - 1);
            // Reverse whole array
            Reverse(arr, 0, n - 1);


            //---------------- Linq ------------------
             //arr = arr.Skip(k).Concat(arr.Take(k)).ToArray();
            Console.WriteLine("\nafter rotation optimal");
            Console.WriteLine(string.Join(" ", arr));




        }

        private static void Reverse(int[] arr, int start, int end)
        {
            while (start <= end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
    }
}
