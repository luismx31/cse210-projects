using System;

Console.WriteLine("Hello World! This is the Exercise3 Project.");
Random randomGenerator = new Random();
int magicNumber = randomGenerator.Next(1, 101);

int count = 0;
int guess = 0;

while (guess != magicNumber)
{
    Console.Write("What is your guess? ");
    guess = int.Parse(Console.ReadLine());



    if (magicNumber > guess)
    {
        Console.WriteLine("Higher");
    }
    else if (magicNumber < guess)
    {
        Console.WriteLine("Lower");
    }
    else
    {
        Console.WriteLine("You guessed it!");
    }
     count = count + 1;

    Console.WriteLine($"you have try it {count} times.");

}




