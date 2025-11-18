using System;

// Define the Calculator class
class Calculator
{
    // Void method that prints a welcome message
    public void PrintWelcome()
    {
        Console.WriteLine("Welcome to the Calculator");
    }

    // Method to add two numbers and return the result
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    // Method to multiply two numbers
    // num2 is optional and defaults to 1 if not provided
    public int Multiply(int num1, int num2 = 1)
    {
        return num1 * num2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an object of the Calculator class
        Calculator calc = new Calculator();

        // Call the welcome method
        calc.PrintWelcome();

        // Call the Add method and print the result
        int additionResult = calc.Add(10, 20);
        Console.WriteLine("Addition Result: " + additionResult);

        // Call the Multiply method with two parameters
        int multiplicationResult1 = calc.Multiply(5, 4);
        Console.WriteLine("Multiplication Result (5 * 4): " + multiplicationResult1);

        // Call the Multiply method with only one parameter (num2 = default value 1)
        int multiplicationResult2 = calc.Multiply(7);
        Console.WriteLine("Multiplication Result (7 * default 1): " + multiplicationResult2);
    }
}
