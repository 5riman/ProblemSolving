using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class EvenOddIf
    {
        
            public static void Main(string[] args)
            {
            int Num;
            Console.WriteLine("ENter the Number:");
            Num = Convert.ToInt32(Console.ReadLine());
            if (Num % 2 == 0)
            {
                Console.WriteLine("Num is Even");
            }
            else
            {
                Console.WriteLine("Num is Odd");
            }

            }
    }
}
