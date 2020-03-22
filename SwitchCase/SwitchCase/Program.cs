using System;

class Program
{
    static void Main()
    {
        string a;
        int b;
        Console.Write("Thu tu ban muon tim kiem : ");
        a=Console.ReadLine();
        b = Int32.Parse(a);
        switch (b)
        {
            case 0:
                Console.WriteLine("Pikachu");
                break;
            case 1:
            case 2:
            case 3:
                Console.WriteLine("Nekoo");
                break;
            case 4:
                Console.WriteLine("Nacha");
                break;
            default:
                Console.WriteLine("vuot gioi han");
                break;
        }
        Console.ReadKey();
    }
}
