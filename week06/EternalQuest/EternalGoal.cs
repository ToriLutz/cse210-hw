using System;
using System.Security.Cryptography.X509Certificates;
using MakingGoals;

namespace MakingGoals
{
    public class EternalGoals : Goal
    {
        public override int RecordEvent()
        {
            return _points;
        }
    }
}