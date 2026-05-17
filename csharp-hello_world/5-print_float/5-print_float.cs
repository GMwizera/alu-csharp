using System;

class Program
{
    static void Main(string[] args)
    {
        float number = float.Parse(Console.ReadLine());
        Console.WriteLine("Float: " + number.ToString("F2"));
    }
}