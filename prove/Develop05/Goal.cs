public abstract class Goal{
    private string _name;
    private string _description;
    private int _pointValue;

    public Goal(string name, string description, int pointValue){
        _name = name;
        _description = description;
        _pointValue = pointValue; 
    }

    public string GetName(){
        return _name;
    }

    public string GetDescription(){
        return _description;
    }

    public virtual int GetPointValue(){
        return _pointValue;
    }

    public void Display(){
        return Goal;
    }

}