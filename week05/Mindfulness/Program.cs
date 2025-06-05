using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Chill Out App 3000");
        Console.WriteLine("would you like to");
        Console.WriteLine("1. Do a breathing activity ");
        Console.WriteLine("2. Do a reflection activity");
        Console.WriteLine("3. Do a listing activity?: ");
        Console.ReadLine();
    }

    public class Activity
    {
        private string _name;
        private string _description;
        private int _duration;

        public Activity(string Name, string Description, int Duration)
        {
            _name = Name;
            _description = Description;
            _duration = Duration;
        }
        public string DisplayStartMessage()
        {
            return $"Welcome {_name} to the {_description}, it will last {_duration} seconds";
        }
        public string DisplayEndMessage()
        {
            return $"Thank you for participating {_name} have a good day :)";
        }
        public int ShowCountDown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000); 
            }
            return 0;
        }
        public int ShowSpinner()
        {

        }
    }

    public class BreathingActivity : Activity
    {
        public BreathingActivity() : base("Breathing Exercise", "This activity helps you pace your breathing for relaxation.", 60)
    {
        
    }

        public void Run()
        {
            Console.WriteLine(DisplayStartMessage());

            int Duration = 60;
            int seconds = Duration;

            while (seconds > 0)
            {
                Console.WriteLine("Breathe in...");
                ShowCountDown(4);
                seconds -= 4;

                Console.WriteLine("Hold...");
                ShowCountDown(4);
                seconds -= 4;

                Console.WriteLine("Breathe out...");
                ShowCountDown(4);
                seconds -= 4;
            }
            Console.WriteLine(DisplayEndMessage());

        }
    }

    public class ListingActivity : Activity{
    public ListingActivity() : base("Listing Activity", "Guide the user to think broadly, by helping them list as many things as they can in a certain area of strength or positivity.", 60)
        {

        }
    
        private int _count;
        private List<string> _prompts;
        public void Run()
        {

        }
        public string GetRandomPrompt()
        {

        }

        public string GetListFromUser()
        {
            
        }
        
    }

    public class ReflectingActivity : Activity
    {
            public ReflectingActivity() : base("Reflection Activity", "Guide the user to think deeply, by having them consider a certain experience when they were successful or demonstrated strength. Then, prompt them with questions to reflect more deeply about details of this experience.", 60)
    {
        
        private List<string> _prompts;
        private List<string> _questions;
        
        public void Run()
        {

        }
        public string GetRandomPrompt()
        {

        }
        public string GetRandomQuestion()
        {

        }

        public void DisplayPrompt()
        {

        }

        public void DisplayQuestion()
        {
            
        }
    }
}