﻿using System;


namespace _09.Trapezoids
{
    class Program
    {
        static void Main()
        {
            double  a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = (a + b) * h /2;
            Console.WriteLine("{0:F7}",area);

        }
    }
}
