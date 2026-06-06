using System;
using System.Collections.Generic;

class List
{
	// A HashSet ignores repeats, so Add returns true only the first time a value appears.
	public static int Sum(System.Collections.Generic.List<int> myList)
	{
		var seen = new HashSet<int>();
		int total = 0;
		foreach (int value in myList)
			if (seen.Add(value))
				total += value;
		return total;
	}
}
