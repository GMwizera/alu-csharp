using System;
using System.Collections.Generic;

class LList
{
	// Walk to the node at the given index, then unlink it.
	public static void Delete(LinkedList<int> myLList, int index)
	{
		if (index < 0)
			return;
		var current = myLList.First;
		int i = 0;
		while (current != null)
		{
			if (i == index)
			{
				myLList.Remove(current);
				return;
			}
			current = current.Next;
			i++;
		}
	}
}
