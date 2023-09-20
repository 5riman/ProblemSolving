using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class FirstNEven
    {
        public static void Main(string[] args)
        {
            int N=0;
            Console.WriteLine("Enter first N number");
            N=Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<=N;i=i+2)
            {
               Console.Write(i);
            }
            
        }
    }
}
