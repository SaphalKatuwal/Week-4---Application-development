using System;

// Declare the enum
enum DayType
{
    Weekday,
    Weekend
}

// Declare the record with three fields
record Book(string title, string author, double price);

class Program
{
    static void Main(string[] args)
    {
        // ----- Task 1: Enum and Day Check -----

        // Asking the user to input the day
        Console.Write("Enter a day (e.g., Sunday): ");
        string dayInput = Console.ReadLine() ?? string.Empty;

        // Check if the day is Friday or Saturday (Weekend)
        DayType dayType = dayInput.Equals("Friday", StringComparison.OrdinalIgnoreCase) ||
                          dayInput.Equals("Saturday", StringComparison.OrdinalIgnoreCase)
                          ? DayType.Weekend
                          : DayType.Weekday;

        // Print the result
        Console.WriteLine($"It is: {dayType}");

        // ----- Task 2: Book Record -----

        // Creating an object of the Book record
        Book book1 = new Book("The Alchemist", "Paulo Coelho", 499.99);

        // Creating another object using 'with' expression, changing title and price
        Book book2 = book1 with { title = "Veronika Decides to Die", price = 599.99 };

        // Printing values of book1
        Console.WriteLine("\nBook 1 Details:");
        Console.WriteLine(book1);

        // Deconstructing book2 into individual variables
        var (newTitle, newAuthor, newPrice) = book2;

        Console.WriteLine("\nBook 2 Deconstructed Details:");
        Console.WriteLine($"Title: {newTitle}");
        Console.WriteLine($"Author: {newAuthor}");
        Console.WriteLine($"Price: {newPrice}");
    }
}
