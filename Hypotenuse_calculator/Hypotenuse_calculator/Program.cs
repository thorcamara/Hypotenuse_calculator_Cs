﻿using System;

namespace Hypotenuse_calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter side A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt((a * a) + (b * b));

            Console.WriteLine("The hypotenuse is: " + c);

            Console.ReadKey();
        }
    }
}
