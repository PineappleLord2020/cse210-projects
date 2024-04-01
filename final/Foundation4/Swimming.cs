public class Swimming: Exercise{
    private double laps;
    private string activityName = "Swimming";
    
    public Swimming(double laps, string date, double minutes): base (date, minutes){
        this.laps = laps;
        this.minutes = minutes;
    }

    public double DistanceCalculator()
    {
        double distance = laps * 50;
        distance = distance / 1000;
        distance = distance * 0.62;
        return distance;
    }

    public double PaceCalculator()
    {
        double distance = DistanceCalculator();
        double pace = minutes/distance;
        return pace;
    }

    public double SpeedCalculator(){
        double distance = DistanceCalculator();
        double speed = distance/minutes * 60;
        return speed;
    }

    public override string Summary(){
      return $"{activityName} ({minutes} minutes) \n Distance: {DistanceCalculator()} miles \n Speed: {SpeedCalculator()} mph \n Pace: {PaceCalculator()} min per mile";
    }

}