using System;

// Define the ParameterDemo class
class ParameterDemo
{
    // Method that increases the number by 10 using the 'ref' keyword
    public void Increase(ref int number)
    {
        number += 10; // Increment by 10
    }

    // Method that assigns a full name using the 'out' keyword
    public void GetFullName(out string fullname)
    {
        fullname = "Saphal Katuwal"; // Assigning value to the out parameter
    }

    // Method that takes variable number of int arguments using 'params'
    // and returns the sum of all numbers
    public int SumAll(params int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an object of ParameterDemo
        ParameterDemo demo = new ParameterDemo();

        // 1. Demonstrate 'ref' keyword
        int value = 5; // Initial value
        Console.WriteLine("Original value: " + value);
        demo.Increase(ref value); // Passing by reference
        Console.WriteLine("Value after Increase(ref): " + value);

        // 2. Demonstrate 'out' keyword
        string fullName;
        demo.GetFullName(out fullName); // Using out parameter to receive value
        Console.WriteLine("Full Name from GetFullName(out): " + fullName);

        // 3. Demonstrate 'params' keyword
        int sum = demo.SumAll(1, 2, 3, 4, 5);
        Console.WriteLine("Sum of numbers (1,2,3,4,5): " + sum);

        // You can also pass an array to 'params'
        int[] numberArray = { 10, 20, 30 };
        int sum2 = demo.SumAll(numberArray);
        Console.WriteLine("Sum of numbers in array (10,20,30): " + sum2);
    }
}
