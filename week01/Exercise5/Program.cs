using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int inputNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(inputNumber);
        DisplayResult(userName, squaredNumber);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        int favNum = int.Parse(Console.ReadLine());
        return favNum;
    }

    static int SquareNumber(int number){
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square){
         Console.WriteLine($"{name}, the square of your number is {square}");
    }
    }