using System;
using System.ComponentModel;

namespace CalculatorCMD
{
    class Program
    {
        enum Menu
        {
            Add,
            Subtract,
            Multiply,
            Divide,
            Power,
            SquareRoot,
            Exit
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator!");
            Console.WriteLine("Please select an operation:");
            Console.WriteLine("1. Add\n2.Subtract\n3.Multiply\n4.Divide\n5.Power\n6.SquareRoot\n7.Exit");
        }
    }
}