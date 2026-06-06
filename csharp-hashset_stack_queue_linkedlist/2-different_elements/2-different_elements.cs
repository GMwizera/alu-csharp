using System;
using System.Collections.Generic;

class List
{
	// Symmetric difference: keep values that are in exactly one of the two sets.
	public static System.Collections.Generic.List<int> DifferentElements(
		System.Collections.Generic.List<int> list1, System.Collections.Generic.List<int> list2)
	{
		var set1 = new HashSet<int>(list1);
		var set2 = new HashSet<int>(list2);
		var result = new System.Collections.Generic.List<int>();
		foreach (int value in set1)
			if (!set2.Contains(value))
				result.Add(value);
		foreach (int value in set2)
			if (!set1.Contains(value))
				result.Add(value);
		result.Sort();
		return result;
	}
}
