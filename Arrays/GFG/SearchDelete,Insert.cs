using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.GFG
{
    public static class SearchDelete_Insert
    {

        /// <summary>
        /// look for also unsorted array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static int Search(int[] arr,int low,int high,int key)
        {
          
            int n = arr.Length;

            if (high < low)
            {
                return -1;
            }

            int mid = (low + high) / 2;
            if (key == arr[mid])
            {
                return mid;
            }
            if (key > arr[mid])
            {
                return Search(arr, (mid + 1), high, key);
            }
            return Search(arr, low, (mid - 1), key);

            //using linq 
            //int index = Array.BinarySearch(arr, 0, arr.Length, key);
            //return (index >= 0) ? index : -1;

        }

        public static int Insert(int[] arr,int n,int key)
        {
            if (n >= arr.Length)  // Ensure we have enough space
            {
                Console.WriteLine("Error: Cannot insert, array is full.");
                return n;  // Return unchanged size
            }
            int i;
            for (i = n - 1; (i >= 0 && arr[i] > key); i--)
                arr[i + 1] = arr[i];

            arr[i + 1] = key;

            return (n + 1);

            //using linq

            //if (arr.Length == 0)
            //    return new int[] { key };

            //arr = arr.Append(key).ToArray(); 
            //Array.Sort(arr); 
            //return arr;

        }

        public static int Delete(int[] arr,int n,int key)
        {
            // Find position of element to be deleted
            int pos = Search(arr, 0, n - 1, key);

            if (pos == -1)
            {
                Console.WriteLine("Element not found");
                return n;
            }

            int i;
            for (i = pos; i < n - 1; i++)
                arr[i] = arr[i + 1];

            return n - 1;

            //using linq
            //if (!arr.Contains(key)) // Check if key exists
            //{
            //    Console.WriteLine("Element not found");
            //    return arr;
            //}

            //return arr.Where(x => x != key).ToArray(); // Filter out the key

        }
    }
}
