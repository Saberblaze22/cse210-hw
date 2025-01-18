using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal=new Journal();
        string input ="1";
        while (input!="0"){
            Console.WriteLine("press 1 to create new entry");
            Console.WriteLine("press 2 to display all entries");
            Console.WriteLine("press 3 to save journal");
            Console.WriteLine("press 4 to load journal");
            Console.WriteLine("press 0 to exit journal");
            input=Console.ReadLine();
            if (input=="1"){
                journal.AddEntry();
            } else if (input=="2"){
                journal.DisplayAll();
            } else if (input=="3"){
                journal.SaveToFile();
            } else if (input=="4"){
                journal.LoadFromFile();
            } else if (input!="0"){
                Console.WriteLine("invalid input ");
            }
            }
            sConsole.WriteLine("closing journal");
        }

    }
}