using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class NoOfDigits
    {
        public static void Main(string[] args)
        {
            int Num,DigitCount;
            Console.WriteLine("ENter the Number:");
            Num = Convert.ToInt32(Console.ReadLine());
            if (Num == 0)
            {
                DigitCount = 1;
                Console.WriteLine("DigitCount is" + DigitCount);
            }
            else if (Num < 10)
            {
                DigitCount = 1;
                Console.WriteLine("DigitCount is" + DigitCount);
            }
            else if (Num < 100)
            {
                DigitCount = 2;
                Console.WriteLine("DigitCount is" + DigitCount);
            }
            else if (Num < 1000)
            {
                DigitCount = 3;
                Console.WriteLine("DigitCount is" + DigitCount);
            }
            else if (Num < 10000)
            {
                DigitCount = 4;
                Console.WriteLine("DigitCount is" + DigitCount);
            }
            else if (Num < 100000)
            {
                DigitCount = 5;
                Console.WriteLine("DigitCount is" + DigitCount);
            }
            else
                Console.WriteLine("The number is more than  5 digits");

        }
        
    }
}
