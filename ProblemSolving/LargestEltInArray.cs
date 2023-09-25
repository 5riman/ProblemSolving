using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class LargestEltInArray
    {
        public static void Main(string[] args)
        {
            int size,LargestElt,SecLargestElt;
            Console.WriteLine("Enter size:");
            size = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[size];
            Console.WriteLine("Enter Elements:");
            for (int i = 0; i < size; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            LargestElt = A[0];
           
            foreach(int X in A)
            {
                if(X>LargestElt)
                {
                    LargestElt = X;
                }

            }
            Console.WriteLine("Largest Elt in Array is: " + LargestElt);

        }
    }
}
