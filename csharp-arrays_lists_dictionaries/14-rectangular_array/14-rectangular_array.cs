using System;

class Program
{
	static void Main(string[] args)
	{
		// 5x5 grid: all zeros except the centre [2,2] which is 1.
		int[,] grid = new int[5, 5];
		grid[2, 2] = 1;

		for (int i = 0; i < 5; i++)
		{
			for (int j = 0; j < 5; j++)
			{
				Console.Write(grid[i, j]);
				if (j != 4)
					Console.Write(" ");
			}
			Console.WriteLine();
		}
	}
}