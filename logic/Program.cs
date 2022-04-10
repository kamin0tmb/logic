using System;

namespace logic
{
	class Program
	{
		static void Main(string[] args)
		{
			(string Name, string Type, double Age, int NameCount) Pet;
			Console.Write("Введите имя Вашего питомца: ");
			Pet.Name = Console.ReadLine();
			Console.Write("Введите, какое животное Ваш питомец: ");
			Pet.Type = Console.ReadLine();
			Console.Write("Введите возраст Вашего питомца: ");
			Pet.Age = double.Parse(Console.ReadLine());
			Pet.NameCount = Pet.Name.Length;
			Console.WriteLine("Имя питомца: {0}", Pet.Item1);
			Console.WriteLine("Тип питомца: {0}", Pet.Item2);
			Console.WriteLine("Возраст питомца: {0}", Pet.Item3);
			Console.WriteLine("В имени Вашего питомца {0} букв.", Pet.Item4);
		}
	}
}
