using System;
using System.Collections.Generic;

class LList
{
	// Walk every node and tally, since the LINQ tallying method is off-limits here.
	public static int Length(LinkedList<int> myLList)
	{
		int total = 0;
		foreach (int value in myLList)
			total++;
		return total;
	}
}
