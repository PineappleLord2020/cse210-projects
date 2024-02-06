using System.Dynamic;
public class Fraction {
    private int top_number;
    private int bottom_number;

    public Fraction(){
        top_number = 1;
        bottom_number = 1;
    }

    public Fraction (int wholeNumber){
        top_number = wholeNumber;
        bottom_number = 1;
    }

    public Fraction(int a, int b){
        top_number = a;
        bottom_number = b;
    }
    
    public string GetFractionString (){
        string fraction = $"{top_number}/{bottom_number}";
        return fraction;
    }

    public void SetFraction(int firstNumber, int secondNumber){
        top_number = firstNumber;
        bottom_number = secondNumber;
    }

    public double GetDecimalValue (){
        return (double)top_number / (double)bottom_number;
    }

}