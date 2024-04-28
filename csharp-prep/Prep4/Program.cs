using System;

class Program
{
    static void Main(string[] args)
    {
        {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when you want to finish it.");

        int input;
        do
        {
            Console.Write("Enter number: ");
            string number = Console.ReadLine();
            input = int.Parse(number);
            if (input != 0)
            {
                numbers.Add(input);
            }
        } while (input != 0);

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        double average = (double)sum / numbers.Count;

        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The average is: " + average);
        Console.WriteLine("The largest number is: " + max);
    }
    }
}