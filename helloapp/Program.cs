using System;
using MyCalc;
namespace helloapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to Jenkins");
            Calc calc = new Calc();
            Console.WriteLine($"Multiply = {calc.multiply(4,5)}");
            Console.ReadLine();
        }
    }
}
