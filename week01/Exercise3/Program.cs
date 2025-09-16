using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Guess My Number\n");

        Random randomnum = new Random();
        int number = randomnum.Next(1, 100);

        bool game = false;
        int count = 0;
        while (game == false)
        {
            Console.WriteLine("What is your guess? ");
            string userinput = Console.ReadLine();
            int guess = int.Parse(userinput);
            count+=1;
            if (guess > number)
            {
                Console.WriteLine("\nLower\n");
            }
            else if (guess < number)
            {
                Console.WriteLine("\nHigher\n");
            }
            else
            {
                Console.WriteLine($"You guessed the number in {count} guesses!");
                game = true;
            }
        }
    }
}