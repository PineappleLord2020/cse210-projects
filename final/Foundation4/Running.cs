using System.Reflection.Metadata.Ecma335;

public class Running: Exercise{
    private double distance;
    private string activityName = "Running";


    public Running(double distance, double minutes, string date): base(date, minutes){
        this.minutes = minutes;
        this.distance = distance;
    }

    public double SpeedCalculator(){
        double speed;
        speed = distance/minutes * 60;
        return speed;
    }

    public double PaceCalculator(){
        double pace;
        pace = minutes/distance;
        return pace;
    }

public override string Summary(){
        return $"{base.Summary()} {activityName} ({minutes} minutes) \n Distance: {distance} miles \n Speed: {SpeedCalculator()} mph \n Pace: {PaceCalculator()} min per mile";
    }

}