using System.ComponentModel.DataAnnotations;

public class Word{
    private string text;
    private bool hidden;
    public Word(string text){

    }

    public void Hide(){
        int word_length = word.Length;
        string result = new string ('_', word_length);
    }

    public bool IsHidden(string){
        foreach
    }
    
    public void Display(){
        System.Console.WriteLine($"{text}");
    }
    
    /*public static string hideWords (string word){
        Random gen = new Random();
        int prob = gen.Next(0,2);
        if (prob == 0){
            int word_length = word.Length;
            string result = new string ('_', word_length);
            return result;
        }
        else if (prob == 1) {
            return word;
        }
        else{
            return "error";
        }
    }*/
}
