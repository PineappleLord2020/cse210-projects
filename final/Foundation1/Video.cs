using System.Reflection;

public class Video{
    private string title;
    private string author;
    private int length;
    private List <Comment> comments;

    public Video(string title, string author, int length, List<Comment> comments){
        this.title = title;
        this.author = author;
        this.length = length;
        this.comments = comments;
    }

    public string Display() {
       
        var displayString = $"{title}: {author} \n {length} seconds \n";
        foreach(var comment in comments) {
            displayString += comment.Display();
        }
        int count = comments.Count;
        displayString += $" Total Comments: {count} \n";
        return displayString;
    }
}