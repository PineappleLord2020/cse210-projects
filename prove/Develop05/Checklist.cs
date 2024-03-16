public class Checklist: Goal {
    private int _completionAmount;
    private int _bonusPointsAmount;
    private int _bonusCompletedAmount;
    private int _pointValue;
    private bool _bonusValue;
    private bool _isCompleted;
    public Checklist(string name, string description, int pointValue, int completionAmount): base(name, description, pointValue){
        _completionAmount = completionAmount;
    }

    public int GetCompletionAmount(){
        return _completionAmount;
    }

    public int TaskCompleted(){
        if (_isCompleted == true){
            return _completionAmount + 1;
        }
        else {
            return _completionAmount + 0;
        }
    }
    public bool GetBonus(){
        if (_completionAmount == _bonusCompletedAmount){
            return _bonusValue = true;
        }
        else{
            return _bonusValue = false;
        }
    }

    public int BonusPoints(int pointValue){
        if (_bonusValue == true){
            return _pointValue + _bonusPointsAmount;
        }
        else {
            return _pointValue + 0;
        }
    }

    public override int GetPointValue(){
        return _pointValue;
    }

    
}