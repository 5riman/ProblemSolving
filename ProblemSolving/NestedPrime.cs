using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class NestedPrime
    {
        public static void Main(string[] args)
        {
            int N, N1, N2, count;
            N1 = Convert.ToInt32(Console.ReadLine());
            N2 = Convert.ToInt32(Console.ReadLine());

            for (N = N1; N <= N2; N++)
            {
                count = 0;
                for (int i = 1; i <= Math.Sqrt(N); i++)
                {
                    if (N % i == 0)
                    {
                        count++;
                        if (N / i != i)
                        {
                            count++;
                        }
                    }

                }
                if (count == 2)
                {
                    Console.WriteLine(N + " ");

                }
            }
        }
    }
}
