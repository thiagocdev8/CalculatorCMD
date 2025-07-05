using System;
using System.ComponentModel;

namespace CalculatorCMD
{
    class Program
    {
        enum Menu
        {
            Add = 1,
            Subtract = 2,
            Multiply = 3,
            Divide = 4,
            Power = 5,
            SquareRoot = 6,
            Exit = 7
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator!");
            Console.WriteLine("Please select an operation:");
            Console.WriteLine();
            Console.WriteLine("1. Add\n2.Subtract\n3.Multiply\n4.Divide\n5.Power\n6.SquareRoot\n7.Exit");

            Menu option = (Menu)int.Parse(Console.ReadLine());

            Console.Write(option);
        }
    }
}