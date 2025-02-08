using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Aayushi
{
    public static class NextPermutation
    {

        public static void findNext()
        {
            int[] arr = [4, 1, 5, 3, 2];

            int n = arr.Length;

            if (n == 1) return;

            int idx1 = 0;

            for (int i = n - 2; i >= 0; i--)
            {
                if (arr[i] < arr[i + 1])
                {
                    idx1 = i;
                    break;
                }

            }

            if (idx1 < 0)
                Array.Reverse(arr);
            else
            {
                int idx2 = 0;
                for (int j = n-1; j>= 0; j--)
                {
                    if (arr[j] > arr[idx1])
                    {
                         idx2 = j;
                        break;
                    }
                }
                Swap(arr, idx1, idx2);

                Array.Reverse(arr, idx1 + 1,n - idx1-1);
            }

            Console.Write(string.Join(" ", arr));
            
        }

        private static void Swap(int[] arr,int low,int high)
        {
            int temp = arr[low];
            arr[low] = arr[high];
            arr[high] = temp;

        }

    }
}
