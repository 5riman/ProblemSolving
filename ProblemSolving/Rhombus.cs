﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class Rhombus
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
                    if (RowNum == 1 || RowNum == Rows || Star == 1 || Star == RowNum)
                        Console.Write("* ");
                    else
                        Console.Write("  ");

                    
                }
                Console.WriteLine();
            }
            for (RowNum = Rows-1; RowNum >= 1; RowNum--)
            {
                for (Space = RowNum; Space <= Rows; Space++)
                {
                    Console.Write(" ");
                }
                for (Star = 1; Star <= RowNum; Star++)
                {
                    if (RowNum == 1 || RowNum == Rows|| Star == 1 || Star == RowNum)
                        Console.Write("* ");
                    else
                        Console.Write("  ");

                }
                Console.WriteLine();
            }
        }
    }
}
