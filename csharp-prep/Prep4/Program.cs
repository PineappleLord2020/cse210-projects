using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List <int> myInts = new List<int>();
        var otherInts = new List<int>();

        myInts.Add(10);
        myInts.Add(3);
        myInts.Add(45);

        for(var j=0; j<myInts.Count; ++j);

        foreach(var n in myInts) {
            System.Console.WriteLine($"n = {n}");
        }
    }
}