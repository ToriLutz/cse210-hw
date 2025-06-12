using System.ComponentModel;
using MakingGoals;

namespace MakingGoals
{
    public abstract class Goal
    {
        protected string _shortName;
        protected string _description;
        protected int _points;
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
        public abstract void RecordEvent();
        public abstract bool IsCompleted(bool _isComplete);

        public string GetDetailsString()
        {
            return $"{goal()}, {IsCompleted}";
        }

        public abstract string GetStringRepresentation();
    }

}
