﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class Pattern4
    {
        public static void Main(string[] args)
        {
            int N,value=1;
            Console.WriteLine("Enter the value of N");
            N = Convert.ToInt32(Console.ReadLine());
            for (int RowNum = 1; RowNum <= N; RowNum++)
            {
                for (int ColumnNum = 1; ColumnNum<=RowNum; ColumnNum++)
                {
                    Console.Write(value++ + " ");
                }

                Console.WriteLine();
            }
            
        }
    }
}
