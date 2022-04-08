using System;

namespace logic
{
	class Program
	{
		static void Main(string[] args)
		{
			var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
			int temp;
			for (int i = 0; i < arr.Length; i++)
            {
				for (int j = i + 1; j < arr.Length; j++)
                {
					if (arr[i] > arr[j])
                    {
						temp = arr[i];
						arr[i] = arr[j];
						arr[j] = temp;
                    }

				}

			}
			for (int c = 0; c < arr.Length; c++)
            {
				Console.Write(arr[c]);
            }
		}
	}
}
