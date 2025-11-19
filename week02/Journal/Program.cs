using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;


class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello World! This is the Journal Project.");

        Console.WriteLine("Please select one of the following choices:");


        int Quit = 5;
        int choice = 0;

        while (choice != Quit)
        {  Console.WriteLine("1.Write");
           Console.WriteLine("2.Display");
           Console.WriteLine("3.Load");
           Console.WriteLine("4.Save");
           Console.WriteLine("5.Quit");         
           Console.WriteLine("What would you like to do?");

            choice = int.Parse(Console.ReadLine());

            Journal journal = new Journal();
            PrompGenerator prompG = new PrompGenerator();
            
            //Display new promp
            if (choice == 1)
            {
                prompG.GetRandomPrompt();
                string prompt = Console.ReadLine();

                string text = Console.ReadLine();
                journal.AddEntry(new Entry(prompt, text));

                break;

            }
            //Display Journal
            if (choice == 2)
            {
                journal.Displayall();
                break;
              
            }
            //Load Journal
            if (choice == 3)
            {
                Console.Write("Enter filename:");
                journal.LoadFromFile(Console.ReadLine());

            
            }
            //Save
            if (choice == 4)
            {
                Console.Write("Enter filename to save.");
                journal.SaveToFile(Console.ReadLine());

            }

            if (choice == 5)
                Console.Write("Goodbye!");

            break;
                
              
        }
        
        
        PrompGenerator promp1 = new PrompGenerator();
        
        promp1._promp = "if I had one thing I could do over today, what would it be?";
        //public string _date;
        //public string _prompText;
        //public string _entryText;

        


    
    }

       

        


}

