using System;

namespace logic
{
	class Program
	{
		static void Main(string[] args)
		{

			(string name, int age) anketa;
			Console.WriteLine("Введите Ваше имя: ");
			anketa.name = Console.ReadLine();
			Console.WriteLine("Введите Ваш возраст: ");
			anketa.age = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Ваше имя: {0}", anketa.Item1);
			Console.WriteLine("Ваш возраст: {0}", anketa.Item2);

		}
	}
}
