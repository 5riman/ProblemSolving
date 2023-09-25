using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
     class UserInputArray
    {
        static void Main(string[] args)
        {
            int Size;
            Console.Write("Enter Size of the Array ");
            Size = Convert.ToInt32(Console.ReadLine());
            int[] A1 = new int[Size];
            Console.Write("Enter {0} Elements into the Array ", Size);
            for (int i = 0; i < Size; i++)
            {
                A1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elements of Array are ");
            foreach (int X in A1)
            {
                Console.Write(X + "  ");
            }
        }
    }
}
