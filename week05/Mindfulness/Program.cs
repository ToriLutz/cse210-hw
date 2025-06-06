using System;
using System.Reflection.Metadata;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Chill Out App 3000");
        Console.WriteLine("would you like to");
        Console.WriteLine("1. Do a breathing activity ");
        Console.WriteLine("2. Do a reflection activity");
        Console.WriteLine("3. Do a listing activity?: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                break;
            case "2":
                ReflectingActivity reflection = new ReflectingActivity();
                reflection.Run();
                break;
            case "3":
                ListingActivity listing = new ListingActivity();
                listing.Run();
                break;
            default:
                Console.WriteLine("Invalid choice. Goodbye!");
                break;
        }
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
            return $"Thank you for participating in the {_name} have a good day :)";
        }

        //the only timer that I could figure out included thread, the others used something called new Form?
        public int ShowCountDown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            return 0;
        }
        
    //i did my best lol 
        public int ShowSpinner(int durationSeconds = 3)
        {
            string[] spinnerChars = { "|", "/", "-", "\\" };
            int totalTicks = durationSeconds * 4;
            for (int i = 0; i < totalTicks; i++)
            {
                Console.Write(spinnerChars[i % spinnerChars.Length]);
                Thread.Sleep(250);
                Console.Write("\b");
            }
            return 0;

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
            //wasn't sure if the duration would stay the same so i put it down twice haha 
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

 public class ListingActivity : Activity
{
    private List<string> _prompts;
    protected List<string> User = new List<string>();

    public ListingActivity() : base("Listing Activity", "Guide the user to think broadly, by helping them list as many things as they can in a certain area of strength or positivity.", 60)
    {
        _prompts = new List<string>()
        {
            "Gratitude: List 3 Things you are grateful for.",
            "Achievements: Write about 5 accomplishments or a time you overcame a challenge",
            "Self-Awareness: Identify 3 triggers that lead to negative thoughts and how you can manage them",
            "Values: List 5 core values and how they align with your actions.",
            "Positive Affirmations: Make 3 positive affirmations to tell yourself :)"
        };
    }

    public void Run()
    {
        Console.WriteLine(DisplayStartMessage());
        Console.WriteLine("Please write a list to help calm those nerves!");

        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);

        List<string> userItems = GetListFromUser();
        Console.WriteLine("You listed:");
        foreach (var item in userItems)
        {
            Console.WriteLine($"- {item}");
        }

        Console.WriteLine(DisplayEndMessage());
    }
// i love Random rnd = new Random();, it's much easier to my mind than python 
    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        Console.WriteLine("Please enter items separated by commas (e.g., item1, item2, item3):");
        string userInput = Console.ReadLine();

        List<string> userItems = new List<string>();

        if (!string.IsNullOrEmpty(userInput))
        {
            string[] items = userInput.Split(',');

            foreach (string item in items)
            {
                userItems.Add(item.Trim());
            }
        }

        return userItems;
    }
}

    public class ReflectingActivity : Activity
    {
        private List<string> _reflectionPrompts;
        private List<string> _promptQuestions;
        protected List<string> User = new List<string>();

        public ReflectingActivity() : base("Reflection Activity", "Guide the user to think deeply, by having them consider a certain experience when they were successful or demonstrated strength. Then, prompt them with questions to reflect more deeply about details of this experience.", 120)
        {
            _reflectionPrompts = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

            _promptQuestions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?"
        };


        }

//is there a better way to implement the spinner? probably
        public void Run()
        {
            Console.WriteLine(DisplayStartMessage());
            DisplayPrompt();
            ShowSpinner();
            Console.ReadLine();
            ShowSpinner();
            DisplayQuestion();
            ShowSpinner();
            Console.ReadLine();
            Console.WriteLine(DisplayEndMessage());

        }
        public string GetRandomPrompt()
        {
            Random rnd = new Random();
            int index = rnd.Next(_reflectionPrompts.Count);
            return _reflectionPrompts[index];

        }
        public string GetRandomQuestion()
        {
            Random rnd = new Random();
            int index = rnd.Next(_promptQuestions.Count);
            return _promptQuestions[index];
        }

        public void DisplayPrompt()
        {
            GetRandomPrompt();
            Console.WriteLine(GetRandomPrompt());

        }

        public void DisplayQuestion()
        {
            GetRandomQuestion();
            Console.WriteLine(GetRandomQuestion());
            
        }
    }
}