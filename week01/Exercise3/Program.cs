using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        // Console.Write("What is the magic number? ");
        // string magic = Console.ReadLine();
        // int magicNum = int.Parse(magic);
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 101);
        int guessNum = 0;
        do
            {
            
                Console.Write("What is your guess? ");
                string guess = Console.ReadLine();
                guessNum = int.Parse(guess);
                if (guessNum < magicNum)
                {
                Console.WriteLine("Higher");
                }
                else if(guessNum > magicNum)
                {
                Console.WriteLine("Lower");
                }
                else
                {
                     Console.WriteLine("You won");
                }
            } while (magicNum != guessNum);
    }
}