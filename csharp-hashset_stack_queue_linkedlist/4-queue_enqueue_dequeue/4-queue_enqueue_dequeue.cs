using System;
using System.Collections.Generic;

class MyQueue
{
	public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
	{
		Console.WriteLine("Number of items: {0}", aQueue.Count);
		if (aQueue.Count == 0)
			Console.WriteLine("Queue is empty");
		else
			Console.WriteLine("First item: {0}", aQueue.Peek());

		aQueue.Enqueue(newItem);

		bool found = aQueue.Contains(search);
		Console.WriteLine("Queue contains \"{0}\": {1}", search, found);

		// Remove items from the front until the searched item has been taken off as well.
		if (found)
		{
			string removed;
			do
			{
				removed = aQueue.Dequeue();
			} while (removed != search);
		}

		return aQueue;
	}
}
