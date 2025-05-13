using System;
using System.Dynamic;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
    public class Fraction{
        private int _top;
        private int _bottom; 

        public int Top{
            get {return _top; }
            set { _top = value; }
        }
        public int Bottom{
            get {return _bottom; }
            set { _bottom = value; }
        }
         public Fraction(){
        Top = 1;
        Bottom = 1;
    }
     public Fraction(int wholeNumber){
        Top = 0;
        Bottom = 1;
    }
     public Fraction(int top, int bottom){
        Top = top;
        Bottom = bottom;
    }
    
    public string GetFractionString (){
        return $"{Top}/{Bottom}";
    }
    
    public double GetDecimalValue()
    {
        return (double)Top / Bottom;
    }
    
    }
   
    }

