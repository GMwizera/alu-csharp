using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        double percent = .7553;
        double currency = 98765.4321;
        CultureInfo culture = CultureInfo.GetCultureInfo("en-US");
        Console.WriteLine("Percent: " + percent.ToString("P2", culture));
        Console.WriteLine("Currency: " + currency.ToString("C2", culture));
    }
}