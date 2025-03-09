using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("What is your current grade percentage? ");
        string userGrade = Console.ReadLine();
        int numGrade = int.Parse(userGrade);
        string valueG = "";
        if (numGrade < 60)
        {
            valueG = "F";
        }
        else if (numGrade > 59 && numGrade < 70 )
        {
            valueG = "D";
        }
        else if (numGrade > 69 && numGrade < 80 )
        {
            valueG = "C";
        }
        else if (numGrade > 79 && numGrade < 90)
        {
            valueG = "B";
        }
        else{
            valueG = "A";
        }
            Console.WriteLine($" Your grade is {valueG}");

        if (numGrade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}