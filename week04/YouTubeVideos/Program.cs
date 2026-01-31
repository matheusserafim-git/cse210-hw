using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        
        Video video = new Video("Learning c#", "jhon doses", 200);
        video.AddComment (new Comment("Alice", "Great video!"));
        video.AddComment (new Comment("Bob", "Very informative."));
        video.AddComment (new Comment("Charlie", "loved the examples!"));
        videos.Add(video);

        Video video2 = new Video("Advanced c#", "Jane ayre", 450);
        video2.AddComment (new Comment("Charlie", "loved the examples!"));
        video2.AddComment (new Comment("Diana", "well explained concepts."));
        video2.AddComment (new Comment("Bob", "looking forward to more videos."));
        videos.Add(video2);

        Video video3 = new Video("C# Design Patterns", "Mike ross", 300);
        video3.AddComment (new Comment("Eve", "design patterns are crucial!"));
        video3.AddComment (new Comment("Frank", "thanks for the insights."));
        video3.AddComment (new Comment("Alice", "very helpful content."));
        video3.AddComment (new Comment("George", "can you make a video on SOLID principles?"));
        videos.Add(video3);

        foreach (Video v in videos)
        {
            Console.WriteLine(v.GetTitle());
            Console.WriteLine($"Author: {v.GetAuthor()}");
            Console.WriteLine($"Duration: {v.GetTime()} seconds");
            Console.WriteLine($"Number of comments: {v.GetNumberOfComments()}");

            foreach (Comment c in v.GetComments())
        {
            Console.WriteLine($"{c.GetName()}: {c.GetText()}");
        }


            Console.WriteLine("//////////////////////////////////////////");
        }

 

    }
}