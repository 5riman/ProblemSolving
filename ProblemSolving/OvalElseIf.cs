using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class OvalElseIf
    {
        public static void Main(string [] args)
        {
            string Alphabet;
            Console.WriteLine("Enter the Alphabet");
            Alphabet = Console.ReadLine().ToLower();
            if(Alphabet=="a")
            {
                Console.WriteLine("Its is oval");
            }
            else if(Alphabet=="e")
            {
                Console.WriteLine("Its is oval");
            }
            else if (Alphabet == "i")
            {
                Console.WriteLine("Its is oval");
            }
            else if (Alphabet == "o")
            {
                Console.WriteLine("Its is oval");
            }
            else if (Alphabet == "u")
            {
                Console.WriteLine("Its is oval");
            }
            else
                Console.WriteLine("Its is consonent");


        }
    }
}
