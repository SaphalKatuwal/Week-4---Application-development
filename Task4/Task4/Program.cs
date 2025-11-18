using System;

// Define the Player class
class Player
{
    // Instance fields
    public string playerName;
    public int level;
    public int health;

    // Default constructor
    public Player()
    {
        Console.WriteLine("Default constructor has been called");

        // Initialize fields to avoid null warnings
        playerName = "No Name";
        level = 1;
        health = 100;
    }

    // Parameterized constructor - sets values for all fields
    public Player(string name, int level, int health)
    {
        this.playerName = name;
        this.level = level;
        this.health = health;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating object using the default constructor
        Player player1 = new Player();

        Console.WriteLine("\nPlayer 1 Details (Default Constructor):");
        Console.WriteLine($"Name: {player1.playerName}");
        Console.WriteLine($"Level: {player1.level}");
        Console.WriteLine($"Health: {player1.health}");

        // Creating object using the parameterized constructor
        Player player2 = new Player("Saphal", 5, 80);

        Console.WriteLine("\nPlayer 2 Details (Parameterized Constructor):");
        Console.WriteLine($"Name: {player2.playerName}");
        Console.WriteLine($"Level: {player2.level}");
        Console.WriteLine($"Health: {player2.health}");
    }
}
