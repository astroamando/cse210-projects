using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?. ");

        string userinput = Console.ReadLine();

        int grade = int.Parse(userinput);

        string letter = "";

        if (grade >= 90)
        {
            letter = "n A";
        }
        else if (grade >= 80 & grade < 90)
        {
            letter = " B";
        }
        else if (grade >= 70 & grade < 80)
        {
            letter = " C";
        }
        else if (grade >= 60 & grade < 70)
        {
            letter = " D";
        }
        else if (grade < 60)
        {
            letter = "n F";
        }

        Console.WriteLine($"You got a{letter}.");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else if (grade < 70)
        {
            Console.WriteLine("You need to try harder.");
        }
    }
}