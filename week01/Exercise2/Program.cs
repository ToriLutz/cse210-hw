using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please insert your grade: ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);
        string letterGrade = "";
        string digit = (number / 10).ToString();
        int digitGrade = int.Parse(digit);
        string final= "";

    

        if (number >= 70)
        {   
            Console.WriteLine("You have passed!");
        }
        else if(number < 70)
        {
            
            Console.WriteLine("You Shall Not Pass");
        }

        if (number > 90 || number == 90)
        {   
             letterGrade = "A";
            
        }
        else if (number > 80 || number == 80)
        {
             letterGrade = "B";
           
        }
        else if (number > 70 || number == 70)
        {
    
            letterGrade = "C";
        }
        else if (number > 60 || number == 60)
        {
             letterGrade = "D";
            
        }
        else if(number < 60)
        {
           letterGrade = "F";
          
        }
        
        if (letterGrade != "F")
        {
            if (digitGrade <= 3)
            {
                final = "-";
            }
            else if (digitGrade >= 7)
            {
                final = "+";
            }
            else
            {
                final = "";
            }
        }
        else
        {
            final = "";
        }

        Console.WriteLine($"your grade is {final} {letterGrade}");

    }


}