using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please insert your grade: ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);

        if (number > 90 || number == 90)
        {   
            Console.WriteLine("Your grade is an A");
            Console.WriteLine("You have passed!");
        }
        else if (number > 80 || number == 80)
        {
            Console.WriteLine("Your grade is a B");
            Console.WriteLine("You have passed!");
        }
        else if (number > 70 || number == 70)
        {
            Console.WriteLine("Your grade is a C");
            Console.WriteLine("You have passed!");
        }
        else if (number > 60 || number == 60)
        {
            Console.WriteLine("Your grade is a D");
            Console.WriteLine("You Shall Not Pass");
        }
        else if(number < 60)
        {
            Console.WriteLine("F!");
            Console.WriteLine("You Shall Not Pass");
        }

    }
}