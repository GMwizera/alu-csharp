using System;
using System.Collections.Generic;

class Dictionary
{
    public static void AddKeyValue(Dictionary<string, string> myDict, string key, string value)
    {
        myDict[key] = value;
		return myDict;
    }
}
