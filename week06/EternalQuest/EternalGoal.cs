using System;
using System.Security.Cryptography.X509Certificates;
using MakingGoals;

namespace MakingGoals
{
    public abstract class EternalGoals : Goal
    {
        public override void RecordEvent()
        {
            Console.WriteLine("Please insert what goal you would like to achieve: ");
            string shortName = Console.ReadLine();

            Console.WriteLine("Please give me a description of what you will be doing: ");
            string description = Console.ReadLine();

            Console.WriteLine("How many points is it worth? ");
            string pointsInput = Console.ReadLine();
            int points;
            if (int.TryParse(pointsInput, out points))
            {
                SetName(shortName);
                SetDesc(description);
                SetPoints(points);
            }
            else
            {
                Console.WriteLine("Invalid points input. Setting points to 0.");
                SetName(shortName);
                SetDesc(description);
                SetPoints(0);
            }
        }

        public override string GetStringRepresentation()
        {

            return $"Eternal Goal: {GetName()} - {GetDesc()}";
        }

        public override bool IsCompleted(bool _isComplete)
        {
            return false;
        }
    }
}