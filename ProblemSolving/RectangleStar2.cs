﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class RectangleStar2
    {

        static void Main()
        {
            
                int height = 5; 

                for (int i = 1; i <= height; i++)
                {
                   
                    for (int j = 1; j <= height - i; j++)
                    {
                        Console.Write(" ");
                    }

                    
                    for (int k = 1; k <= 2 * i - 1; k++)
                    {
                        if (k == 1 || k == 2 * i - 1 || i == height)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                Console.WriteLine();
            }



        }

    }
}

