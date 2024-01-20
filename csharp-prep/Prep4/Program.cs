using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List <int> numbers = new List<int>();

        System.Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int userNumber = -1;
        do{
            System.Console.WriteLine("Enter number: ");
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);

            if (userNumber != 0){
                numbers.Add(userNumber);
            }
        }while (userNumber != 0);

        int sum = 0;
        foreach (int number in numbers){
            sum += number;
        }

        System.Console.WriteLine($"The sum is {sum}");
        
        float average = ((float)sum) / numbers.Count;
        System.Console.WriteLine($"The average is {average}");

        int max = numbers[0];
        foreach (int number in numbers){
            if (number > max){
                max = number;
            }
        }

        System.Console.WriteLine($"The max number is {max}");
    }
}