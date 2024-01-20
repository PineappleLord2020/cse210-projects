using System;
using System.Text;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();

        string username = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(username, squaredNumber);

        static void DisplayWelcome(){
            System.Console.WriteLine("Welcome to the Program");
        }

        static string PromptUserName(){
            System.Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber(){
            int number = 0;
            System.Console.WriteLine("What is your favorite number?");
            string numberRead = Console.ReadLine();
            number = int.Parse(numberRead);
            return number;
        }

        static int SquareNumber (int number){
            int squared = number * number;
            return squared;
        }

        static void DisplayResult (string username, int squaredNumber){
            System.Console.WriteLine($"{username}, the square of your number is {squaredNumber}");
        }
    }
}