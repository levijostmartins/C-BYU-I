using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        Start();
        int elapsedTime = 0;

        while (elapsedTime < _duration)
        {
            if (elapsedTime < _duration)
            {
                ShowCountDown("Breathing in", 3);
                elapsedTime += 3;
            }

            if (elapsedTime < _duration)
            {
                ShowCountDown("Breathing out", 3);
                elapsedTime += 3;
                Console.WriteLine();
            }
        }

        End();
    }

    protected void ShowCountDown(string message, int seconds)
    {
        Console.Write(message);
        for (int i = seconds; i >= 0; i--)
        {
            Console.Write($"\r{message}... {i} ");
            System.Threading.Thread.Sleep(1000);
        }
        Console.Write($"\r{message}...    ");
        Console.WriteLine();
    }
}
