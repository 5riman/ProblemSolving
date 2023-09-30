using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class PalindromeNested
    {
        static void Main(string[] args)
        {
            int N, N1, Rnum, R;
            for (N = 50; N <= 100; N++)
            {
                N1 = N;
                Rnum = 0;
                R = 0;

                while (N1 > 0)
                {

                    R = N1 % 10;
                    Rnum = Rnum * 10 + R;
                    N1 = N1 / 10;


                }
                if (Rnum == N)
                    Console.WriteLine(N + "");

            }




    
}

    }
}
