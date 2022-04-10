using System;

namespace logic
{
	class Program
	{
		static void Main(string[] args)
		{
			var (name, age) = ("Евгения", 27);
			Console.WriteLine("Ваше имя: {0}", name);
			Console.WriteLine("Ваш возраст: {0}", age);
			(string name, int age) anketa;
			Console.Write("Введите Ваше имя: ");
			anketa.name = Console.ReadLine();
			Console.Write("Введите Ваш возраст: ");
			anketa.age = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Ваше имя: {0}", anketa.Item1);
			Console.WriteLine("Ваш возраст: {0}", anketa.Item2);

		}
	}
}
