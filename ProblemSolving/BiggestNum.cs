using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class BiggestNum
    {
        public static void Main(string [] args)
        {
            int Num1, Num2;
            Console.WriteLine("Enter two numbers:");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Num2 = Convert.ToInt32(Console.ReadLine());
            if (Num1 > Num2)
            {
                Console.WriteLine(Num1 + " is greater then " + Num2);
            }
            else
            {
                Console.WriteLine(Num2 + " is greater then " + Num1);

                }
            }
            
        }
    }

