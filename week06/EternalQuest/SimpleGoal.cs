using System.ComponentModel;
using MakingGoals;

namespace MakingGoals
{
    public abstract class SimpleGoal : Goal
    {
        protected List<Goal> goals = new List<Goal>();
        public override void RecordEvent()
        {
            if (goals.Count == 0)
            {
                Console.WriteLine("No goals to record an event for.");
                return;
            }
            Console.WriteLine("Select a goal to mark as complete:");
            for (int i = 0; i < goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {goals[i].GetStringRepresentation()}");
                }

            Console.Write("Enter the number of the goal: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int index) && index >= 1 && index <= goals.Count)
                {
                     goals[index - 1].MarkComplete(); 
                     Console.WriteLine("Goal marked as completed!");
                }
            else
                {
            Console.WriteLine("Invalid selection.");
                }




        }
    }
}