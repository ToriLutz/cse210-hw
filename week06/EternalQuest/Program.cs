using System;
using System.Reflection.Metadata.Ecma335;

namespace MakingGoals
{
    class Program
{
    static void Main(string[] args)
    {

    }

    public abstract class Goal
    {
        private string _shortName;
        private string _description;
        private int _points;
        private bool _isComplete;

        public void SetName(string ShortName)
        {
            _shortName = ShortName;
        }
        public string GetName()
        {
            return _shortName;
        }
        public void SetDesc(string Description)
        {
            _description = Description;
        }
        public string GetDesc()
        {
            return _description;
        }

        public void SetPoints(int Points)
        {
            _points = Points;
        }

        public int GetPoints()
        {
            return _points;
        }

        public string goal()
        {
            return $"{_shortName}, {_description} this activity earns you {_points}";
        }
            public abstract void recordEvent();
        public abstract bool IsCompleted(bool _isComplete);

        public string GetDetailsString()
        {
            return $"{goal()}, Completed: {IsCompleted()}";
        }

        public abstract string GetStringRepresentation();
    }
}
}
