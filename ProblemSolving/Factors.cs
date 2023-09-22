using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class Factors
    {
        public static void Main(string[] args)
        {
            int N,count=0;
            Console.WriteLine("Enter the value of N");
            N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                if(N%i==0)
                {
                    if(N/i!=i)
                    {

                        Console.WriteLine(i);
                        count++;                 
                            }
                }
            }
            Console.WriteLine("Count is " + count);
            
        }
    }
}
