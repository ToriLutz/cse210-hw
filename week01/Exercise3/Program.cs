using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
       Random randomGenerator = new Random(); 
       int number = randomGenerator.Next(1, 100);
       Console.WriteLine($"The Magic number is {number}"); 
       string answer = "0";
       int magicNumber = int.Parse(answer);
       int guesses = 0;


       do{
        Console.WriteLine("Pick a number: ");
        answer = Console.ReadLine();
        guesses++; 
        magicNumber = int.Parse(answer);
        
            if (magicNumber == number)
            {
                
                Console.WriteLine("Congratulations you did it!");
                Console.WriteLine($"The number of guesses is {guesses}");
            }
            else if (magicNumber > number)
            {
                Console.WriteLine("lower");
            }
            else if (magicNumber < number)
            {
                Console.WriteLine("Higher");
            }

       }
       while (magicNumber != number);
    }
}