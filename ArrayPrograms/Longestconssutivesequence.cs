using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace ArrayPrograms
{
    public class Longestconssutivesequence
    {

        public static int findconsecutive(int[] arr)
        {
            if(arr.Length == 0) return 0;

            var hashset = new HashSet<int>(arr);

            int longest = 1;
            foreach(int num in arr)
            {
                if (!hashset.Contains(num-1))
                {
                    int currentNumm = num;
                    int count = 1;

                    while (hashset.Contains(currentNumm + 1))
                    {
                        currentNumm = currentNumm + 1;  
                        count++;    
                    }
                    longest = Math.Max(longest, count);
                }

               
            }
            return longest;
        }
        static void Main(string[] args)
        {
            int[] arr = { 100, 200, 1, 2, 3, 4 };
            int result = findconsecutive(arr);
            Console.WriteLine($"The longest consecutive sequence is {result}");

        //tc : O(N) + O(2*N) ~ O(3*N), where N = size of the array.
//        Reason: O(N) for putting all the elements into the set data structure.After that for every starting element, we are finding the consecutive elements.Though we are using nested loops, the set will be traversed at most twice in the worst case.So, the time complexity is O(2 * N) instead of O(N2).

//Space Complexity: O(N), as we are using the set data structure to solve this problem.
                }
        }
}
