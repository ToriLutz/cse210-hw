using System;

class Program
{
    static void Main(string[] args)
    {
         Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        
        MathAssignment a2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }

    public class Assignment
    {
        private string _studentName = "";
        private string _topic = "";

        public string GetStudentName()
        {
            return _studentName;
        }

        public string GetTopic()
        {
            return _topic;
        }

        public Assignment(string studentName, string topic)
        {
            _studentName = studentName;
            _topic = topic;
        }

        public string GetSummary()
        {
            return _studentName + " - " + _topic;
        }
    }

    public class MathAssignment : Assignment
    {
        private string _textbookSection;
        private string _problems;

        public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
        {
       
            _textbookSection = textbookSection;
            _problems = problems;
        }   


        public string GetHomeworkList()
        {
            return $"{_textbookSection} {_problems}";
        }
    }

    public class WritingAssignment : Assignment
    {
        private string _title;

        public WritingAssignment(string title, string studentName, string topic) : base(studentName, topic)
        {
            _title = title;
        }

        public string GetWritingInformation()
        {
            string studentName = GetStudentName();
            return $"{_title} by {studentName}";
        }
    }
}