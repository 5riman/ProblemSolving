using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class Ascendingarray
    {
        public static void Main(string[] args)
        {
            int size;
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
                for (int j = 0; j < size; j++)
                {
                    if (A[i] < A[j])
                    {
                        A[i] = A[i] + A[j];
                        A[j] = A[i] - A[j];
                        A[i] = A[i] - A[j];
                    }
                }
            }
            Console.WriteLine("Assending");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(A[i]);

            }
        }
    }
}



