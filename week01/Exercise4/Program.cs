using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List <int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int num = 0;
        int sum = 0;
        do
        {
        Console.Write("Enter number: ");
        string numProvided = Console.ReadLine();
        num = int.Parse(numProvided);
        if (num != 0)
        {
        numbers.Add(num);
        }
        } while (num != 0);
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine("");
        Console.WriteLine($"The total is {sum}");
        float average = ((float)sum)/ numbers.Count;
        Console.WriteLine($"The aerage is {average} ");
        int maxNum = numbers[0];
        foreach ( int number in numbers)
        {
            if (number > maxNum){
                maxNum = number;
            }
        }
        Console.WriteLine($"The max is: {maxNum}");
        int minNum = numbers[0];
        foreach ( int number in numbers)
        {
            if (number < minNum){
                minNum = number;
            }
        }
        Console.WriteLine($"The min is: {minNum}");
        foreach (int number in numbers)
        {
            Console.WriteLine("The list is below: ");
            Console.WriteLine(number);
        }
        
    }
}