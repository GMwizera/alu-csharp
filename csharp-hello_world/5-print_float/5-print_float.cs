using System;

class Program
{
    static void Main()
    {
        float number = float.Parse(Console.ReadLine());
        Console.WriteLine("Float: " + number.ToString("F2"));
    }
}