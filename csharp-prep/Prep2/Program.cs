using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradeNumber = int.Parse(grade);
        string letter ="";
        if (gradeNumber >= 90)
        {
            letter = "A";
        }
        else if (gradeNumber >= 80)
        {
            letter = "B";
        }
        else if (gradeNumber >= 70)
        {
            letter = "C";
        }
        else if (gradeNumber >= 60)
        {
            letter = "D";
        }
        else if (gradeNumber < 60)
        {
            letter = "F";
        }
        else
        {
            System.Console.WriteLine("That number is not accepted");
        }
        System.Console.WriteLine($"Your grade is a(n) {letter}");
        if (gradeNumber >= 70)
        {
            System.Console.WriteLine("Congratulations on passing the class");
        }
        else if (gradeNumber < 70)
        {
            System.Console.WriteLine("Better luck next time");
        }
    }
}