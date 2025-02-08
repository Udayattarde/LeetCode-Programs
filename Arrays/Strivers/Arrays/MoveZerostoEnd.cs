using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Strivers.Arrays
{
    public static class MoveZerostoEnd
    {
    
        public static void MoveBrute()
        {
            int[] arr = { 1, 0, 2, 3, 2, 0, 0, 4, 5, 1 };
            int n = 10;
            List<int> temp = new List<int>();

            for (int i = 0; i < n; i++)
            {
                if (arr[i] != 0)
                {
                    temp.Add(arr[i]);     
                }
            }


            int nz = temp.Count;

            for (int i = 0; i < nz; i++)
            {
                arr[i] = temp[i];
            }

            for (int i = nz; i < n; i++)
            {
                arr[i] = 0;
            }
            Console.WriteLine(string.Join(" ",arr));    

        }

        public static void MoveOptimal()
        {
            int[] arr = { 1, 0, 2, 3, 2, 0, 0, 4, 5, 1 };
            int n = 10;

            int j = Array.IndexOf(arr, 0);

            for (int i = j + 1; i < n; i++)
            {
                if (arr[i] != 0)
                {
                    // Swap elements
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    j++;
                }
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
