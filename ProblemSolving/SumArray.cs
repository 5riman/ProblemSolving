using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class SumArray
    {
        public static void Main(string[] args)
        {
            int size,sum=0;
            Console.WriteLine("Enter size:");
            size = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[size];
            Console.WriteLine("Enter Elements:");
            for (int i=0;i<size;i++)
            {
                A[i]=Convert.ToInt32(Console.ReadLine());
            }
            foreach (int X in A)
            {
                sum = sum + X;
            }
            Console.WriteLine("Total Sum:"+sum);
        }
    }
}
