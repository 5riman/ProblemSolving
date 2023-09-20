using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class RecangleStar
    {
        static void Main()
        {
            Console.Write("Enter the length of the rectangle: ");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the breadth (width) of the rectangle: ");
            int breadth = Convert.ToInt32(Console.ReadLine());
            if (length > breadth)
            {
                // Loop through rows (height of the rectangle)
                for (int i = 0; i < breadth; i++)
                {
                    // Loop through columns (width of the rectangle)
                    for (int j = 0; j < length; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine(); // Move to the next line after each row
                }

                Console.ReadLine(); // Pause to see the result (you can remove this if not needed)
            }
            else
            {
                Console.Write("It is not Rectangle");
            }
        }

    }
}

