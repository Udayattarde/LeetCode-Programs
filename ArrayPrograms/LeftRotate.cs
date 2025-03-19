using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ArrayPrograms
{
    internal class LeftRotate
    {

        static void rotateByOnePlace(int[] arr)
        {
            int n = arr.Length;
            int temp = arr[0];
            for(int i = 0; i < n - 1; i++)
            {
                arr[i] = arr[i + 1];
            }

            arr[n-1] = temp;
            Console.WriteLine(string.Join(",",arr));
        }
        static void rotateByDPlace(int[] arr ,int d)
        {
            if (arr.Length == 0) return;
            int n = arr.Length;
            d = d % n;

            reverse(arr, 0, d-1);
            reverse(arr,  d, n - 1);
            reverse(arr, 0, n-1);
            Console.WriteLine(string.Join(',',arr));

//            Time Complexity: O(d) + O(n - d) + O(n) = O(2 * n), where n = size of the array, d = the number of rotations.Each term corresponds to each reversal step.

//Space Complexity: O(1) since no extra space is required.
        }

        private  static void reverse(int[] arr,int start,int end)
        {
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];  
                arr[end] = temp;
                start++;
                end--;

            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 4, 5, 6, 7, 8 };
            int[] arr2 = { 1, 2, 4, 5, 6, 7, 8 }; 

            int[] arr1 = { 1, 2, 4, 5, 6, 7, 8 };
            rotateByOnePlace(arr2);
            Console.WriteLine("rotateby D place");

            rotateByDPlace(arr,3);

            int[] rotated = arr1.Skip(1).Concat(arr1.Take(1)).ToArray();
            int[] rotated1 = arr1.Skip(3).Concat(arr1.Take(3)).ToArray();

            Console.WriteLine(string.Join(" ", rotated));
            Console.WriteLine(string.Join(" ", rotated1));


        }
    }
}
