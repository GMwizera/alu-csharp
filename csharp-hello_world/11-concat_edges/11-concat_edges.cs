using System;

class Program
{
    static void Main(string[] args)
    {
        string str = "<full template string here>";
        str = str.Substring(A, B) + str.Substring(C, D) + str.Substring(E, F) + str.Substring(G, H);
        Console.WriteLine(str);
    }
}