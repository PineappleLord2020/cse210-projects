using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int random = randomGenerator.Next(1, 11);
        int guess;
        do{
            System.Console.WriteLine("Guess a Number");
            guess = int.Parse(Console.ReadLine());
        
            if (guess > random) {
                System.Console.WriteLine("Your number is too high. Guess lower");
            }

            else if (guess < random) {
                System.Console.WriteLine("Your number is too low. Guess higher");
            }

            else {
                System.Console.WriteLine("Correct");
            }
        } while (guess != random);
    }
}