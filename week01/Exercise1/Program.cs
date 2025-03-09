using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.WriteLine("What is your last name? ");
        string LastName = Console.ReadLine();
        Console.WriteLine("What is your first name? ");
        string FirstName = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine($"Your name is {LastName}, {FirstName} {LastName}.");
    }
}