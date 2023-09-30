using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class Fibonoci
    {
        public static void Main(string[] args)
        {
            int N, a = 0, b = 1, temp;
            Console.WriteLine("Enter the range numbwer:");
            N = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                if (i <= 1)
                {
                    temp = i;
                }
                else
                    temp = a + b;
                a = b;
                b = temp;
                Console.WriteLine(temp + "");

            }
        }
    }
}
