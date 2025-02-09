using System.Threading.Tasks.Dataflow;

class BreathingActivity:Activity{
    public BreathingActivity():base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."){}
    public void Run(){
        Console.Clear();
        DisplayStartingMessage();

        Console.Clear();

        Console.WriteLine("get ready...");
        ShowSpinner(8);
        DateTime endTime=DateTime.Now.AddSeconds(GetDuration());

        bool firstBreath=true;
        do{
            if (firstBreath){
                Console.Write("Breathe in...");
                ShowCountdown(2);
                Console.Write("Now Breathe Out...");
                ShowCountdown(3);
                firstBreath=false;
            }else{
                Console.Write("Breathe in...");
                ShowCountdown(4);
                Console.Write("Now Breathe Out...");
                ShowCountdown(6);
            }
            Console.WriteLine();
        }while((DateTime.Now<endtime));

        Console.WriteLine("Well Done!!");
        ShowSpinner(8);

        Console.Clear();
        DisplayEndingMessage();
    }
}