using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumber = new Random();
        int GuessNumber = randomNumber.Next(1,10);

        Console.WriteLine("What is the magic number?");
        Console.WriteLine("Name a number from 1 to 10?");
        
        int guess;
        do
        {
            Console.Write("Enter your guess: ");
            string Nguess = Console.ReadLine();
            guess = int.Parse(Nguess);

            if (guess < GuessNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > GuessNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != GuessNumber);

    }
}