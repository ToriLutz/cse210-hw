using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {

    }

    public class Goal
    {
        private string _shortName;
        private string _description;
        private int _points;

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
        public void recordEvent()
        {

        }

        public bool IsCompleted()
        {

        }

        public string GetDetailsString()
        {

        }

        public string GetStringRepresentation()
        {
            
        }
    }
}