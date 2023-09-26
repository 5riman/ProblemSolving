using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class ReverseDigit
    {
        public static void Main(string[] args)
        {
            int N, Rnum = 0;
            Console.WriteLine("Enter any Digit number");
            N = Convert.ToInt32(Console.ReadLine());
            while (N > 0)
            {
                int R = N % 10;
                Rnum = Rnum * 10 + R;
                N = N / 10;



            }
            Console.WriteLine("Reversed Number is " + Rnum);
        }
    }
}
    

