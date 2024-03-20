using System.ComponentModel.DataAnnotations;
using System.Reflection;

public class Comment{
    private string user;
    private string comment;

    public Comment(string user, string comment){
        this.user = user;
        this.comment = comment;
    }
    

    public string Display(){
        var commentDisplay = $"{user}:  {comment} \n";
        return commentDisplay;
    }
}