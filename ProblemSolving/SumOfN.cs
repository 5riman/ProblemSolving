using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
     class SumOfN
    {
        public static void Main(string[] args)
        {
            int N,sum=0;
            Console.WriteLine("Enter the value of N");
            N=Convert.ToInt32(Console.ReadLine());  
            for(int i=1;i<=N; i++)
            {
                sum=sum+i;
            }
            Console.WriteLine("Sum of N Natural Numbers" + sum);
               
        }

    }
}
