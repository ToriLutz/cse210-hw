using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers; 
        numbers = new List<int>();
        string number = "1";
        int listAdd = int.Parse(number);

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do{
            Console.WriteLine("Enter a number:");
            number = Console.ReadLine();
            listAdd = int.Parse(number);
                if (listAdd != 0)
                {
                     numbers.Add(listAdd);
                }
        }   
        while (listAdd != 0);
        int sum = numbers.Sum();
        double avg = numbers.Average();
        int max = numbers.Max();

        Console.WriteLine("Your list of numbers: " + string.Join(", ", numbers));
        Console.WriteLine($"Your sum is: {sum}");
        Console.WriteLine($"Your Average is: {avg}");
        Console.WriteLine($"The largest number is: {max}");

    
    }
}