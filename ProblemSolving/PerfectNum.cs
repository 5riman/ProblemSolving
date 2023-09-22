using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class PerfectNum
    {
        public static void Main(string[] args)
        {
            int N, sum = 0;
            Console.WriteLine("Enter the value of N");
            N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= Math.Sqrt(N); i++)
            {
                if (N % i == 0)
                {
                    sum += i;
                    if (N / i != i)
                    {
                        sum += N / i;
                    }

                } 
            }
            if (N * 2 == sum)
            {
                Console.WriteLine("It is Perfect Num");
            }
            else
            {
                Console.WriteLine("Not perfect Num");
            }
        }
    }
}
