using System;

namespace logic
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите свое имя:");
			string name = Console.ReadLine();
			foreach (var ch in name)
			{
				Console.Write(ch + " ");
			}
			Console.WriteLine("Последняя буква вашего имени {0}", name[name.Length - 1]);
			int i;
			Console.WriteLine("Ваше имя наоборот: ");
			for (i = name.Length - 1; i > -1; i--)
            {
				Console.Write(name[i] + " ");
			}
			Console.WriteLine();
			Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
			int t = 0;
			do
			{
				Console.WriteLine("Iteration {0}", t);
				t++;
				var color = Console.ReadLine();

				switch (color)
				{
					case "red":
						Console.BackgroundColor = ConsoleColor.Red;
						Console.ForegroundColor = ConsoleColor.Black;

						Console.WriteLine("Your color is red!");
						break;

					case "green":
						Console.BackgroundColor = ConsoleColor.Green;
						Console.ForegroundColor = ConsoleColor.Black;

						Console.WriteLine("Your color is green!");
						break;

					case "cyan":
						Console.BackgroundColor = ConsoleColor.Cyan;
						Console.ForegroundColor = ConsoleColor.Black;

						Console.WriteLine("Your color is cyan!");
						break;

					default:
						Console.BackgroundColor = ConsoleColor.Yellow;
						Console.ForegroundColor = ConsoleColor.Red;

						Console.WriteLine("Your color is default!");
						break;
				}
			} while (t < 3);
		}
	}
}
