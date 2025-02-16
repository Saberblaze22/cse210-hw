using System.Formats.Asn1;

public class CheckListGoal: Goal{
    internal int _amountCompleted;
    int _target;
    internal int _bonus;
    public CheckListGoal(string name, string description, int points, int target, int bonus):base(name,description,points){
        _target=target;
        _bonus=bonus;
        _amountCompleted=0;
    }
    public override void RecordEvent()
    {
        Console.WriteLine($"{GetDetailString()}");
        Console.Write("have you completed this task? (y or n) ");
        string answer=Console.ReadLine();
        while (answer.ToLower() !="n" & answer.ToLower() !="y"){
            Console.Write("invalid input");
            answer=Console.ReadLine();
        }
        if(answer=="y"){
            _amountCompleted+=1;
            if (_amountCompleted> _target){
                _amountCompleted=_target;
            }
        }
    }
    public override bool IsComplete()
    {
        if (_amountCompleted==_target){
            return true;
        }
        else{
            return false;
        }
    }
    public override string GetStringRepresentaion()
    {
        return $"name:{_shortName}, description:{_description}, points:{_points}, target:{_target}, amountCompleted:{_amountCompleted}, bonus:{_bonus}";
    }
}public override string GetDetailString(){
    return $"{_shortName}{_description} completed {_amountCompleted}/{_target} time";
}