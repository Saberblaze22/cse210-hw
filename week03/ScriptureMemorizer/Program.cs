using System;

public class Program
{
    static void Main(string[] args)
    {
        Scripture scripture=new Scripture();
        Console.Write("choose 1 verse or 2. ");
        int choice=int.Parse(Console.ReadLine());
        if (choice==1){
            Reference reference1=new Reference("1 nephi", 2, 1);
            Scripture scripture1=new Scripture("For behold, it came to pass that the Lord spake unto my father, yea, even in a dream, and said unto him: Blessed art thou Lehi, because of the things which thou hast done; and because thou hast been faithful and declared unto this people the things which I commanded thee, behold, they seek to take away thy life.", reference1);
            scripture=scripture1;
        } else if (choice==2){
            Reference reference2=new Reference("1 nephi", 2, 2);
            Scripture scripture2=new Scripture("And it came to pass that the Lord commanded my father, even in a dream, that he should take his family and depart into the wilderness.", reference2);
            scripture=scripture2;
        }
        string input="";
        while (input !="quit"){
            Console.Clear();
            Console.WriteLine(scripture.GetPublicDisplay());
            Console.Write("enter quit to escape. ");
            input=Console.ReadLine();
            if (scripture.IsAllHidden()){
                input="quit";
            }
            scripture.HideRandom(3);

        }
    }
}