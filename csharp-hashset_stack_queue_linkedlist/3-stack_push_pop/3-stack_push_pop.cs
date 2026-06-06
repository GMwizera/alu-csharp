using System;
using System.Collections.Generic;

class MyStack
{
	public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
	{
		Console.WriteLine("Number of items: {0}", aStack.Count);
		if (aStack.Count == 0)
			Console.WriteLine("Stack is empty");
		else
			Console.WriteLine("Top item: {0}", aStack.Peek());

		bool found = aStack.Contains(search);
		Console.WriteLine("Stack contains \"{0}\": {1}", search, found);

		// Remove items from the top until the searched item has been taken off as well.
		if (found)
		{
			string removed;
			do
			{
				removed = aStack.Pop();
			} while (removed != search);
		}

		aStack.Push(newItem);
		return aStack;
	}
}
