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


       do{
        Console.WriteLine("Pick a number: ");
        answer = Console.ReadLine(); 
        magicNumber = int.Parse(answer); 
        
            if (magicNumber == number)
            {
                Console.WriteLine("Congratulations you did it!");
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