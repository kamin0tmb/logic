using System;

namespace logic
{
	class Program
	{
		static void Main(string[] args)
		{
			var arr = new int[] { -5, 6, -9, 1, 2, -3, 4 };
			int s = 0;
			for (int c = 0; c < arr.Length; c++)
            {
				if (arr[c] > 0)
					s++;
            }
			Console.WriteLine("Количество положительных элементов массива равно {0}", s);
		}
	}
}
