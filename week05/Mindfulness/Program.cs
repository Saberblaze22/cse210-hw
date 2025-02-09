using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity=new BreathingActivity();
        ReflectionActivity reflectionActivity=new ReflectionActivity();
        ListingActivity listingActivity=new ListingActivity();
        int choice=0;
        while (choice !=4){
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start Breathing Activity");
            Console.WriteLine(" 2. Start Reflection Activity");
            Console.WriteLine(" 3. Start Listing Activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a Choice From The Menu: ");
            choice=int.Parse(Console.ReadLine());
            Console.Clear();
            if (choice==1){
                breathingActivity.Run();
            }else if (choice==2){
                reflectionActivity.Run();
            }else if (choice==3){
                listingActivity.run();
            }
            Thread.Sleep(2000);
        }
}