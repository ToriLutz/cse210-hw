using System.ComponentModel;
using System.Formats.Asn1;
using MakingGoals;

namespace MakingGoals
{
    public abstract class GoalManager : Goal
    {
        private List<Goal> goals = new List<Goal>();
        public void Start()
        {
            Console.WriteLine("Welcome to Eternal Quest");
            Console.WriteLine("Would you like to: ");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6.Quit");
            string Answer = Console.ReadLine();

            if (Answer == "6")
            {
                Console.WriteLine("Goodbye");
            }
            else if (Answer == "1")
            {
                Console.WriteLine("What kind of goal is it?");
                Console.WriteLine("1. Simple Goal ");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                string GoalAnswer = Console.ReadLine();

                Goal newGoal = null;
                if (GoalAnswer == "1")
                {
                    newGoal = new SimpleGoal();

                }
                else if (GoalAnswer == "2")
                {
                    newGoal = new EternalGoals();
                }
                else if (GoalAnswer == "3")
                {
                    newGoal = new ChecklistGoal();

                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
                newGoal.RecordEvent();
                goals.Add(newGoal);
                Console.WriteLine("Goal added!");


            }
            else if (Answer == "2")
            {


            }
            else if (Answer == "3")
            {

            }
            else if (Answer == "4")
            {

            }
            else if (Answer == "5")
            {

            }
            else
            {
                Console.WriteLine("INVALID CHOICE :(");
                Start();
            }
        }
    }
}