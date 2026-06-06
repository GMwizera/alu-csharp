using System;
using System.Collections.Generic;

class LList
{
	// The list is ascending: insert before the first node larger than n.
	// If no node is larger, n belongs at the end.
	public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
	{
		var current = myLList.First;
		while (current != null)
		{
			if (current.Value > n)
				return myLList.AddBefore(current, n);
			current = current.Next;
		}
		return myLList.AddLast(n);
	}
}
