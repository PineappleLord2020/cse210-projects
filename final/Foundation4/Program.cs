using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Running running1 = new Running(3.00, 30.00, "01 April 2024");
        Console.WriteLine(running1.Summary());
        System.Console.WriteLine("");
        Swimming swimming1 = new Swimming(4.00, "02 April 2024", 30.00);
        System.Console.WriteLine(swimming1.Summary());
        System.Console.WriteLine("");
        Cycling cycling1 = new Cycling("03 April 2024", 20.00, 30.00);
        System.Console.WriteLine(cycling1.Summary());
        System.Console.WriteLine("");
    }
}