using System;
using System.Collections.Generic;

class List
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int total = 0;
        foreach (var key in myDict.Keys)
            total++;
        return total;
    }
}
