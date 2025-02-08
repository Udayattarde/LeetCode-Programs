using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Strivers.Arrays
{
    public static class findIntersection
    {

        public static void intersetionBrute()
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arr2 = { 2, 3, 4, 4, 5, 11, 12 };

            List<int> ans = new List<int>();
            List<int> visited = new List<int>(new int[arr2.Length]);

            for(int i = 0; i<arr1.Length; i++)
            {
                for(int j=0;j<arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j] && visited[j] == 0) {

                        ans.Add(arr2[j]);
                        visited[j] = 1;
                        break;
                    }
                    else if (arr2[j] > arr1[i])
                    {
                        break; // because array is sorted, element will not be beyond this
                    }
                }
            }

            ans = arr1.Intersect(arr2).ToList();
            Console.WriteLine(string.Join(", ", ans));
        }

        public static void intersetionOptimal()
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arr2 = { 2, 3, 4, 4, 5, 11, 12 };

            List<int> ans = new List<int>();
            int i = 0; 
            int j = 0;

            while (i < arr1.Length && j < arr2.Length) {

                if (arr1[i] < arr2[j])
                    i++;
                else if (arr2[j] < arr1[i])
                    j++;
                else
                {
                    //when both are equal
                    ans.Add(arr1[i]);
                    i++;
                    j++;
                }
            
            }
            Console.WriteLine("string.Join");
            Console.WriteLine(string.Join(" ", ans));
        }
    }
}
