using System.ComponentModel.Design;

public abstract class Events{
    private string eventTitle;
    private string eventDescription;
    private string date;
    private string time;
    private string eventAddress;

    public Events (string eventTitle, string eventDescription, string date, string time, string eventAddress){
        this.eventTitle = eventTitle;
        this.eventDescription = eventDescription;
        this.date = date;
        this.time = time;
        this.eventAddress = eventAddress;
    }

    public abstract string EventDetails();

    public abstract string EventType();

    public string DetailsStandard(){
        string standardDescription = $"{eventTitle}: {eventDescription} \n {date} @ {time} \n Located at: {eventAddress}";
        return standardDescription;
    }

    public string DetailsFull(){
        string eventType = EventType();
        string eventDetails = EventDetails();
        string fullDescription = $"{eventTitle}: {eventDescription} \n {date} @ {time} \n Located at: {eventAddress} \n This is a(n) {eventType}, please prepare appropriately. \n {eventDetails} ";
        return fullDescription;
    }

    public string ShortDescription(){
        string eventType = EventType();
        string shortDescription = $"{eventType} \n {eventTitle} \n {date}";
        return shortDescription;
    }
}