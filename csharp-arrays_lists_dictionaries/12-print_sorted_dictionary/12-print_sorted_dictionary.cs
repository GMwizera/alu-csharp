using System;
using System.Collections.Generic;

class Dictionary
{
	
	public static void PrintSorted(Dictionary<string, string> myDict)
	{
		var keys = new List<string>();
		foreach (var entry in myDict)
			keys.Add(entry.Key);
		keys.Sort(StringComparer.Ordinal);
		foreach (var key in keys)
			Console.WriteLine("{0}: {1}", key, myDict[key]);
	}
}