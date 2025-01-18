using System.Security.Cryptography;

public class Entry{
    PromptGenerator _promptGenerator =new PromptGenerator();
    DateTime datetime=DateTime.Now;
    string _date;
    string _promptText;
    public string _entryText;
    public void FillEntry(){
        _date=datetime.ToShortDateString();
        _promptGenerator._prompts.Add("Who was the most interesting person I interacted with today?");
        _promptGenerator._prompts.Add("What was the best part of my day?");
        _promptGenerator._prompts.Add("How did I see the hand of the Lord in my life today?");
        _promptGenerator._prompts.Add("What was the strongest emotion I felt today?");
        _promptGenerator._prompts.Add("If I had one thing I could do over today, what would it be?");
        _promptText=_promptGenerator.GetRandomPrompt();
        Console.Write($"{_promptText} ");
        _entryText=$"{_date}: {_promptText} {Console.ReadLine}";

    }
    public void Display(){
        Console.WriteLine(_entryText);
    }
}