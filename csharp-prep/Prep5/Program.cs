using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        int Add2(int number, string name) {
            return number + 2;
        }

        void PrintNmae(string name) {
            System.Console.WriteLine(name);
        }

        int answer = Add2(10, "bob");
        PrintNmae($"Bob is {answer}");

        var i = 12;
        {
            var y = 10;
            y = i + 3;
            i = y + 4;
        }
        y = 3;
    }
}