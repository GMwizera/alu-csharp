using System;
using System.Collections.Generic;

class LList
{
	// Builds 0..size-1, printing each value as it is appended.
	public static LinkedList<int> CreatePrint(int size)
	{
		var llist = new LinkedList<int>();
		if (size < 0)
			return llist;
		for (int i = 0; i < size; i++)
		{
			llist.AddLast(i);
			Console.WriteLine(i);
		}
		return llist;
	}
}
