using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Basics", "John Doe", 10);
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "Clear and concise."));

        Video video2 = new Video("Understanding LINQ", "Jane Smith", 15);
        video2.AddComment(new Comment("Dave", "Amazing explanation!"));
        video2.AddComment(new Comment("Eve", "I finally understood LINQ."));
        video2.AddComment(new Comment("Frank", "This was so useful!"));

        Video video3 = new Video("ASP.NET Core Tutorial", "Michael Johnson", 20);
        video3.AddComment(new Comment("Grace", "This was exactly what I needed."));
        video3.AddComment(new Comment("Hannah", "Perfect for beginners."));
        video3.AddComment(new Comment("Ian", "Loved the examples!"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} minutes");
            Console.WriteLine($"Comments ({video.GetCommentCount()}):");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}
