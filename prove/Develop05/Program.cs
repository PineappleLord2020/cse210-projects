using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        bool run = true;

        List<string> goals = new List<string>();
        while (run){
            var selection = Menu();
            if (selection == 1){
                int tracker = 1;
                System.Console.WriteLine("What is the name of your eternal goal?");
                string title = Console.ReadLine();
                System.Console.WriteLine("What is the description of your goal?");
                string description = Console.ReadLine();
                System.Console.WriteLine("How many points is this goal worth?");
                string pointWords = Console.ReadLine();
                int pointValue = int.Parse(pointWords);
                int completionAmount = 0;
                string name = $"Goal {tracker}";
                Eternal name = new Eternal(title, description, pointValue, completionAmount);
                if (run){
                   tracker = tracker + 1;
                }
            }
            else if (selection == 2){
                int tracker = 1;
                System.Console.WriteLine("What is the name of your eternal goal?");
                string title = Console.ReadLine();
                System.Console.WriteLine("What is the description of your goal?");
                string description = Console.ReadLine();
                System.Console.WriteLine("How many points is this goal worth?");
                string pointWords = Console.ReadLine();
                int pointValue = int.Parse(pointWords);
                int completionAmount = 0;
                string name = $"Goal {tracker}";
                Temporary name = new Temporary(title, description, pointValue, completionAmount);
                if (run){
                   tracker = tracker + 1;
                }
            }
            else if (selection == 3){
                 int tracker = 1;
                System.Console.WriteLine("What is the name of your eternal goal?");
                string title = Console.ReadLine();
                System.Console.WriteLine("What is the description of your goal?");
                string description = Console.ReadLine();
                System.Console.WriteLine("How many points is this goal worth?");
                string pointWords = Console.ReadLine();
                int pointValue = int.Parse(pointWords);
                int completionAmount = 0;
                string name = $"Goal {tracker}";
                Checklist name = new Checklist(title, description, pointValue, completionAmount);
                if (run){
                   tracker = tracker + 1;
                }
            }
            else if (selection == 4){
                GetPointValue();
            }
            else if (selection == 5){
                foreach(Goal in goals){
                    Display();
                }
            }
            else if (selection == 6){
                int totalPoints = 0;
                int _pointValue = GetPointValue();
                totalPoints = totalPoints + _pointValue;  
            }
            else if (selection == 7){
                run = false;
            }
        }
    }

    static int Menu(){
        int numberSelection;
        System.Console.WriteLine("Please select what action you would like to do");
        System.Console.WriteLine("1. Create Eternal Goal \n 2. Create Temporary Goal \n 3. Create Checklist Goal \n 4. Display Score \n 5. Display Goals \n 6. Record Goal Completion \n 7. Quit");
        string userInput = Console.ReadLine();
        numberSelection = int.Parse(userInput);
        return numberSelection;
    }
}