using System;
using System.Collections.Generic;

class LList
{
	// Accumulate every node's value.
	public static int Sum(LinkedList<int> myLList)
	{
		int total = 0;
		foreach (int value in myLList)
			total += value;
		return total;
	}
}
