using System;

namespace logic
{
	class Program
	{
		static void Main(string[] args)
		{
			int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
			int s = 0;
			for (int c = 0; c < arr.GetUpperBound(0) + 1; c++)
            {
				for (int i = 0; i < arr.GetUpperBound(1) + 1; i++)
				{
					if (arr[c,i] > 0)
						s++;
				}
            }
			Console.WriteLine("Количество положительных элементов массива равно {0}", s);
		}
	}
}
