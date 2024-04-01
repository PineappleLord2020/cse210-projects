public class Cycling: Exercise{
    private string activityName = "Cycling";
    private double distance;

    public Cycling(string date, double distance, double minutes): base (date, minutes){
        this.minutes = minutes;
        this.distance = distance;
    }

     public double PaceCalculator()
    {
        double pace = minutes/distance;
        return pace;
    }

    public double SpeedCalculator(){
        double speed;
        speed = distance/minutes * 60;
        return speed;
    }

    public override string Summary(){
      return $"{activityName} ({minutes} minutes) \n Distance: {distance} miles \n Speed: {SpeedCalculator()} mph \n Pace: {PaceCalculator()} min per mile";
    }

}