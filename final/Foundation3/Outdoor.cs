public class Outdoor: Events{
    private string weather;
    private string eventType = "Outdoor";

    public Outdoor(string eventTitle, string eventDescription, string date, string time, string eventAddress, string weather): base(eventTitle, eventDescription, date, time, eventAddress){
        this.weather = weather;
    }

    public override string EventDetails(){
        return $"The forcast for the day is {weather}";
    }

    public override string EventType(){
        return eventType;
    }
}