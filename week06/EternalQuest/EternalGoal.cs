using System.ComponentModel;
using MakingGoals;


namespace MakingGoals
{
    public class EternalGoals : Goal
    {
        public override void RecordEvent()
        {
            Console.WriteLine("Please insert what goal you would like to achieve: ");
            string ShortName = Console.ReadLine();
            Console.WriteLine("Please give me a description of what you will be doing ");
            string Description = Console.ReadLine();

        }

        public override string GetStringRepresentation()
        {
            return $"Eternal Goal: {ShortName} - {Description}";
        }

        
    }
}