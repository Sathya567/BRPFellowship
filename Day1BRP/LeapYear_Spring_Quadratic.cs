using System;
using System.Collections.Generic;
using System.Text;

namespace Day1BRP
{
    class LeapYear_Spring_Quadratic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Welcome to Leap Year ***");
            Console.WriteLine("Enter the year: ");
            int Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Year: " + Year);
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
                Console.WriteLine("{0} is a Leap Year.", Year);
            else
                Console.WriteLine("{0} is not a Leap Year.", Year);
            Console.ReadLine();
            Console.WriteLine();
            //SpringSeason
            Console.WriteLine("*** Welcome to SpringSeason ***");
            Console.WriteLine("Enter Day: ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            switch (month)
            {
                case 3:
                    if (day >= 20 && day <= 31)
                    {
                        Console.WriteLine("True");
                    }
                    break;
                case 4:
                    if (day >= 1 && day <= 30)
                    {
                        Console.WriteLine("True");
                    }
                    break;
                case 5:
                    if (day >= 1 && day <= 31)
                    {
                        Console.WriteLine("True");
                    }
                    break;
                case 6:
                    if (day >= 1 && day <= 20)
                    {
                        Console.WriteLine("True");
                    }
                    break;
                default:
                    {
                        Console.WriteLine("False");
                    }
                    break;
            }
            Console.WriteLine();
            //Quadratic
            Console.WriteLine("*** Welcome to Quadratic ***");
            Console.WriteLine("Enter the value a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            double delta = (b * b) - (4 * a * c);
            if (delta < 0)
            {

                Console.WriteLine("Roots are imaginary");
            }
            else
            {
                double Root1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                double Root2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine("Root1: " + Root1);
                Console.WriteLine("Root2: " + Root2);
                double roots = a * Root1 * Root2 + b * Root1 + c;


            }




        }
    }
}
