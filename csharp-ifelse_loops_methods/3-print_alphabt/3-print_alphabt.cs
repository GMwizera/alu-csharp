using System;

class Program
{
    static void Main(string[] args)
    {
        string alphabet = "";
        for (char c = 'a'; c <= 'z'; c++)
            if (c != 'q' && c != 'e')
                alphabet += c;
        Console.Write(alphabet);
    }
}
