using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
         //keeping this private so i don't mess it up later 
        private static string [] prompts = {
            "what made you smile today?; ",
            "Who was the most interesting person I interacted with today?: ",
            "What was the coolest animal you saw today?: ",
            "What was the hardest challenge you overcame today?: ",
            "What  was the funniest thing that happened today?: ",
            "What was something that made you hopeful?: ", 
            "What's something you will be looking forward to?: ",
            "What are your goals for tomorrow?: ",
            "What was the best thing you ate today?: ",
            "Who are you looking forward to seeing next?: ",
        };

    static void Main(string[] args)
    {
        
    }
    public static void Journal (string entry, string date, string filepath)
    {
         
    
    }

//this is to write the entry
    public static void Entry (string entry, string date, string filepath){
        string prompt = GeneratePrompt();
         Console.WriteLine("What is todays date?:  ");
        date = Console.ReadLine();
        Console.WriteLine("Your prompt is: ");
        Console.WriteLine(prompt);
        Console.WriteLine("Please enter your journal prompt");
        entry = Console.ReadLine();
        //this is to create the journal entry
            using(System.IO.StreamWriter file = new System.IO.StreamWriter (@filepath, true)) 
            {
                 file.WriteLine($"Date: {date}");
                 file.WriteLine($"Prompt: {prompt}");
                 file.WriteLine($"Entry: {entry}");
                 file.WriteLine("---------------------------------------------------");
            }
    }

   //this randomizes the prompt 
         public static string GeneratePrompt()
         {
            Random rnd = new Random();
            int index = rnd.Next(prompts.Length);
            return prompts[index];
         }

}