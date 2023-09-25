using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class NamesInArray
    {
        static void Main(string[] args)
        {
            int Size;
            Console.Write("Enter Size of the Array ");
            Size = Convert.ToInt32(Console.ReadLine());
            string[] Names = new string[Size];
            Console.Write("Enter " + Size + " Names into the Array");
            for (int i = 0; i < Size; i++)
            {
                Names[i] = Console.ReadLine();
            }
            Console.WriteLine("Names are ");
            //for (int i = 0; i < Size; i++)
            //{
            //    Console.Write(Names[i] + "  ");
            //}
            foreach (string X in Names)
            {
                Console.Write(X + "  ");
            }
        }
    }
}
