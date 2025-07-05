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
            // This is a simple calculator program that performs basic arithmetic operations.
            // It allows the user to select an operation and then perform calculations based on that choice.
            // The program will continue to prompt the user until they choose to exit.
            bool exit = false;  // Flag to control the exit of the program


            Console.WriteLine("Welcome to the Calculator!");
            while (!exit)
            {
                
                Console.WriteLine("Please select an operation:");
                Console.WriteLine();
                Console.WriteLine("1. Add\n2.Subtract\n3.Multiply\n4.Divide\n5.Power\n6.SquareRoot\n7.Exit");

                Menu option = (Menu)int.Parse(Console.ReadLine());

                Console.WriteLine("You chose " + option);
                Console.WriteLine("Insert the first number you want to " + option + " :");
                double firstNumber = double.Parse(Console.ReadLine());
                Console.WriteLine("Insert the second number you want to " + option + " :");
                double secondNumber = double.Parse(Console.ReadLine());

                if(option == Menu.Exit)
                {
                    exit = true;  // Set exit flag to true to terminate the loop
                    Console.WriteLine("Exiting the calculator. Goodbye!");
                }
                else
                {
                    double result = 0;
                    switch (option)
                    {
                        case Menu.Add:
                            result = firstNumber + secondNumber;
                            break;
                        case Menu.Subtract:
                            result = firstNumber - secondNumber;
                            break;
                        case Menu.Multiply:
                            result = firstNumber * secondNumber;
                            break;
                        case Menu.Divide:
                            if (secondNumber != 0)
                                result = firstNumber / secondNumber;
                            else
                                Console.WriteLine("Error: Division by zero is not allowed.");
                            break;
                        case Menu.Power:
                            result = Math.Pow(firstNumber, secondNumber);
                            break;
                        case Menu.SquareRoot:
                            if (firstNumber >= 0)
                                result = Math.Sqrt(firstNumber);
                            else
                                Console.WriteLine("Error: Cannot calculate square root of a negative number.");
                            break;
                        default:
                            Console.WriteLine("Invalid option selected.\n");
                            continue; // Skip to the next iteration of the loop
                    }
                    Console.WriteLine($"The result of {option} is: {result}\n");
                }
            }
        }

    }
}