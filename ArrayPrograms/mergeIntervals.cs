using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    internal class mergeIntervals
    {

        static List<List<int>> mergeIntervals1(List<List<int>> intervals)
        {
            List<List<int>> res = new List<List<int>>();

            if (intervals.Count == 0) return res;

            intervals.Sort((a,b)=> a[0].CompareTo(b[0]) );

            List<int> curr = intervals[0];
            for(int i = 1; i < intervals.Count; i++)
            {
                if (curr[1] < intervals[i][0])
                {
                    res.Add(curr);
                    curr = intervals[i];
                }
                else
                {
                    curr[i] = Math.Max(curr[1],intervals[i][1]);
                }
            }
            res.Add(curr);
            return res;
        }
        static void Main(string[] args)
        {

            List<List<int>> list = new List<List<int>>
            {
                new List<int>{1,3},
                new List<int>{2,6},
                new List<int>{8,10},
                new List<int> {15,18},
            };

            foreach (var num in list)
            {
                Console.WriteLine($"[{String.Join(" , ", num)}]");
            }

            Console.WriteLine("After Mergeing");

            var result = mergeIntervals1(list);
            foreach (var num in result)
            {
                Console.WriteLine($"[{String.Join(" , ", num)}]");
            }
        }
                
    }
}
