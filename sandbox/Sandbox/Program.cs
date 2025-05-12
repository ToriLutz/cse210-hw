using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
       
    }
    public static void addRecord (string ID, string name, string age, string filepath)
    {
        try{

            using (System.IO.StreamWriter file = new System.IO.StreamWriter (filepath = true));
        }
        catch(Exception ex)
        {
            throw new ApplicationException ("This program did an oopsie", ex);

        }
    }
}

