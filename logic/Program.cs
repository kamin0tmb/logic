using System;

namespace logic
{
	class Program
	{
		static void Main(string[] args)
		{
			var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
			int s = 0;
			for (int c = 0; c < arr.Length; c++)
            {
				s += arr[c];
            }
			Console.WriteLine("Сумма всех элементов архива {0}", s);
		}
	}
}
