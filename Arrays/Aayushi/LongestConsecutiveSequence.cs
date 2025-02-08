using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Aayushi
{
    public static class LongestConsecutiveSequence
    {

        public static void FindLongest()
        {
            int[] nums = { 100, 4, 200, 1, 3, 2 };

            HashSet<int> set = new HashSet<int>(nums);
            int ans = 0;

            foreach (int x in nums) {

                if (!set.Contains(x - 1)) {

                    int no = x;
                    int count = 0;

                    while (set.Contains(no)) {
                        count++;
                        no++;
                    
                    }
                    ans = Math.Max(ans, count);
                
                }
            }

            Console.WriteLine($"Longest consecutive sequence length: {ans}");
        }
    }
}
