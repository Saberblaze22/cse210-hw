using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Video>videos=new List<Video>();
        Video video = new Video("anime starter", "saber", 45);
        Video video1=new Video("sword introduction", "void", 859);
        Video video2=new Video("manga recommendations", "crimson beast", 523);
        video.AddComment("saber", "i oved the video");
        video.AddComment("saber", "make more videos please");
        video.AddComment("saber", "where can i find this stuff");
        video1.AddComment("void", "what types are there");
        video1.AddComment("void", "how much does it cost");
        video1.AddComment("void", "where did they originate");
        video2.AddComment("crimson beast", "what genre does it come from");
        video2.AddComment("crimson beast", "how many books for it");
        video2.AddComment("crimson beast", "when do they release the next chapter on");
        videos.Add(video);
        videos.Add(video1);
        videos.Add(video2);
        foreach (Video v in videos){
            Console.WriteLine(v.GetVideoInfo());
            v.DisplayAllComments();
        }
    }

}