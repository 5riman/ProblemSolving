using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class Factorial
    {
        public static void Main(string[] args)
        {
            int N, fact = 1;
            Console.WriteLine("Enter the value of N");
            N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                fact=fact*i;
            }
            Console.WriteLine("factorial " + fact);
        }
    }
}
