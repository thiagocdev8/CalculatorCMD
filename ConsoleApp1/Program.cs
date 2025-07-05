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

        // Variable to store the result of calculations
        static void Main(string[] args)
        {
            // This is a simple calculator program that performs basic arithmetic operations.
            // It allows the user to select an operation and then perform calculations based on that choice.
            // The program will continue to prompt the user until they choose to exit.
            bool exit = false;  // Flag to control the exit of the program


            Console.WriteLine("Welcome to the Calculator!");
            while (!exit)
            {
                double result = 0; // Initialize result variable for each iteration
                string resultDescription = "";
                Console.WriteLine("Please select an operation:");
                Console.WriteLine();
                Console.WriteLine("1. Add\n2.Subtract\n3.Multiply\n4.Divide\n5.Power\n6.SquareRoot\n7.Exit");

                Menu option = (Menu)int.Parse(Console.ReadLine());

                Console.WriteLine("You chose " + option);

                if (option == Menu.Power)
                {
                    Console.WriteLine("Insert the number you want to " + option + " :");
                    double firstNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine("Insert the number you want to power by:");
                    double secondNumber = double.Parse(Console.ReadLine());

                    result = Math.Pow(firstNumber, secondNumber);
                    resultDescription = $"{firstNumber} raised to the power of {secondNumber} is {result}.";
                } 
                else if (option == Menu.SquareRoot)
                {
                    Console.WriteLine("Insert the number you want to " + option + " :");
                    double firstNumber = double.Parse(Console.ReadLine());
                    // No second number needed for square root operation
                    if (firstNumber >= 0)
                    {
                        result = Math.Sqrt(firstNumber);
                        resultDescription = $"The square root of {firstNumber} is {result}.";
                    }
                    else
                        Console.WriteLine("Error: Cannot calculate square root of a negative number.");
                } 
                else if(option == Menu.Exit)
                {
                    exit = true;  // Set exit flag to true to terminate the loop
                    Console.WriteLine("Exiting the calculator. Goodbye!");
                }
                else
                {
                    Console.WriteLine("Insert the first number you want to " + option + " :");
                    double firstNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine("Insert the second number you want to " + option + " :");
                    double secondNumber = double.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case Menu.Add:
                            result = firstNumber + secondNumber;
                            resultDescription = $"{firstNumber} + {secondNumber} = {result}.";
                            break;
                        case Menu.Subtract:
                            result = firstNumber - secondNumber;
                            resultDescription = $"{firstNumber} - {secondNumber} = {result}.";
                            break;
                        case Menu.Multiply:
                            result = firstNumber * secondNumber;
                            resultDescription = $"{firstNumber} x {secondNumber} = {result}.";
                            break;
                        case Menu.Divide:
                            if (secondNumber != 0)
                            {
                                result = firstNumber / secondNumber;
                                resultDescription = $"{firstNumber} divided by {secondNumber} = {result}.";
                            }
                            else
                            {
                                Console.WriteLine("Error: Division by zero is not allowed.");
                            }  
                            break;
                        default:
                            Console.WriteLine("Invalid option selected.\n");
                            continue; // Skip to the next iteration of the loop
                    }
                    
                }

                // Display the result of the operation
                    Console.WriteLine($"{resultDescription}\n");
                
            }
        }

    }
}