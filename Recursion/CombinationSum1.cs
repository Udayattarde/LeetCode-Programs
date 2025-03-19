using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Solution1
    {

        private void findCombination(int idx, int[] arr, int target, List<List<int>> lst, List<int> ds)
        {
            if (idx == arr.Length)
            {
                if (target == 0)
                {
                    lst.Add(new List<int>(ds));
                }

                return;
            }

            if (arr[idx] <= target)
            {
                ds.Add(arr[idx]);
                findCombination(idx, arr, target - arr[idx], lst, ds);
                ds.RemoveAt(ds.Count - 1);
            }
            findCombination(idx + 1, arr, target, lst, ds);

        }
        public List<List<int>> Combination(int[] arr, int target)
        {
            List<List<int>> lst = new List<List<int>>();
            List<int> ds = new List<int>();

            findCombination(0, arr, target, lst, ds);
            return lst;
        }
    }
    public class CombinationSum1
    {
        static void Main(string[] args)
        {
            int[] v = { 2, 3, 6, 7 };
            Solution1 soln = new Solution1();
            int target = 7;

            List<List<int>> ans = soln.Combination(v, target);
            Console.WriteLine("Combinations are:");
            foreach (var combination in ans)
            {
                Console.WriteLine(string.Join(" ", combination));
            }

        }
    }
}
