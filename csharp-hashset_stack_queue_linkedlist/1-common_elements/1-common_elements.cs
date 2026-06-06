using System;
using System.Collections.Generic;

class List
{
	// Put list1 in a set for O(1) lookups, collect values from list2 that appear in it.
	public static System.Collections.Generic.List<int> CommonElements(
		System.Collections.Generic.List<int> list1, System.Collections.Generic.List<int> list2)
	{
		var inFirst = new HashSet<int>(list1);
		var common = new HashSet<int>();
		foreach (int value in list2)
			if (inFirst.Contains(value))
				common.Add(value);
		var result = new System.Collections.Generic.List<int>(common);
		result.Sort();
		return result;
	}
}
