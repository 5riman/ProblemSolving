using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class SumofNFactors
    {
        public static void Main(String[] args)
        {
            int N, sum = 0;
            Console.WriteLine("Enter the value of N");
            N=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= Math.Sqrt(N); i++)
            {
                if (N % i == 0 && N / i != i)
                {
                    sum = sum + i;
                    if (N / i != i)
                    {
                        sum = sum  + (N / i);
                    }

                }
                
            }
            Console.WriteLine("Sum of Factors are:" + sum);
        }
    }
}
