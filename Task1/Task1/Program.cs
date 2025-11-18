using System;

class Student
{
    // Instance fields - these store individual student details
    public string name;
    public int age;
    public string grade;

    // Static field - shared across all Student objects
    public static string schoolName = "Itahari Internaltional College";

    // Constructor - ensures that all non-nullable instance fields are initialized
    public Student(string name, int age, string grade)
    {
        this.name = name;  // 'this' refers to the current object
        this.age = age;
        this.grade = grade;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating first Student object using the constructor
        Student student1 = new Student("Abik", 22, "2nd year");

        // Creating second Student object with different values
        Student student2 = new Student("Saphal", 20, "3rd year");

        // Displaying values of student1
        Console.WriteLine("Details of Student 1:");
        Console.WriteLine("Name: " + student1.name);
        Console.WriteLine("Age: " + student1.age);
        Console.WriteLine("Grade: " + student1.grade);

        // Displaying values of student2
        Console.WriteLine("\nDetails of Student 2:");
        Console.WriteLine("Name: " + student2.name);
        Console.WriteLine("Age: " + student2.age);
        Console.WriteLine("Grade: " + student2.grade);

        // Displaying static field value
        Console.WriteLine("\nSchool Name (Static Field): " + Student.schoolName);
    }
}
