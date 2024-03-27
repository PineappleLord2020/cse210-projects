using System.Net;

public class Reception: Events{
    private string register;
    private string eventType = "Reception";

    public Reception(string eventTitle, string eventDescription, string date, string time, string eventAddress, string register): base(eventTitle, eventDescription, date, time, eventAddress){
        this.register = register;
    }

    public override string EventDetails(){
        string message = $"To reserve your seat, email us at {register}";
        return message;
    }

    public override string EventType(){
        return eventType;
    }
}