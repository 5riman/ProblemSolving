﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class PyramidPattern
    {
        public static void Main(string[] args)
        {
            int RowNum, Rows, Star, Space;
            Console.Write("Enter Number of Rows ");
            Rows = Convert.ToInt32(Console.ReadLine());
            for (RowNum = 1; RowNum <= Rows; RowNum++)
            {
                for (Space = RowNum; Space <= Rows; Space++)
                {
                    Console.Write(" ");
                }
                for (Star = 1; Star <= RowNum; Star++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
