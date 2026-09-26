using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Introduction to C#", "John Smith", 600);
        Comment comment1 = new Comment("Mary", "This was a helpful introduction.");
        video1.AddComment(comment1);
        Comment comment2 = new Comment("David", "I learned something new from this.");
        video1.AddComment(comment2);
        Comment comment3 = new Comment("John", "This video is helpful and supportive");
        video1.AddComment(comment3);
 
        Video video2 = new Video("Learning Python", "Sarah Williams", 480);
        Comment comment4 = new Comment("Ken", "This is a well explain tutorial");
        video2.AddComment(comment4);
        Comment comment5 = new Comment("Dave", "Brilliant breakdown! The code examples were crisp and super easy to follow");
        video2.AddComment(comment5);
        Comment comment6 = new Comment("Tony", "You have a real gift for teaching. Everything just clicked for me.");
        video2.AddComment(comment6);

        Video video3 = new Video("Understanding Data Analysis", "Michael Brown", 720);
        Comment comment7 = new Comment("Palmer", "This is a beautifully explained tutorial! You made a complex topic feel so simple.");
        video3.AddComment(comment7);
        Comment comment8 = new Comment("Jay", "Good one Michael i really enjoy the tutorial");
        video3.AddComment(comment8);
        Comment comment9 = new Comment("Scot", "Best Data Analysis explanation I’ve seen so far. Straight to the point with zero fluff!");
        video3.AddComment(comment9);
 
        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
           Console.WriteLine($"Title: {video.GetTitle()}"); 
           Console.WriteLine($"Author: {video.GetAuthor()}");
           Console.WriteLine($"Length: {video.GetLength()} seconds");
           Console.WriteLine($"Comments: {video.GetCommentCount()}");
           foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(comment.GetDisplayText());
            }
            Console.WriteLine();
        }
    }
}