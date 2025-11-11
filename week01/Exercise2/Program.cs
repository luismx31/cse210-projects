using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("What is your score?");
string userResponse = Console.ReadLine();

Console.WriteLine(userResponse);

int x = int.Parse(userResponse);

string letter = ""; 
         


        if (x >= 90)
        {
            letter = "A";
        }
        else if (x >= 80)
        {
            letter = "B";
        }
        else if (x>= 70)
        {
            letter = "C";
        }
        else if (x >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

            Console.WriteLine($"Your grade is: {letter}");
        
        if (x >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }

    }
}