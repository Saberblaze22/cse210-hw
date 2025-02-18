using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities=new List<Activity>();
        activities.Add(new Running(30, .62f));
        activities.Add(new Cycling(30, 6.0f));
        activities.Add(new Swimming(30, 10));
        foreach (Activity activity in activities){
            Console.WriteLine(activity.GetSummary());
        }
    }
}