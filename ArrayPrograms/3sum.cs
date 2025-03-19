using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ArrayPrograms
{
    internal class _3sum
    {

        public static List<List<int>> FindTripletsBruteForce(int[] arr)
        {
            List<List<int>> result = new List<List<int>>();
            int n = arr.Length;

            for (int i = 0; i < n - 2; i++)
            {
                for (int j = i + 1; j < n - 1; j++)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        if (arr[i] + arr[j] + arr[k] == 0)
                        {
                            List<int> triplet = new List<int> { arr[i], arr[j], arr[k] };
                            triplet.Sort();
                            if (!result.Contains(triplet))
                            {
                                result.Add(triplet);
                            }
                        }
                    }
                }
            }
            return result;
        }

//        Time Complexity: O(n^3) - Three nested loops each iterating over the array.

//Space Complexity: O(k) - Where k is the number of unique triplets found.

        static List<List<int>> FindTripletsOptimal(int[] arr)
        {

            List<List<int>> res = new List<List<int>>();

            Array.Sort(arr);
            int n = arr.Length;
            for (int i = 0; i < n - 2; i++)
            {
                if (i > 0 && arr[i] == arr[i - 1]) continue;

                int left = i + 1;
                int right = n - 1;

                while (left < right)
                {
                    int sum = arr[i] + arr[left] + arr[right];

                    if (sum == 0)
                    {
                        res.Add(new List<int> { arr[i], arr[left], arr[right] });

                        while (left < right && arr[left] == arr[left + 1]) left++;
                        while (left < right && arr[right] == arr[right - 1]) right--;
                        left++;
                        right--;

                    }
                    else if (sum < 0)
                    {

                        left++;

                    }
                    else
                        right--;
                }
            }
            return res;
        }

//        Time Complexity: O(n^2) - Sorting the array takes O(n log n) and finding triplets takes O(n^2).

//Space Complexity: O(k) - Space is only used to store the answer, which final O(1) for storing the answer

        public static List<List<int>> FindTripletsUsingLinq(int[] arr)
        {
            List<List<int>> result = new List<List<int>>();
            Array.Sort(arr);
            int n = arr.Length;

            for (int i = 0; i < n - 2; i++)
            {
                if (i > 0 && arr[i] == arr[i - 1]) continue;

                int left = i + 1, right = n - 1;

                while (left < right)
                {
                    int sum = arr[i] + arr[left] + arr[right];

                    if (sum == 0)
                    {
                        result.Add(new List<int> { arr[i], arr[left], arr[right] });
                        while (left < right && arr[left] == arr[left + 1]) left++;
                        while (left < right && arr[right] == arr[right - 1]) right--;
                        left++;
                        right--;
                    }
                    else if (sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            return result.Distinct().ToList();
        }

            static void Main(string[] args)
        {
            int[] arr = { -1, 0, 1, 2, -1, -4 };

            Console.WriteLine("Brute Force:");
            var tripletsBruteForce = FindTripletsBruteForce(arr);
            foreach (var triplet in tripletsBruteForce)
            {
                Console.WriteLine($"[{string.Join(", ", triplet)}]");
            }

            Console.WriteLine("Optimal:");
            var tripletsOptimal = FindTripletsOptimal(arr);
            foreach (var triplet in tripletsOptimal)
            {
                Console.WriteLine($"[{string.Join(", ", triplet)}]");
            }


            Console.WriteLine("LINQ:");
            var tripletsLinq = FindTripletsUsingLinq(arr);
            foreach (var triplet in tripletsLinq)
            {
                Console.WriteLine($"[{string.Join(", ", triplet)}]");


            }
            }
        }
    }


