using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    internal class SortBasedOnFrequencyAndValue
    {

        static List<int> sort(List<int> list)
        {
            var dict = new Dictionary<int, int>();

            foreach(int item in list)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict[item] = 1;
                }
            }

            list.Sort((n1, n2) =>
            {
                int freq1 = dict[n1];
                int freq2 = dict[n2];   

                if(freq1 != freq2)
                {
                    return freq2 - freq1;
                }

                return n1 - n2; 
            });

            return list;
        }

//        Counting Frequencies: O(n) - Iterates through the list once to count frequencies.

//Sorting: O(n log n) - Sorts the list based on frequency and value.

//Overall Time Complexity: O(n log n) due to the sorting step.

        static List<int> sortLinq(List<int> list)
        {
            //for output 
            // 10, 10, 10, 7, 7, 7, 11, 6, 5 
            return list.GroupBy(x => x)
                .OrderByDescending(x => x.Count())
                //.ThenBy(x => x.Key)
                .ThenByDescending(x =>x.Key)    //10, 10, 10, 7, 7, 7, 11, 6, 5 
                .SelectMany(x => x)
                .ToList();
        }
        static void Main(string[] args)
        {

            int[] arr = { 10, 7, 10, 11, 10, 7, 6, 5 };
            List<int> list = arr.ToList();

            var sortedlist = sort(list);
            var sortedLinq = sortLinq(list);
            Console.WriteLine("sorted lsit based on frequency ");
            Console.WriteLine(string.Join(" , ",sortedlist));
            Console.WriteLine(string.Join(" , ", sortedLinq));
        }


//        Time Complexity
//Grouping: O(n) - Iterates through the list once to create groups.

//Sorting: O(n log n) - Sorts the groups by frequency and value.

//Flattening: O(n) - Flattens the sorted groups back into a list.

//Overall Time Complexity: O(n log n) due to the sorting step.

//Space Complexity
//Grouping: O(n) - Requires space to store the groups.

//Sorting: O(n) - Requires space for the sorted list.

//Overall Space Complexity: O(n).
    }
}
