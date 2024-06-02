using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>
        {
            new Video("Photoshop Masterclass", "Claudia Qing", 600),
            new Video("Machine Learning 101", "Albert John", 900),
            new Video("Gok Chinese Cuiseine", "Gok Wan", 720)
        };

 foreach (Video video in videos)
        {
            HashSet<string> usedComments = new HashSet<string>();
            for (int i = 0; i < 3; i++)
            {
                string commenterName = "Anonymous" + new Random().Next(1, 100);
                string text = GenerateUniqueRandomComment(usedComments);
                video.AddComment(commenterName, text);
            }
        }

        VideoMenu videoMenu = new VideoMenu(videos);
        videoMenu.Run();
    }

    static string GenerateUniqueRandomComment(HashSet<string> usedComments)
    {
        string[] possibleComments = {
            "This is a great video!",
            "I learned a lot from this video.",
            "The explanation was clear and concise.",
            "I wish there were more examples.",
            "Thank you for sharing this knowledge!"
        };

        Random random = new Random();
        string comment;
        do
        {
            comment = possibleComments[random.Next(possibleComments.Length)];
        } while (!usedComments.Add(comment));

        return comment;
    }
}
