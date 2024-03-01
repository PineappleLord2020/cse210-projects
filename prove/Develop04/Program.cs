using System;
using System.ComponentModel.Design;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Run();
    }

    static public void Run () {
        bool keepGoing = true;
        while (keepGoing){
            Console.Clear();
            
            var selection = ShowMenu();

            if (selection == 1) {
                Breathing breathing = new Breathing();
                string begin = breathing.BeginningInfo();
                string end = breathing.EndingInfo();
                System.Console.WriteLine(begin);
                int pauseTime;
                int activityTime;
                System.Console.WriteLine("When would you like to start your activity?");
                var pause = Console.ReadLine();
                pauseTime = int.Parse(pause);
                System.Console.WriteLine("How long would you like to do the activity for?");
                var time = Console.ReadLine();
                activityTime = int.Parse(time);
                Activity.Timer(activityTime, pauseTime);
                System.Console.WriteLine($"Breath in... ");
                Activity.Timer(activityTime, pauseTime);
                System.Console.WriteLine("Breath out...");
                System.Console.WriteLine(end);

                
            }
            else if (selection == 2) {
                Reflection reflection = new Reflection();
                string begin = reflection.BeginningInfo();
                string end = reflection.EndingInfo();
                System.Console.WriteLine(begin);
                int pauseTime;
                int activityTime;
                System.Console.WriteLine("When would you like to start your activity?");
                var pause = Console.ReadLine();
                pauseTime = int.Parse(pause);
                System.Console.WriteLine("How long would you like to do the activity for?");
                var time = Console.ReadLine();
                activityTime = int.Parse(time);
                Reflection.GetPrompt();
                Activity.Timer(activityTime, pauseTime);
                Reflection.FollowUpPrompt();
                Activity.Timer(activityTime, pauseTime);
                System.Console.WriteLine(end);
            }
            else if (selection == 3) {
                var available;
                string notes;
                Listening listening = new Listening();
                string begin = listening.BeginningInfo();
                System.Console.WriteLine(begin);
                int pauseTime;
                int activityTime;
                System.Console.WriteLine("When would you like to start your activity?");
                var pause = Console.ReadLine();
                pauseTime = int.Parse(pause);
                System.Console.WriteLine("How long would you like to do the activity for?");
                var time = Console.ReadLine();
                activityTime = int.Parse(time);
                List<string> thoughts = new List<string>();
                Listening.GetPrompt();
                available = Activity.Timer(activityTime, pauseTime);
                while(available = true){
                    notes = Console.ReadLine();
                    thoughts.Add(notes);
                }

            }
            else if (selection == 4) {
                keepGoing = false;
            }
        }
    }
    static int ShowMenu() {
            int numberSelection;
            System.Console.WriteLine("Select Option: \n 1. Breathing Activity \n 2. Reflection \n 3. Listening \n 4. Quit");
        
            System.Console.WriteLine("\n Enter your choice: ");
            string userInput = Console.ReadLine();
            numberSelection = int.Parse(userInput);
            return numberSelection;
        }
}