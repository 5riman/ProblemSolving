﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
     class MultiplicationTable
    {
        public static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Enter the value of N");
            N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(N +" *"+ i+ "="+N*i);
            }
                
        }
    }
}
