using System;

class List
{
    public static List<int> CreatePrint(int size)
    {
        List<int> list = new List<int>();
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return list;
        }
        for (int i = 0; i < size; i++)
            list.Add(i);
        Console.WriteLine(string.Join(" ", list));
        return list;
    }
}
