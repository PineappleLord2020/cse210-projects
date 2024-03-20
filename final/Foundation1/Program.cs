using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        bool run = true;
        List<Video> videos = new List<Video>();

        if (run){
            List<Comment> comments = new List<Comment> {
                new Comment("Youtube","thank you for the memories throughout the years"),
                new Comment("MrForShadow","It's just a theory, a game theory! -Matpat"),
                new Comment("DeadMeat","Thanks for everything, friend"),
                new Comment("SrPelo","What an icon, dude! Bye Mat and Thank you!!")
            };
            Video video = new Video("MatPat's FINAL Theory!", "The Game Theorists", 1523, comments );
            videos.Add(video);
            comments = new List<Comment> {
                new Comment("KilamajaroKen","If the first episode doesn't start with 'Previously, on X-Men' you dropped the ball."),
                new Comment("chicken","Good thing that they have kept the same Theme song, because that's one of the best part of X Men animated series."),
                new Comment("JH-mo7xm","The voice actor for Cyclops passed away, so its amazing how the replacement sounds exactly like him"),
                new Comment("__Henny__","Man RIP to all the X-men fans who couldn't be here to see this come to fruition. I know yall would be proud")
            };
            video = new Video("Marvel Animation's X-Men '97 | Official Trailer | Disney+", "Marvel Entertainment", 106, comments );
            videos.Add(video);
            comments = new List<Comment> {
                new Comment("rockyvicky3687",$"User: tries to delete a file \n Windows: file is already in use \n User searches entire earth to find where the file is in use"),
                new Comment("paulmilinski4048",$"'Designed for any device' \n \n 'Your processor isn't compatible with windows 11'"),
                new Comment("neon5729","This video now has 11 Million views"),
                new Comment("TriangIe","I remember telling myself I hoped Windows 11 would release in time for my first year of college, and it did! I got to explore a brand new version of Windows while doing college work.")
            };
            video = new Video("Introducing Windows 11", "Windows", 162, comments );
            videos.Add(video);
            comments = new List<Comment> {
                new Comment("isqhakov","Google is one of the few companies that does not close comments, I love you)))"),
                new Comment("matthewprokopenko8721",$"First time in a while I am genuinely excited for the design rewamp!"),
                new Comment("MinusTechTips","Getting Black Mirror's Nosedive vibes with those pastel colors all around :D"),
                new Comment("RicardoSilva-fb8iq","This version is full of custumization, brings  aesthetics vibes. I love that.")
            };
            video = new Video("#Android12: Designed for you", "Android", 45, comments );
            videos.Add(video);

            foreach (var currentVideo in videos){
                Console.WriteLine(currentVideo.Display());
            }
        }
    }
}