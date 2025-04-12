using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
                List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("How to Cook Pasta", "Chef Tony", 300);
        video1.AddComment(new Comment("Alice", "Great recipe!"));
        video1.AddComment(new Comment("Bob", "Tried it and loved it."));
        video1.AddComment(new Comment("Cathy", "Could you do one for lasagna?"));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Top 10 Travel Destinations", "GlobeTrotter", 600);
        video2.AddComment(new Comment("Dan", "I want to go to Japan now!"));
        video2.AddComment(new Comment("Eva", "Amazing shots."));
        video2.AddComment(new Comment("Frank", "You forgot New Zealand."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Beginner Guitar Lesson", "GuitarMaster", 420);
        video3.AddComment(new Comment("Grace", "Super helpful, thanks!"));
        video3.AddComment(new Comment("Henry", "Struggling with the chords."));
        video3.AddComment(new Comment("Ivy", "Can you do more beginner videos?"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($" - {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine();
        }
    
    }
}