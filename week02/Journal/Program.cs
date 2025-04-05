using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        PromptGenerator promptGenerator = new PromptGenerator();
        string randomPrompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine(randomPrompt);
    }
}