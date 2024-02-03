namespace Journal;

public class Entry {
    public string response;
    
    public string prompt;
    public string date;

    public Entry(string response, string prompt, string date){
        this.response = response;
        this.prompt = prompt;
        this.date = date;
    }

    public static string GetPrompt() {  //You can add this to the prompt class as well
        Random randomGenerator = new Random();
        List <string> prompts = new List<string> {"Who was the most interesting person I interacted with today?","What was the best part of my day?","How did I see the hand of the Lord in my life today?","What was the strongest emotion I felt today?","If I had one thing I could do over today, what would it be?"};
            
            int index = randomGenerator.Next(prompts.Count);
                
            return prompts[index];}
    
    public string export() {
        return ($"{response}|{prompt}|{date}");
    }

    public void display() {
        Console.WriteLine($"Date: {date} -- Prompt: {prompt} \n Response: {response}");
    }
}
