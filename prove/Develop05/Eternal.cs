public class Eternal: Goal{
    private int _completionAmount;
    private int _pointValue;

    public Eternal(string name, string description, int pointValue, int completionAmount): base(name, description, pointValue){
        _completionAmount = completionAmount;
        _pointValue = pointValue;
    }

    public override int GetPointValue(){
        return _completionAmount * _pointValue;
    }

}