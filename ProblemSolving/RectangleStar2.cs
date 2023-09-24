using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class RectangleStar2
    {

        static void Main()
        {
            Console.Write("Enter the length of the rectangle: ");
            int length = int.Parse(Console.ReadLine());

            Console.Write("Enter the breadth (width) of the rectangle: ");
            int breadth = int.Parse(Console.ReadLine());
            if (length != breadth)
            {

                for (int i = 0; i < breadth; i++)
                {
                    for(int j= 0; j < length; j++)
                    {
                        if ((i == j))
                        {
                            Console.Write("#");
                        }
                        else if(i == 0 || i == breadth - 1 || j == 0 || j == length - 1)
                        {

                            Console.Write("*");
                        }
                        else
                        {

                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }

                Console.ReadLine();
            }
            else
            {
                Console.Write("It is not Rectangle");
            }
        }

    }
}
