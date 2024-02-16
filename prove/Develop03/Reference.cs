using System.Diagnostics;

public class Reference {
   private string chapter;
   private string verse;
   private string book;

   public Reference (string chapter, string verse, string book) {
        this.chapter = chapter;
        this.verse = verse;
        this.book = book;
   }

   public void Display(){
        System.Console.WriteLine($"{book} {chapter}:{verse}");
   }
   
   
   /* public static string Word_Splitter(string scripture){
            string new_scripture = "";
            var split = scripture.Split(" ");
            foreach (string word in split){
                string new_word = Hidden.hideWords(word);
                new_scripture = new_scripture + " " + new_word;
            }
            return new_scripture;
        }*/

}