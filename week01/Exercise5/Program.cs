using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
    }
     static void  DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
    static string PromptUserName(string name)
        {
            Console.Write("What is your name? ");
            name = Console.ReadLine();

            return name;

        }
        static int PromptUserNumbet(int number)
        {
            Console.Write("Please enter your favorite number: ");
            string num = Console.ReadLine();
            number = int.Parse(num);

            return number;
        }
    static int SquareNumber (int number)
        {
            int square = number * number;

            return square;
        }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}