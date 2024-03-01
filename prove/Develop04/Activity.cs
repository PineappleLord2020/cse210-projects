using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

public class Activity {
    private string welcome;
    private string description;
    private string ending;
    protected Activity(string welcome, string description, string ending){
        this.welcome = welcome;
        this.description = description;
        this.ending = ending;
    }

    public static void Timer(int timer, int pause){
        int miliseconds = pause * 1000;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(timer);

        Thread.Sleep(miliseconds);

        DateTime currentTime = DateTime.Now;
        if (currentTime < futureTime)
        {
            //I have no clue how to turn this into a loop
            System.Console.WriteLine("|");
            Thread.Sleep(miliseconds);
            System.Console.Write("\b \b"); // Erase the + character
            System.Console.Write("/"); // Replace it with the / character
            System.Console.Write("\b \b"); 
            System.Console.Write("-");
            System.Console.Write("\b \b"); 
            //The compiler hates this, how do you animate this spinning part without it getting upset??
            //System.Console.Write("\");
            System.Console.Write("\b \b"); }
        

    }
    public string BeginningInfo(){
        return $"{welcome} \n {description}";
    }

    public string EndingInfo(){
        return $"{ending}";
    }
}

public class Breathing : Activity {

    public Breathing(): base("Welcome to the Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.","Thank you for joining us today") {

    }

 
}

class Reflection : Activity {
    public Reflection(): base("Welcome to the Reflection Activity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.","Thank you for joining us today"){

    }
    
    public static string GetPrompt() { 
        Random randomGenerator = new Random();
        List <string> prompts = new List<string> {"Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.","Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."};
            
            int index = randomGenerator.Next(prompts.Count);
                
            return prompts[index];}

    public static string FollowUpPrompt() { 
        Random randomGenerator = new Random();
        List <string> followUpPrompts= new List<string> {"Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?","How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"};
            
            int index = randomGenerator.Next(followUpPrompts.Count);
                
            return followUpPrompts[index];}
}

class Listening : Activity {
    public Listening(): base("Welcome to the Listening Activity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life", "Thank you for joining us today"){

    }
    
    public static string GetPrompt() { 
        Random randomGenerator = new Random();
        List <string> prompts = new List<string> {"Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};
            
            int index = randomGenerator.Next(prompts.Count);
                
            return prompts[index];
    }

}