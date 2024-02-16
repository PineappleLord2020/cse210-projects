using Microsoft.VisualBasic;

public class Scripture{
    private Reference reference;
    private List<Word> words;

    public Scripture (Reference reference, string scriptText){
    }

    public void Display(){
        reference.Display();
        foreach(Word word in words){
            word.Display();
        }

    }

    public void HideWords(){
        for(var i=0, i<3, ++i){
            var word = words[i];
            word.Hide();
        }
    }
    public bool AreAllHidden(){
        foreach (Word word in words){
            Word.IsHidden(word);
        }

    }
}