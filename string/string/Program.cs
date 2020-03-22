using System;

class Program
{
    static void Main()
    {
        String a = " haha ";       
        string b = a.ToUpper();
        string c = b.TrimStart();
        string d = b.Substring(1,4);
        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.ReadKey();
    }
}