using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{

     class Solution
    {

        private void Solve(int i ,int j, int[][] maze ,int n ,List<string> ans,string move, int[,] vis, int[] di, int[] dj)
        {
            if(i == n-1 && j== n-1)
            {
                ans.Add(move);
                return;
            }

            string dir = "DLRU";
            for(int idx = 0;idx<4;idx++)
            {
                int nexti = i + di[idx];
                int nextj = j + dj[idx];    

                if(nexti >=0 && nextj >= 0 && nexti < n && nextj < n && vis[nexti,nextj]==0 && maze[nexti][nextj] == 1)
                {
                    vis[nexti,nextj] = 1;
                    Solve(nexti, nextj, maze, n, ans, move + dir[idx], vis, di, dj);
                    vis[nexti, nextj] = 0;
                }
            }
          
        }
        public List<string> FindPaths(int[][] maze ,int n )
        {
            List<string> ans = new List<string>();
            int[,] vis = new int[n, n];
            int[] di = { 1, 0, 0, -1 };
            int[] dj = { 0, -1, 1, 0 };

            if (maze[0][0]==1)
            {
                Solve(0, 0, maze, n, ans, "", vis, di, dj);
            }

            return ans;
        }
    }
    public class RatProblem
    {
        static void Main(string[] args)
        {
            int n = 4;
            int[][] maze =
            {
                new int[]{1,0,0,0},
                new int[]{1,1,0,0},
                new int[]{1,1,0,0},
                new int[]{0,1,1,1}
            };

            Solution path = new Solution();
            List<string> res = path.FindPaths(maze, n);

            if(res.Count == 0)
            {
                Console.WriteLine(-1);
            }
            else{
                Console.WriteLine(string.Join(" ",res));
            }


            //TC: 4*(m*n) all four direction we r visiting 
            //SC: recusion space auxiallary space i.e in worst space(m*n)
        }
    }
}
