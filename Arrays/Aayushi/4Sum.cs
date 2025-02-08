using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Arrays.Aayushi
{
    public static class _4Sum
    {

        public static void SumOptimal()
        {
            
                int[] nums = { 1, 0, -1, 0, -2, 2 };
                int target = 0;
              List<List<int>> res = new List<List<int>>();

            Array.Sort(nums);
                int n = nums.Length;

                for (int i = 0; i < n - 3; i++)
                {

                    if (i > 0 && nums[i] == nums[i - 1])
                        continue;

                    for (int j = i + 1; j < n - 2; j++)
                    {

                        if (j > i + 1 && nums[j] == nums[j + 1])
                            continue;

                        int sum = target - (nums[i] - nums[j]);

                        int l = j + 1;
                        int h = n - 1;

                        while (l < h)
                        {

                            if (nums[l] + nums[h] == sum)
                            {
                                res.Add(new List<int> { nums[i], nums[j], nums[l], nums[h] });

                                while (l < h && nums[l] == nums[l + 1])
                                    l++;

                                while (l < h && nums[h] == nums[h + 1])
                                    h--;

                                l++;
                                h--;

                            }
                            else if (nums[l] + nums[h] < sum)
                            {
                                l++;
                            }
                            else
                            {
                                h--;
                            }
                        }


                    }

                }

            foreach (var val in res)
            {
                Console.WriteLine(string.Join(" ", val));
            }
            //            Time Complexity Analysis
            //The time complexity of this solution is O(n ^ 3), where n is the length of the array.This is because:

            //The outer two loops run O(n^2) times.

            //The two-pointer technique inside the while loop runs in O(n) time.

            //Thus, the overall time complexity is O(n ^ 3).

            //Space Complexity: O(no.of quadruplets), This space is only used to store the answer. We are not using any extra space to solve this problem.So, from that perspective, space complexity can be written as O(1).


        }
    }
}





