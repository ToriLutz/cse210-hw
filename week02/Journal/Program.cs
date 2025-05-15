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
        //this is so that you can make a list of journal entries to make it part of a file 
        private static List<string> journalEntries = new List<string>();

    static void Main(string[] args)
    {
        Journal();
    }
    public static void Journal ()
    {
        

         Console.WriteLine("Welcome to myJournal!");
         Console.WriteLine("Would you like to; ");
         Console.WriteLine("1. Write an entry,\n 2. Save your files,\n 3. load a file,\n 4. see your entire journal,\n 5. quit?  ");
         string answer = Console.ReadLine(); 


         if (answer == "5"){
            Console.WriteLine("Goodbye!");
         }
         else if (answer =="1"){
            Entry();
         }
         else if (answer == "2"){
            SaveAllEntries();
         }
         else if (answer == "3"){
            loadDisplay();
         }
         else if (answer == "4"){
            //display entire list of entries 
            foreach (string i in journalEntries){
                Console.WriteLine(i);
            }
         }
    }

//this is to write the entry
    public static void Entry (){
        string prompt = GeneratePrompt();
         Console.WriteLine("What is todays date?:  ");
        string date = Console.ReadLine();
        Console.WriteLine("Your prompt is: ");
        Console.WriteLine(prompt);
        Console.WriteLine("Please enter your journal prompt");
        string entry = Console.ReadLine();
        //this is to create the journal entry
        string formattedEntry = $"Date: {date}\nPrompt: {prompt}\nEntry: {entry}\n------------------------------";
        journalEntries.Add(formattedEntry);
    }
//saving entries to a filename of the users choice hopefully 
    public static void SaveAllEntries(){
        Console.WriteLine("Enter filename to save all journal entries (e.g., myjournal.csv):");
        string filename = Console.ReadLine();

        if (!filename.EndsWith(".csv"))
        {
            filename += ".csv";
        }

        using(StreamWriter writer = new StreamWriter(filename)) 
            {
                foreach (var entry in journalEntries){
                    writer.WriteLine(entry);
                }
            }

    }

   //this randomizes the prompt 
    public static string GeneratePrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(prompts.Length);
        return prompts[index];
    }

    public static void loadDisplay(){
        Console.WriteLine("Please enter a filename to load: "); 
        string name = Console.ReadLine();

        if(System.IO.File.Exists(name)){
            string[] lines = System.IO.File.ReadAllLines(name);
            if(lines.Length == 0){
                Console.WriteLine("This is empty");
                return;
            }
            for (int i = 0; i < lines.Length; i++){
                 Console.WriteLine($"{i + 1}. {lines[i]}");
            }
            
            if (int.TryParse(Console.ReadLine(), out int choice)){
                    if (choice > 0 && choice <=lines.Length){
                        Console.WriteLine("Selected Entry:");
                        Console.WriteLine(lines[choice - 1]);
                    }
                    else
                    {
                       Console.WriteLine("Invalid choice.");
                    }
                }
                else{
                    Console.WriteLine("Invalid choice");
                }
            
        }
        else{
            Console.WriteLine("File not found");
        }
    }


}