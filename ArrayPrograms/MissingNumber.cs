using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayPrograms
{
    internal class MissingNumber
    {
        // XOR-based approach
        static int MissingNumberXOR(List<int> a, int N)
        {
            int xor1 = 0, xor2 = 0;

            for (int i = 0; i < N - 1; i++)
            {
                xor2 ^= a[i]; 
                xor1 ^= (i + 1); 
            }
            xor1 ^= N; 

            return (xor1 ^ xor2); 
        }

        // LINQ-based approach
        static int MissingNumberLINQ(List<int> a, int N)
        {
            int actualSum = Enumerable.Range(1, N).Sum();
            int arraySum = a.Sum();

            return actualSum - arraySum; 
        }

        // Linear search approach
        static int MissingNumberLinear(List<int> a, int N)
        {
            for (int i = 1; i <= N; i++)
            {
                bool flag = false;

                for (int j = 0; j < N - 1; j++)
                {
                    if (a[j] == i)
                    {
                        flag = true;
                        break;
                    }
                }

                if (!flag) return i;
            }

          
            return -1;
        }

        static void Main()
        {
            int N = 5;
            List<int> a = new List<int> { 1, 2, 4, 5 };

            // Using XOR-based approach
            int missingNumberXOR = MissingNumberXOR(a, N);
            Console.WriteLine("Missing number (XOR-based): " + missingNumberXOR);

            // Using LINQ-based approach
            int missingNumberLINQ = MissingNumberLINQ(a, N);
            Console.WriteLine("Missing number (LINQ-based): " + missingNumberLINQ);

            // Using Linear search approach
            int missingNumberLinear = MissingNumberLinear(a, N);
            Console.WriteLine("Missing number (Linear search): " + missingNumberLinear);
        }
    }
}
