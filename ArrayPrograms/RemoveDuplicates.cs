using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    internal class RemoveDuplicates
    {

        public static List<int> RemoveDuplicatesBruteForce(List<int> sortedList)
        {
            List<int> resultList = new List<int>();

            foreach (var num in sortedList)
            {
                if (!resultList.Contains(num))
                {
                    resultList.Add(num);
                }
            }

            return resultList;
        }

        //        Time Complexity: O(n^2) - The Contains method checks the list for each element, leading to quadratic time complexity.

        //Space Complexity: O(n) - Requires extra space for the result list.


        public static List<int> RemoveDuplicatesUsingLinq(List<int> sortedList)
        {
            return sortedList.Distinct().ToList();
        }



        //        Time Complexity: O(n) - The Distinct method traverses the list once.

        //Space Complexity: O(n) - Requires extra space for the distinct list.


        public static List<int> RemoveDuplicatesOptimal(List<int> arr)
        {
            if (arr.Count <= 1)
            {
                return arr;
            }

            int start = 1;

            for (int i = 1; i < arr.Count; i++)
            {
                if (arr[i] != arr[i - 1])
                {
                    arr[start++] = arr[i];
                }
            }

            arr.RemoveRange(start, arr.Count - start);
            return arr;
        }

//        Time Complexity: O(n) - Single pass through the list with two pointers.

//Space Complexity: O(1) - In-place removal of duplicates, no additional space

            static void Main(string[] args)
        {
            List<int> sortedList = new List<int> { 1, 1, 2, 2, 3, 4, 4, 5 };

            var bruteForceResult = RemoveDuplicatesBruteForce(sortedList);
            Console.WriteLine("Brute Force Result: " + string.Join(", ", bruteForceResult));

            var optimalResult = RemoveDuplicatesOptimal(sortedList);
            Console.WriteLine("Optimal Result: " + string.Join(", ", optimalResult));

            var linqResult = RemoveDuplicatesUsingLinq(sortedList);
            Console.WriteLine("LINQ Result: " + string.Join(", ", linqResult));
        }
    }
}
