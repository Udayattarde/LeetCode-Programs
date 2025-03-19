using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    internal class Sortarraybasedonfrequencyofvalue_If_frequency_is_same_then_sort_per_occurrence_
    {

        static List<int> sorted(List<int> list) { 
        
            var dict = new Dictionary<int, int>();

            foreach (var item in list) {
               if(dict.ContainsKey(item)) dict[item]++;
               else
                    dict[item] = 1;
            }


            list.Sort((n1, n2) =>
            {
                int freq1 = dict[n1];
                int freq2 = dict[n2];

                if (freq1 != freq2)
                {

                    return freq2 - freq1;
                }

                return list.IndexOf(n1) - list.IndexOf(n2);
            });


            return list;
         
        }

        static List<int> sortLinq(List<int> list) { 
        
           var freqMap = list.GroupBy(x => x).
                ToDictionary(g => g.Key, g => g.Count());

            return list.OrderByDescending(x => freqMap[x]).
                ThenBy(x => freqMap[x])
                .ToList();  
        
        
        }
        static void Main(string[] args)
        {
            int[] arr = { 10, 7, 10, 11, 10, 7, 6, 5 };
            List<int> list = arr.ToList();

            var sortedlist = sorted(list);
            var sortedLinq = sortLinq(list);
            Console.WriteLine("sorted lsit based on frequency ");
            Console.WriteLine(string.Join(" , ", sortedlist));
            Console.WriteLine(string.Join(" , ", sortedLinq));
        }
    }
}
