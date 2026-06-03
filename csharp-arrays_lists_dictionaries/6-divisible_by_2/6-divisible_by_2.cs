using System;

class List
{
   public static List<bool> DivisibleBy2(List<int> myList)
   {
    List<bool> divisible = new List<bool>();
    for (int i = 0; i < myList.Count; i++)
        divisible.Add(myList[i] % 2 == 0);
    return divisible;
    }
}
