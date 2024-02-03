//Code by Andrew Mulert with help from Michael Zaugg. So if any of this code looks too similar, dock me the points, not him.
namespace Journal;

using System;
using System.Globalization;
//The main program where everything is run from
class Program
{
    //I have no clue what this does. It confuses me
    static public Journal journal;
    //This grabs the current date and time
    static DateTime theCurrentTime = DateTime.Now;
    //This puts that information into a string that can be used.
    static string dateText = theCurrentTime.ToShortDateString();
    //This is the main function within the class that runs everything
    static void Main(string[] args)
    {
        //This makes sure all the new information we are running is stored in a seperate place so it doesn't rightover any information of importance
        journal = new Journal();
        //Console.WriteLine("Hello Develop02 World!");
        //This runs the run function
        Run();
    }
//This section basically tells the computer what to run.
    static public void Run() {
            bool keepGoing = true;
         //While the previous statement remains true, the whole while statement should loop.
            while(keepGoing) {
                Console.Clear();
                //This brings up the menu from a different section of the code.
                var selection = ShowMenu();

                //Tab 1 grabs a prompt from Entry, writes said prompt, and allows a user to respond to prompt, which is recorded and stored in Entry.
                if (selection == 1)
                {
                    string prompt = Entry.GetPrompt();
                    System.Console.WriteLine(prompt);
                    var placeholderResponse = Console.ReadLine();
                    var entry = new Entry(placeholderResponse, prompt, dateText);
                    journal.AddEntry(entry);
                }
                else if (selection == 2)
                {
                    journal.Display();
                    string pause = Console.ReadLine();
                }
                else if (selection == 3)
                {
                    Console.Write("Enter filename: ");
                    var filename = Console.ReadLine();
                    journal.Export(filename);
                }
                else if (selection == 4)
                {
                    Console.Write("Enter filename: ");
                    var filename = Console.ReadLine();
                    Journal.ReadFromFile(filename, journal);
                }
                else if (selection == 5){
                    keepGoing = false;
                }
            }
        }
    static int ShowMenu() {
        int numberSelection;
        System.Console.WriteLine("Select Option: \n 1. Add Entry \n 2. Display Journal \n 3. Save to file \n 4. Load from a file \n 5. Quit");
        
        System.Console.WriteLine("\n Enter your choice: ");
        string userInput = Console.ReadLine();
        numberSelection = int.Parse(userInput);
        return numberSelection;
    }

    }