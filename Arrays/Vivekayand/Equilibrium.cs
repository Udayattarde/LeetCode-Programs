using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Vivekayand
{
    public static class Equilibrium
    {
        //using linq also
        public static void EquiIndex()
        {
            int[] arr = { -7, 1, 5, 2, -4, 3, 0 };

            int leftsum = 0;
            int rightsum = arr.Sum();

           
            int idx = 0;
             int n = arr.Length;

            while (idx < n) { 
              
                rightsum -= arr[idx];

                if(leftsum == rightsum)
                {
                    Console.WriteLine("Equilibrium Index: " + idx + " Equilibrium Value: " + arr[idx]);
                    break;
                }

                leftsum += arr[idx];
                idx++;
            
            
            }
        }
       

    }
}
