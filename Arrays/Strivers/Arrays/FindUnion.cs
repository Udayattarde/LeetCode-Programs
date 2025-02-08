using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Strivers.Arrays
{
    public static class FindUnion
    {

        public static void UnionBrute()
        {
            int n = 10, m = 7;
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arr2 = { 2, 3, 4, 4, 5, 11, 12 };

            HashSet<int> set = new HashSet<int>();
            List<int> union = new List<int>();

            for (int i = 0; i < n; i++)
                set.Add(arr1[i]);

            for (int i = 0; i < m; i++)
                set.Add(arr2[i]);

            foreach (var item in set)
                union.Add(item);


            union = arr1.Union(arr2).ToList();
            Console.Write(string.Join(", ", union));


            //TC: O(n + m), where n is the size of the first array and m is the size of the second array. The reason for this is that we have to check each element in both arrays.
            //            The ToList method converts the resulting set into a list. This operation also involves iterating through each element.

            //Time Complexity: O(n + m) since it involves iterating over the entire set once.

            //            Space Complexity
            //HashSet Storage: The Union method uses a HashSet to store unique elements. The maximum size of the HashSet will be the sum of the sizes of both arrays.

            //Space Complexity: O(n + m), as it needs to store all unique elements from both arrays.

            //List Storage: The ToList method creates a new list containing all the elements in the HashSet.

            //Space Complexity: O(n + m), as it needs to store all elements from the HashSet in the list.

            //Overall, the space complexity is O(n + m) since both the HashSet and the resulting list need to store all unique elements from the input arrays.
            //Note: O(1) { If Space of union ArrayList is not considered}


        }

        public static void UnionOptimal()
        {
            int n = 10, m = 7;
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arr2 = { 2, 3, 4, 4, 5, 11, 12 };

            List<int> union = new List<int>();

            int i = 0;
            int j = 0;
           
            while(i < arr1.Length  && j < arr2.Length)
            {
                if (arr1[i] <= arr2[j])
                {
                    if (union.Count == 0 || union[union.Count - 1] != arr1[i])
                    {
                        
                            union.Add(arr1[i]);
                        
                       
                    }
                    i++;

                }
                else
                {
                    if (union.Count == 0 || union[union.Count - 1] != arr2[j])
                    {
                        
                       union.Add(arr2[i]);
                        
                       
                    }
                    j++;
                }
            }

            while(i< n)
            {
                if (union[union.Count - 1] != arr1[i])
                {
                    {
                        union.Add(arr1[i]);
                    }
                    i++;
                }
            }

            while (j< m)
            {
                if (union[union.Count - 1] != arr2[j])
                {
                    {
                        union.Add(arr2[j]);
                    }
                    j++;
                }
            }

            Console.Write(string.Join(" ", union));
        }
    }
}
