using System.Collections.Specialized;

public class GoalManager{
    List<Goal> _goals=new List<Goal>();
    int _score;
    public GoalManager(){
        _score=0;
    }
    public void Start(){
        int choice=0;
        while (choice !=6){
            Console.Clear();
            Console.WriteLine("menu options:");
            Console.WriteLine("1. create new goal");
            Console.WriteLine("2. list goals");
            Console.WriteLine("3. save goals");
            Console.WriteLine("4. load goals");
            Console.WriteLine("5. record goals");
            Console.WriteLine("6. quit");
            Console.Write("select a choice from the menu");
            choice=int.Parse(Console.ReadLine());
            if (choice==1){
                CreateGoals();
            }else if (choice==2){
                ListGoalDetails();
            }else if (choice==3){
                SaveGoals();
            }else if (choice==4){
                LoadGoals();
            }else if (choice==5){
                RecordEvent();
            }
            DisplayPlayerInfo();
            Console.ReadLine();
        }
    }
    public void DisplayPlayerInfo(){
        Console.WriteLine($"number of goals:{_goals.Count}");
        Console.WriteLine($"current Score: {_score}");
    }
    public void ListGoalname(){
        foreach (Goal g in _goals){
            Console.WriteLine(g._shortName);
        }
    }
    public void ListGoalDetails(){
        int count=1;
        foreach (Goal g in _goals){
            Console.WriteLine($"{count}. {g.GetDetailString()}");
        }
    }
    public void CreateGoals(){
        Console.Clear();
        Console.WriteLine("what kind of goal do you wish to make?");
        Console.WriteLine("1. simple");
        Console.WriteLine("2. eternal");
        Console.WriteLine("3. checklist");
        int choice=int.Parse(Console.ReadLine());
        while (choice != 1& choice!=2 & choice!=3){
            Console.Clear();
            Console.WriteLine("what kind of goal do you wish to make?");
            Console.WriteLine("1. simple");
            Console.WriteLine("2. eternal");
            Console.WriteLine("3. checklist");
            choice=int.Parse(Console.ReadLine());
        }
        if (choice==1){
            Console.Clear();
            Console.WriteLine("Creating simple task");
            Console.Write("what is your goals name: ");
            string name= Console.ReadLine();
            Console.Write("provide a description of the goal: ");
            string description=Console.ReadLine();
            Console.Write("how many points is the goal worth: ");
            int points=int.Parse(Console.ReadLine());
            SimpleGoal simple=new SimpleGoal(name, description, points);
            _goals.Add(simple);
        }
        else if (choice==2){
            Console.Clear();
            Console.WriteLine("creating eternal task");
            Console.Write("what is the goals name: ");
            string name= Console.ReadLine();
            Console.Write("provide a descriptionof the goal: ");
            string description=Console.ReadLine();
            Console.Write("how many points is the goal worth: ");
            int points=int.Parse(Console.ReadLine());
            EternalGoal eternal= new EternalGoal(name, description, points);
            _goals.Add(eternal);
        }
        else if(choice==3){
            Console.Clear();
            Console.WriteLine("creating eternal task");
            Console.Write("what is the goals name: ");
            string name= Console.ReadLine();
            Console.Write("provide a descriptionof the goal: ");
            string description=Console.ReadLine();
            Console.Write("how many points is the goal worth: ");
            int points=int.Parse(Console.ReadLine());
            Console.Write("how many times must the goal be completed: ");
            int target=int.Parse(Console.ReadLine());
            CheckListGoal checkList= new CheckListGoal(name, description, points, target, bonus);
            _goals.Add(checkList);
        }
    }
    public void RecordEvent(){
        Console.Clear();
        foreach (Goal g in _goals){
            if (!g.IsComplete()){
                g.RecordEvent();
                string[] vars=g.GetStringRepresentaion().Split(',');
                using(StreamWriter outputFile=new StreamWriter(filename))
                {
                    foreach (Goal g in _goals){
                        outputFile.WriteLine(g.GetStringRepresentaion());
                    }
                    outputFile.WriteLine($"score: {_score}");
                    Console.WriteLine("saving to file...");
                }
            }
        }
    }
    public void LoadGoals(){
        Console.Write("what is the file name? ");
        string filename=Console.ReadLine();
        string[]lines=File.ReadAllLines(filename);
        List<Goal> oldGoals = new List<Goal>();
        foreach (string line in lines){
            string[] vars=line.Split(',');
            if (vars.Length==4){
                string name= vars[0].Split(':')[1];
                string description=vars[1].Split(':')[1];
                int points=int.Parse(vars[2].Split(':')[1]);
                string complete=vars[3].Split(':')[1];
                SimpleGoal goal=new SimpleGoal(name, description, points);
                if (complete=="y"){
                    goal._isComplete=true;
                }else{
                    goal._isComplete=false;
                }
                oldGoals.Add(goal);
            }else if(vars.Length==3){
                string name= vars[0].Split(':')[1];
                string description=vars[1].Split(':')[1];
                int points=int.Parse(vars[2].Split(':')[1]);
                EternalGoal goal=new EternalGoal(name,description,points);
                oldGoals.Add(goal);
            }
            else if (vars.Length==6){
                string name= vars[0].Split(':')[1];
                string description=vars[1].Split(':')[1];
                int points=int.Parse(vars[2].Split(':')[1]);
                int target= int.Parse(vars[3].Split(':')[1]);
                int amountCompleted=int.Parse(vars[4].Split(':')[1]);
                int bonus=int.Parse(vars[5].Split(':')[1]);
                CheckListGoal goal=new CheckListGoal(name,description,points,target,bonus);
                goal._amountCompleted=amountCompleted;
            }else if(vars.Length==1){
                _score=int.Parse(vars[0].Split(':')[1]);
            }

        _goals=oldGoals        }
    }

}