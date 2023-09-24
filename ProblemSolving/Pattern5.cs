using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class Pattern5
    {
        public static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Enter the value of N");
            N = Convert.ToInt32(Console.ReadLine());
            for (int RowNum = 1; RowNum <= N; RowNum++)
            {
                for (int ColNum = 1; ColNum <= RowNum; ColNum++)
                {
                    if (RowNum == 1 || ColNum == 1 || ColNum == RowNum)
                        Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
            for (int RowNum = N - 1; RowNum >= 1; RowNum--)
            {
                for (int ColNum = 1; ColNum <= RowNum; ColNum++)
                {
                    if (RowNum == 1 || RowNum == N || ColNum == 1 || ColNum == RowNum)
                        Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }

}
