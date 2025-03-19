using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    public class MaxSubArray
    {
        class ArryImpl
        {
            public void MaxElementOfKSizeSubArray(int[] arr,int k)
            {
                if(arr.Length == 0 || k<=0 ||  k > arr.Length)
                {
                    return;
                }

                LinkedList<int> queue = new LinkedList<int>();
                int i;
                for (i = 0; i < k; i++) {

                    while (queue.Count > 0 && arr[i] >= arr[queue.Last.Value])
                    {
                        queue.RemoveFirst();    
                    }
                    queue.AddLast(i);   
                }

                for (; i < arr.Length; i++) {

                    Console.Write(arr[queue.First.Value] + " ");
                    while (queue.Count > 0 && i - k >= queue.First.Value)
                    {
                        queue.RemoveFirst();
                    }

                    while (queue.Count > 0 && arr[i] >= arr[queue.Last.Value])
                    {
                        queue.RemoveLast();
                    }

                    queue.AddLast(i);

                }
                Console.Write(arr[queue.First.Value]);
            }

        }
    
        static void Main(string[] args)
        {

            ArryImpl a = new ArryImpl();
            int[] arr = { 2, 5, 4, 3, 1, 7 };
            int k = 3;
            a.MaxElementOfKSizeSubArray(arr, k);
            Console.WriteLine();
            //linq
            var result = Enumerable.Range(0, arr.Length - k + 1)
                               .Select(i => arr.Skip(i).Take(k).Max());

            Console.WriteLine(string.Join(" ", result));
        }

        //time complexity : o(n) and brute is o(n*k) as k elements we need to find max elements
        //space complexity : o(k) for dequeue for optimal one 
    }
}
