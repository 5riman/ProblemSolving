using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class Array1
    {


        //        //            int Breadth, Length;
        //        //            Breadth = Convert.ToInt32(Console.ReadLine());
        //        //            Length = Convert.ToInt32(Console.ReadLine());
        //        //            for (int i = 1; i<=Breadth; i++)
        //        //            {
        //        //                for (int j= 1; j <=Length; j++)
        //        //                {
        //        //                    if (i == 1 || i == Breadth|| j == 1 || j == Length)
        //        //                    {


        //        //                         Console.Write("*");
        //        //                    }
        //        //                    else
        //        //                    {
        //        //                        Console.Write(" ");
        //        //                    }
        //        //                }
        //        //                Console.WriteLine();
        //        //            }
        //        //        }
        //        //    }
        //        //}

        //        static void Main()
        //        {

        //            DrawSquare(10);

        //        }

        //        public static void DrawSquare(int sideLength)
        //            {
        //                for (int row = 1; row <= sideLength; row++)
        //                {

        //                    for (int col = 1; col <= sideLength; col++)
        //                    {
        //                        if ((col == row) || (col + row == sideLength + 1))
        //                        {
        //                            Console.Write("#");
        //                        }
        //                        else if (col == 1 || row == 1 || col == sideLength || row == sideLength)
        //                        {
        //                            Console.Write("*");
        //                        }
        //                        else
        //                        {
        //                            Console.Write(" ");
        //                        }
        //                    }
        //                Console.WriteLine();
        //            }
        //            }
        //        }
        //    }
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 0, 19, 2, 3, 13, 9, 5 };
            int small = int.MaxValue;
            int second = int.MaxValue;
            foreach (int i in myArray)
            {
                if (i < small)
                {
                    second = small;
                    small = i;
                }
                else if (i < second)
                    second = i;
            }

            System.Console.WriteLine(second);
        }
    }
}




