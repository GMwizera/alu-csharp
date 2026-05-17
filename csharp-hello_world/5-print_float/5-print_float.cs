using System;

class Program
{
    static void Main(string[] args)
    {
        float number = float.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Float: " + number.ToString("F2"));
    }
}