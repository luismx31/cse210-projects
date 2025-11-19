using System;

public class PrompGenerator
{
    public string _promp;

    // make a list of promps
    public List<string> _promps = new List<string>()
    {
        "What is something you learned today?",
        "What made you happy today?",
        "What are you thinking about right now?",
        "What is something you could change from today?",
        "What was the best part of my day?"

    }
    ;

    public void Display()
    {
        Console.WriteLine(_promps);

    }
      Random random = new Random();
    public void GetRandomPrompt()
    {
       

        // random.Next(maxValue) returns a non-negative random integer less than maxValue.
        int randomIndex = random.Next(_promps.Count);

        string randomPromp = _promps[randomIndex];

        Console.WriteLine($"{randomPromp}");


    }
    

    
    


    
}