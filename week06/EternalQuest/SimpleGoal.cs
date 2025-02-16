using System.Drawing;

public class SimpleGoal: Goal{
    internal bool _isComplete;
    public SimpleGoal(string name, string description, int points): base(name, description,points){
        _isComplete=false;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"{GetDetailString()}");
        Console.Write("have you completed this task? (y or n) ");
        string answer=Console.ReadLine();
        while (answer !="n" & answer !="y"){
            Console.Write("invalid input");
            answer=Console.ReadLine();
        }
        if (answer=="y"){
            _isComplete=true;
        }
    }
    public override bool IsComplete()
    {
        return _isComplete=true;
    }
    public override string GetStringRepresentaion()
    {
        string complete;
        if (_isComplete){
            complete="y";
        }
        else {
            complete="n";
        }
        return $"name:{_shortName}, description:{_description}, points:{_points}, complete:{complete}";
    }
}