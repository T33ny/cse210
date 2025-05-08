using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int num = randomGenerator.Next(1, 101);
        Console.Write("Choose a number between 1-100: ");
        string number_String = Console.ReadLine();
        int guess = int.Parse(number_String);

        while (guess != num)
        {
            if (guess > num)
            {
                Console.WriteLine("Lower");
                Console.Write("Guess again: ");
                number_String = Console.ReadLine();
                guess = int.Parse(number_String);
            }
            else if (guess < num)
            {
                Console.WriteLine("Higher");
                Console.Write("Guess again: ");
                number_String = Console.ReadLine();
                guess = int.Parse(number_String);
            }
        }  
        Console.WriteLine("You guessed it!");
    }
}