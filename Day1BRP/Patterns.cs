using System;
using System.Collections.Generic;
using System.Text;

namespace Day1BRP
{
    class Patterns
    {
        static void Main(string[] args)
        {
            int row, column, j = 6, i = 0;
            Console.Write("Pattern 'K'\n");
            for (row = 0; row <= 9; row++)
            {
                for (column = 0; column <= 7; column++)
                {
                    if (column == 0)
                        Console.Write("**");
                    else if ((row == column + 2) && column > 1)
                        Console.Write("***");
                    else if ((row == i && column == j) && column > 0)
                    {
                        Console.Write("***");
                        i = i + 1;
                        j = j - 1;
                    }
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n");
            Console.Write("Pattern 'D'\n");
            for (row = 0; row <= 9; row++)
            {
                for (column = 0; column <= 7; column++)
                {
                    if (column == 1 || ((row == 0 || row == 9) && (column > 1 && column < 4)))
                        Console.Write("**");
                    else if (column == 7 && row != 0 && row != 9)
                        Console.Write("**");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            Console.Write("Pattern 'W' ");
            Console.Write("\n");
            //Console.WriteLine("Enter the line: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 9; column++)
                {
                    if ((column == 0 || column == 8))
                        Console.Write("*");
                    else if (column == 4 && row == 2)
                        Console.Write("*");
                    else if (((column == 5 || column == 3) && row == 3) || ((column == 6 || column == 2) && row == 4) || ((column == 7 || column == 1) && row == 5))
                        Console.Write("*");

                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
}
   
