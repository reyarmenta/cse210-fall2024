using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade_percentage = Console.ReadLine();
        int number = int.Parse(grade_percentage);

        string letter = "";

        if (number >= 90)
        {
            //Console.WriteLine("A");
            letter = "A";
        }
        else if (number >= 80)
        {
            //Console.WriteLine("B");
            letter = "B";
        }
        else if (number >= 70)
        {
            //Console.WriteLine("C");
            letter = "C";
        }
        else if (number >= 60)
        {
            //Console.WriteLine("D");
            letter = "D";
        }
        else if (number < 60)
        {
            //Console.WriteLine("F");
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        //Determine if student passed or not
        if (number >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("You can put in more effort and pass the class :) ");
        }
    }
}