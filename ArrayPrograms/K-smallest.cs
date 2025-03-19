using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    internal class K_smallest
    {


        public static int KthSmallestBruteForce(int[] arr, int k)
        {
            Array.Sort(arr);
            return arr[arr.Length - k-1];
        }

        public static int KthSmallestOptimal(int[] arr, int k)
        {
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));

            foreach (int num in arr)
            {
                pq.Enqueue(num, num);
                if (pq.Count > k)
                {
                    pq.Dequeue();
                }
            }

            return pq.Peek();
        }

        public static int KthSmallestUsingLinq(int[] arr ,int k)
        {
            return arr.OrderBy(n => n).ElementAt(k-1);
        }
        static void Main(string[] args)
        {
            {
                int[] arr = { 7, 10, 4, 3, 20, 15 };
                int k = 3;

                Console.WriteLine("Brute Force:");
                int resultBruteForce = KthSmallestBruteForce(arr, k);
                Console.WriteLine("Kth smallest element is " + resultBruteForce);

                Console.WriteLine("Optimal:");
                int resultOptimal = KthSmallestOptimal(arr, k);
                Console.WriteLine("Kth smallest element is " + resultOptimal);


                Console.WriteLine("LINQ:");
                int resultLinq = KthSmallestUsingLinq(arr, k);
                Console.WriteLine("Kth smallest element is " + resultLinq);
            }
        }
    }
}
