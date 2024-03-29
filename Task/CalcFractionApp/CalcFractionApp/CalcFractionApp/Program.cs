﻿using System;
using CalcFractionApp.Model;

namespace CalcFractionApp
{
    class Program
    {
        static void Main()

        {
            Convertor stroka = new Convertor();

            Fraction a = stroka.CreateFraction("1/2");
            Fraction b = stroka.CreateFraction("2/5");

            Calculator calc = new Calculator();
            var result = calc.Sum(a, b);

            ConsoleWrapper show = new ConsoleWrapper();
            Console.WriteLine($"{result.Numerator}/{result.Denominator}");

            Console.ReadKey();
        }
    }
}