using System;
using System.Collections.Generic;

class VideoMenu
{
    private List<Video> videos;

    public VideoMenu(List<Video> videos)
    {
        this.videos = videos;
    }

    public void Run()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Select a video to see details (1-" + videos.Count + "), or enter 'q' to quit:");
            for (int i = 0; i < videos.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + videos[i].Title);
            }

            string input = Console.ReadLine();

            if (input.ToLower() == "q")
            {
                break;
            }

            int index;
            if (int.TryParse(input, out index) && index >= 1 && index <= videos.Count)
            {
                Video selectedVideo = videos[index - 1];
                Console.Clear();
                Console.WriteLine();
                selectedVideo.DisplayInfo();
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and " + videos.Count + " or 'q' to quit.");
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}
