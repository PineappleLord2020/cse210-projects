using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

public abstract class Exercise{
    private string date;
    protected double minutes;

    public Exercise(string date, double minutes){
        this.date = date;
        this.minutes = minutes;
    }

    public virtual string Summary(){
        return $"{date}";
    }
    
    // public string Display(){
    //     string summary = Summary();
    //     return $"{date} {summary}";
    // }
}