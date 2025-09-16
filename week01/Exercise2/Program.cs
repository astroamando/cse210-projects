using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?. ");

        string userinput = Console.ReadLine();

        int grade = int.Parse(userinput);

        if (grade >= 90)
        {
            Console.WriteLine("You got an A.");
        }
        else if (grade >= 80 & grade < 90)
        {
            Console.WriteLine("You got a B.");
        }
        else if (grade >= 70 & grade < 80)
        {
            Console.WriteLine("You got a C.");
        }
        else if (grade >= 60 & grade < 70)
        {
            Console.WriteLine("You got a D.");
        }
        else if (grade < 60)
        {
            Console.WriteLine("You got an F");
        }

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed.");
        }
    }
}