using System;

class Program
{
    static void Main()
    {
        var currentTime = DateTime.Now; //Day and Time now
        var today = DateTime.Today; // Day now
        var someDate = new DateTime(2000, 7, 16); //Day have time to default 12am
        var someMoment = new DateTime(2000, 7, 16, 8, 0, 0);  // Day have time 
        var tomorrow = DateTime.Today.AddDays(1); // Next day
        var yesterday = DateTime.Today.AddDays(-1); // Late day
        var someDay = DateTime.Parse("16/7/2000"); // Date other
        int year = currentTime.Year;
        int month = currentTime.Month;
        int second = currentTime.Second;
        Console.WriteLine("Time now : " + currentTime);
        Console.WriteLine("Day now : " + today);
        Console.WriteLine("Some date : " + someDate);
        Console.WriteLine("Some date have time : "+ someMoment);
        Console.WriteLine("Tomorrow : "+ tomorrow);
        Console.WriteLine("Yesterday : "+ yesterday);
        Console.WriteLine("Some date other : "+ someDay);
        Console.WriteLine("Year now : " + year);
        Console.WriteLine("Month now : " + month);
        Console.WriteLine("Second now: " + second);
        Console.ReadKey();
    }
}
