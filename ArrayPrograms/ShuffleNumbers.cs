using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ArrayPrograms
{
    internal class ShuffleNumbers
    {
        static void Shuffle(int[] nums) { 
        
           Random rnd = new Random();

            for (int i = 0; i < nums.Length; i++) { 
             
               int no = rnd.Next(nums.Length);  

                int temp = nums[i];
                nums[i] = nums[no];

                nums[no] = temp;
            
            }
            Console.WriteLine(string.Join(" ", nums));
        }
        static void Main(string[] args)
        {
            int[] arr = { 3, 7, 4, 1, 8, 9, 10 };

            for (int i = 0; i < 10; i++)
            {
                Shuffle(arr);
            }
//            Time & Space Complexity
//Time Complexity: O(N)(Each element is swapped once)
//Space Complexity: O(1)(In - place swapping, no extra space)


            Console.WriteLine("Linq");

            //linq
            arr = arr.OrderBy(_ => Guid.NewGuid()).ToArray();
            Console.WriteLine(string.Join(" ", arr));

            //Time Complexity: O(N log N) (Sorting with .OrderBy())
            //Space Complexity: O(N)(New array creation)
        }
    }
}
