using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.GFG
{
    public static class FirstRepeatingElement
    {
        public static void firstreepeting()
        {
            int[] arr = { 10, 5, 3, 4, 3, 5, 6 ,4,4};
            HashSet<int> seen = new HashSet<int>();

            foreach (int num in arr)
            {
                if (seen.Contains(num))
                {
                    Console.WriteLine("First repeating element is: " + num);
                    return;
                }
                seen.Add(num);
            }

            Console.WriteLine("No repeating elements found.");
        }
    }
}
