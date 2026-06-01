using System;

class Array
{
    public static int[] Reverse(int[] array)
    {
        // if (array == null)
        // {
        //     // Console.WriteLine("$");
        //     return array;
        // }
        if (array.Length == 0)
        {
            // Console.WriteLine("$");
            return array;
        }
        for (int i = 0; i < array.Length / 2; i++)
        {
            int temp = array[i];
            array[i] = array[array.Length - i - 1];
            array[array.Length - i - 1] = temp;
        }
        Console.WriteLine(string.Join(" ", array) + "$");
        return array;
    }
}