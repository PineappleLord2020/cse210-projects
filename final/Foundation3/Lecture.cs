public class Lecture: Events{
    private string speaker;
    private int capacity;
    private string eventType = "Lecture";

    public Lecture(string eventTitle, string eventDescription, string date, string time, string eventAddress, string speaker, int capacity): base(eventTitle, eventDescription, date, time, eventAddress){
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public override string EventDetails(){
        return $"The speaker(s) for this event is/are {speaker} \n Event Capacity: {capacity}";
    }

    public override string EventType(){
        return eventType;
    }
}