using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
       addRecord ("124", "Mercy", "24", "cake.txt");
    }
    public static void addRecord (string ID, string name, string age, string filepath)
    {
        try{

            using (System.IO.StreamWriter file = new System.IO.StreamWriter (@filepath, true))
            {
                file.WriteLine(ID + "," + name + "," + age);
            }
        }
        catch(Exception ex)
        {
            throw new ApplicationException ("This program made an error", ex);

        }
    }
}

