using System;

class Program
{
    static void Main()
    {
        int marks, total;

        // Asking user input for marks using TryParse
        Console.Write("Enter marks obtained: ");
        bool marksValid = int.TryParse(Console.ReadLine(), out marks);

        // Asking user input for total marks using TryParse
        Console.Write("Enter total marks: ");
        bool totalValid = int.TryParse(Console.ReadLine(), out total);

        // Validation check
        if (!marksValid || !totalValid || total == 0)
        {
            Console.WriteLine("Invalid input. Please enter valid integers and ensure total is not zero.");
            return;
        }

        // 🔴 BREAKPOINT #1: Set a breakpoint here before calculation
        // Incorrect calculation using int division:
        double percentageIncorrect = marks / total * 100; // This will cause integer division!

        // 🔴 BREAKPOINT #2: Set a breakpoint here after calculation
        Console.WriteLine($"Incorrect Percentage (due to integer division): {percentageIncorrect}%");

        // Fix: Use double casting to force floating-point division
        double percentageCorrect = (double)marks / total * 100;
        Console.WriteLine($"Correct Percentage: {percentageCorrect:0.00}%");
    }
}
