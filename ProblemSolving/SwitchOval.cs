using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class SwitchOval
    {
        public static void Main(string [] args)
        {
            string alpha;
            Console.WriteLine("Enter a alphabet:");
            alpha = Console.ReadLine().ToLower();
            switch (alpha)
            {
                case "a":
                    Console.WriteLine("oval");
                    break;
                case "e":
                    Console.WriteLine("oval");
                    break;
                case "i":
                    Console.WriteLine("oval");
                    break;
                case "o":
                    Console.WriteLine("oval");
                    break;
                case "u":
                    Console.WriteLine("oval");
                    break;
                default:
                    Console.WriteLine("Consonent");
                    break;
            }


        }
    }
}
