using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    internal class SubArrayProductLessThanK
    {

        static List<List<int>> Findsub(int[] arr, int k)
        {
            int mul = 1;
            int start = 0;

            List<List<int>> res = new List<List<int>>();

            for (int i = 0; i < arr.Length; i++)
            {

                mul *= arr[i];
                while (mul >= k && start <= i)
                {
                    mul /= arr[start];
                    start++;
                }

                List<int> subarry = new List<int>();

                for (int j = i; j >= start; j--)
                {
                    subarry.Insert(0, arr[j]);
                    res.Add(new List<int>(subarry));
                }

            }
            return res;
        }

        public static List<List<int>> UsingLinq(int[] arr, int k)
        {
            return Enumerable.Range(0, arr.Length)   // Generates start indices (0 to n-1)
                .SelectMany(i => Enumerable.Range(i, arr.Length - i)   // Generates end indices
                    .Select(j => arr.Skip(i).Take(j - i + 1).ToList()))  // Extracts subarrays
                .Where(subarray => subarray.Aggregate(1, (prod, x) => prod * x) < k) // Filters valid subarrays
                .ToList();
        }



        static void Main(string[] args)
        {

            int[] arr = { 4, 2, 5, 3, 6 };
            int k = 10;

            Console.WriteLine("\nOptimal Approach:");
            foreach (var sub in Findsub(arr, k))
                Console.WriteLine($"[{string.Join(", ", sub)}]");


            Console.WriteLine("\nUsing LINQ:");
            foreach (var sub in UsingLinq(arr, k))
                Console.WriteLine($"[{string.Join(", ", sub)}]");

            //tc : O(n2) in worst case as if k value is larger than all subarry in res
            //sc  O(n) for storing the subsarrys
        }
    }
}
