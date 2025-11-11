using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int SquaredNumber = SquareNumber(number);
        DisplayResult(name,SquaredNumber);

    }

       

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");

        }
        
        static string PromptUserName()
        {
            Console.Write("Please enter your name:");            
            string name = Console.ReadLine();
            return name;

        }

        static int SquareNumber(int number)
        {
        int square = number * number;
        return square;
        }
        
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number:");
            int number =  int.Parse(Console.ReadLine());
            return number;
        }
       

         static void DisplayResult(string name, int square)
         {
            Console.WriteLine($"Brother {name}, the square of your number is {square}");

         }
  
}