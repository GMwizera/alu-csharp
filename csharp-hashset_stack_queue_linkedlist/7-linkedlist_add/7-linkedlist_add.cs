using System;
using System.Collections.Generic;

class LList
{
	// AddFirst returns the node it just created at the head.
	public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
	{
		return myLList.AddFirst(n);
	}
}
