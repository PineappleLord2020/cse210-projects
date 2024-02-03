namespace Journal;

using System.Collections.Concurrent;
using System.IO.Enumeration;

public class Journal{
        
    public List<Entry> entries;

    public Journal() {
      entries = new List<Entry>();
    }

    public void Display() {
        //Call the entrys class to get all the entries, like foreach(Entry entires in entries) or something then display the data
        foreach (Entry entry in entries) {
            entry.display();
        }
    }

    public void AddEntry(Entry entry) {
        entries.Add(entry);
    }
    public void Export(string filename) {
        foreach (Entry entry in entries) {
        var pages = entry.export();
        using (StreamWriter outputFile = new StreamWriter(filename)){
            outputFile.WriteLine(pages);
        }
        }
    }
    static public void ReadFromFile(string filename, Journal journal){
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines) {
            string[] parts = line.Split("|");

            string response = parts[0];
            string prompt = parts[1];
            string date = parts[2];

            var entry = new Entry(response, prompt, date);
            journal.AddEntry(entry);
        }
    }
}