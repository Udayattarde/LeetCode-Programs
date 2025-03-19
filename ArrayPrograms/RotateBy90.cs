using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    

    public class RotateBy90
    {

        static void RotateMatrix(int[][] matrix)
        {
            int n = matrix.Length;
            for(int i=0;i<n;i++)
            {
                for(int j = 0; j < i; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;    
                }
            }

            for (int i = 0; i < n; i++) {
                Array.Reverse(matrix[i]);
            
            }
        }
        static void Main(string[] args)
        {
            int[][] matrix = new int[][]
            {
            new int[] {1, 2, 3},
            new int[] {4, 5, 6},
            new int[] {7, 8, 9}
            };

            RotateMatrix(matrix);

            Console.WriteLine("Rotated Image:");
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }

//            TC: O(N * N) + O(N * N).One O(N * N) is for transposing the matrix and the other is for reversing the matrix.


//Space Complexity: O(1).
        }
    }
}
