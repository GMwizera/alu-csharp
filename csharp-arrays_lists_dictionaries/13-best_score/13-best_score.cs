using System;
using System.Collections.Generic;

class Dictionary
{
	// Tracks the key whose value is the largest seen so far.
	public static string BestScore(Dictionary<string, int> myList)
	{
		if (myList.Count == 0)
			return "None";
		string best = "None";
		int max = int.MinValue;
		foreach (var entry in myList)
		{
			if (entry.Value > max)
			{
				max = entry.Value;
				best = entry.Key;
			}
		}
		return best;
	}
}