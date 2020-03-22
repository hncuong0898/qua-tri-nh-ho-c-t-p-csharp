using System;

class Program
{
    static void Main()
    {
        DateTime nextYear = new DateTime(DateTime.Today.Year + 1, 1, 1);
        TimeSpan duration = nextYear - DateTime.Today;
        Console.WriteLine("con lai {0} ngay de qua nam tiep theo!!",duration.TotalDays); //totalDays = chi lay ngay
        Console.ReadKey();
    }
}
