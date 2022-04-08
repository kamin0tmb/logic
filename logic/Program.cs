using System;

namespace logic
{
	class Program
	{
		static void Main(string[] args)
		{
			int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
			int temp;
			for (int c = 0; c <= arr.GetUpperBound(0); c++)
			{
				for (int i = 0; i <= arr.GetUpperBound(1); i++)
				{
					for (int j = i + 1; j <= arr.GetUpperBound(1); j++)
					{
						if (arr[c,i] > arr[c,j])
						{
							temp = arr[c,j];
							arr[c,j] = arr[c,i];
							arr[c,i] = temp;
						}
					}
					Console.Write(arr[c,i] + " ");
				}
				Console.WriteLine();	
			}
		}
	}
}
