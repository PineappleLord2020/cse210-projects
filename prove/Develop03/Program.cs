using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

public class Program
{

        public Scripture scripture;

        var reference = new Reference ("3", "16", "John");
        var scripture = new Scripture ("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life");

        
        Scripture.Display();
        Scripture.HideWords();
        Scripture.AreAllHidden();

    }

/*bool run = true;

        while (run){
            System.Console.WriteLine("Memorize the following scripture");
            string response = Console.ReadLine();
            if (response == "quit"){
                run = false;
            }
            else{
                string reference = "John 3:16";
                string scripture = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life";
                string hidden_words = Reference.Word_Splitter(scripture);
                Console.WriteLine($"{reference}: {hidden_words}");
            }
        };*/