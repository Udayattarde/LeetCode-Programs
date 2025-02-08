using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Strivers.Arrays
{
    public static class Triplet
    {

        public static void find()
        {

            //Find a triplet that sum to a given value same logic but with sum 
            #region optimal one
            List<List<int>> res = new List<List<int>>();

            int[] arr = { -1, 0, 1, 2, -1, -4 };
            int n = arr.Length;
            Array.Sort(arr);
            
            for(int i = 0;i< n-2;i++)
            {
                if (i > 0 && arr[i] == arr[i - 1])
                    continue;

                int j = i+1;
                int k = n - 1;

                while(j<k)
                {
                    int sum = arr[i] + arr[j]+arr[k];

                    if(sum > 0)
                    {
                        k--;
                    }
                    else if (sum < 0)
                    {
                        j++;
                    }
                    else
                    {
                        res.Add(new List<int> { arr[i], arr[j], arr[k] });
                        j++;
                        k--;

                        if (j < k && arr[j] == arr[j + 1]) j++;
                        if(j<k && arr[k] == arr[k+1])  k--;

                    }

                }
            }

            #endregion

            #region Hasing

            #endregion
            foreach ( var triplet in res)
            {
                Console.WriteLine($"[{string.Join(", ", triplet)}]");
            }

        }
    }
}
