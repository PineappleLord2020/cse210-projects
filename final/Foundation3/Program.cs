using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture apex = new Lecture("The True Conductor", "The Train is ours, not theirs! Learn who the true conductor is, and how the Apex allows you to get the most out of the train!", "August 13, 2020", "1:15 PM","The Mall Car", "Grace Monroe & Simon Laurent",50);
        Console.WriteLine(apex.DetailsFull());
        Console.WriteLine("");
        Reception codingIsCool = new Reception("Coding is Cool", "Meet with your fellow train passengers and learn how coding can help you navigate and control the train best!","August 5, 2019", "3:37 AM", "The Engine","toomanyturtles@compuserve.com");
        Console.WriteLine(codingIsCool.DetailsStandard());
        Console.WriteLine("");
        Outdoor donutHoler = new Outdoor("How to Sell a Donut Holer", "Team Randall is happy to present our first anniversary work party! Join Randall for fun games, a warm reception, Q&A with the founder, and desserts for everyone!", "August 9, 2020", "4:30 PM", "The Beach Car", "Sunny");
        Console.WriteLine(donutHoler.ShortDescription());
    }
}