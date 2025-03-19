using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
     
    public class PrintallPermutations
    {
        static void RecurPermute(int[]arr,List<int> ds,List<List<int>> ans, bool[] frq)
        {
            if(ds.Count == arr.Length)
            {
                ans.Add(new List<int>(ds));
                return;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (!frq[i])
                {
                    ds.Add(arr[i]);
                    frq[i] = true;

                    RecurPermute(arr, ds, ans, frq);
                    frq[i] = false;
                    ds.RemoveAt(ds.Count - 1);

                }
            }
        }
        static List<List<int>> Permute(int[] arr)
        {
            List<List<int>> ans = new List<List<int>>();
            List<int> ds = new List<int>();
            bool[] freq = new bool[arr.Length];
            RecurPermute(arr,ds,ans,freq);
            return ans;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };

            List<List<int>> res = Permute(arr);
            foreach(var i in res)
            {
                Console.WriteLine(string.Join(",", i));
            }
        }
    }
}
