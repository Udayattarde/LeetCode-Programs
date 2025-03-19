using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    internal class NextPermutation
    {

        static void Next(int[] arr)
        {
            if (arr.Length == 0) return;

            int idx1 = 0;    
            int n  = arr.Length;

            for(int i = n-2;i>=0;i--)
            {
                if(arr[i] < arr[i+1])
                {
                    idx1 = i;
                    break;
                }
            }

            if(idx1 == 0 )
            {
                Array.Reverse(arr); 
            }
            else
            {
                int idx2 = 0;
                for(int i = n - 1; i > idx1; i--)
                {
                    if (arr[idx1] < arr[i])
                    {
                         idx2 = i;
                        break;
                    }
                    
                }

                swap(arr, idx1, idx2);
                Array.Sort(arr,idx1+1,n-(idx1+1));
            }


        }
        private  static void swap(int[] arr, int i, int j) { 
        
             int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;

        }
            static void Main(string[] args)
        {
            int[] arr = [3, 1, 4, 2];

            Next(arr);
            Console.WriteLine("Next Permutation is[ " +String.Join(" , ",arr)+"]");
        }
    }
}
