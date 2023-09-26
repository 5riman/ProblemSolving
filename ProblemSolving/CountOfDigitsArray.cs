using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class CountOfDigitsArray
    {
        static void Main(string[] carrot)
        {
            int count;
            int[] A1 = new int[6] { 2, 54, 238, 2109876, 54, 2145 };
            foreach (int X in A1)
            {
                count = 0;
                int X1 = X;
                while (X1 > 0)
                {
                    int R = X1 % 10;

                    X1 = X1 / 10;
                    count++;
                }
                Console.WriteLine("count of digits in an Array ELt :" + count);
            }
        }
    }
}
    
