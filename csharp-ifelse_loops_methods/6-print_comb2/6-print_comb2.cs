using System;

class Program
{
    static void Main(string[] args)
    {
        string output = "";
        for (int i = 0; i <= 8; i++)
            for (int j = i + 1; j <= 9; j++)
                output += i.ToString() + j.ToString() + (i == 8 && j == 9 ? "\n" : ", ");
        Console.Write(output);
    }
}
