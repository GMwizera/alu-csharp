using System;

class Program
{
    static void Main(string[] args)
    {
        string output = "";
        for (int i = 0; i <= 99; i++)
            output += i.ToString("D2") + (i < 99 ? ", " : "\n");
        Console.Write(output);
    }
}
