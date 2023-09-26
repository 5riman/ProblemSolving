using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class Armstrong
    {
        public static void Main(string[] args)
        {
            int i, N1, N2, N3, N4, count, Rnum;
            Console.WriteLine("Enter the starting number:");
            N1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the ending number:");
            N2 = Convert.ToInt32(Console.ReadLine());
            for (i = N1; i <= N2; i++)
            {
                Rnum = 0;
                count = 0;
                N3 = i;
                while (N3 > 0)
                {
                    N3 = N3 / 10;
                    count++;
                }
                N4 = i;
                for (; N4 > 0;)
                {

                    int R = N4 % 10;
                    Rnum = Rnum + Convert.ToInt32(Math.Pow(R, count));
                    N4 = N4 / 10;
                }
                if (Rnum == i)
                {
                    Console.WriteLine(i + " ");
                }
            
        
    }
}
    }
}
