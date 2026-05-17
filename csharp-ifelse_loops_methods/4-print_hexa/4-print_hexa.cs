using System;

class Program
{
    static void Main(string[] args)
    {
        string output = "";
        for (int i = 0; i <= 98; i++)
            output += i + " = 0x" + i.ToString("x") + "\n";
        Console.Write(output);
    }
}
