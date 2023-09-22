using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class Spaces1
    {
        public static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Enter the value of N");
            N = Convert.ToInt32(Console.ReadLine());
            for (int RowNum = 1; RowNum <= N; RowNum++)
            {
                for (int Space = RowNum; Space <= N-1; Space++)
                {
                    Console.Write(" ");
                   

                }
                for (int ColNum = 1; ColNum <= RowNum; ColNum++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }

}
