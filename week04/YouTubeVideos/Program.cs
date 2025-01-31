using System;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Basics", "John Doe", 600);
        video1.AddComment("Alice", "Great explanation!");
        video1.AddComment("Bob", "Very helpful, thanks!");
        video1.AddComment("Charlie", "Can you do a part two?");

        Video video2 = new Video("Advanced C#", "Jane Smith", 1200);
        video2.AddComment("David", "This was quite informative.");
        video2.AddComment("Eve", "I learned a lot, thanks!");
        video2.AddComment("Frank", "Loved the examples.");

        Video video3 = new Video("Design Patterns in C#", "Emily Brown", 900);
        video3.AddComment("Grace", "This was well-structured!");
        video3.AddComment("Hank", "More content like this, please!");
        video3.AddComment("Ivy", "Amazing explanation of patterns.");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}