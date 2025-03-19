using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    public  class LeadersInArray
    {

        public static List<int> Findleadeers(int[] arr)
        {

            var leaders = new List<int>();

            int max = arr[^1];
            leaders.Add(max);
            for (int i = arr.Length - 2; i >= 0; i--) {


                if (arr[i] > max)
                {
                    max = arr[i];
                    leaders.Add(arr[i]);
                }
            
            
            }

            leaders.Sort();
            return leaders;
        }
            
            
                 
        
        static void Main(string[] args)
        {
            int[] arr = { 10, 22, 12, 3, 0, 6 };

            var leaders = Findleadeers(arr);

            Console.WriteLine("leaders\n" +string.Join(" ", leaders));

            //TC : o(n)  for iterating from back
            //SC : 0(n) There is no extra space being used in this approach. But, a O(N) of space for ans array will be used in the worst case 
        }
    }
}
