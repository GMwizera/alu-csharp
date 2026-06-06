using System;
using System.Collections.Generic;

class LList
{
	// Walk node by node, returning the index of the first match (or -1).
	public static int FindNode(LinkedList<int> myLList, int value)
	{
		int index = 0;
		foreach (int data in myLList)
		{
			if (data == value)
				return index;
			index++;
		}
		return -1;
	}
}
