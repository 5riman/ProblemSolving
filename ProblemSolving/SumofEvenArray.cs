using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class SumofEvenArray
    {
        static void Main(string[] args)
        {

            int size, Esum = 0,Osum=0;
            Console.WriteLine("Enter size:");
            size = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[size];
            Console.WriteLine("Enter Elements:");
            for (int i = 0; i < size; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < size; i++)
            { 

                if (A[i] % 2 == 0)
                {
                    Esum += A[i];
                }
                else
                {
                    Osum += A[i];
                }
               
            }
            Console.WriteLine("Total Even Sum:" + Esum);
            Console.WriteLine("Total odd Sum:" + Osum);
        }
    }
}
