using System;

namespace logic
{
	class Program
	{
		static void Main(string[] args)
		{
			(string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;
			for (int j = 0; j < 3; j++)
			{
				Console.Write("Введите имя: ");
				User.Name = Console.ReadLine();
				Console.Write("Введите фамилию: ");
				User.LastName = Console.ReadLine();
				Console.Write("Введите логин: ");
				User.Login = Console.ReadLine();
				User.LoginLength = User.Login.Length;
				Console.Write("Есть ли у Вас домашнее животное? (да/нет): ");
				var H = Console.ReadLine();
				if (H == "да")
					User.HasPet = true;
				else
					User.HasPet = false;
				Console.Write("Введите Ваш возраст: ");
				User.Age = double.Parse(Console.ReadLine());
				Console.WriteLine("Введите три любимых цвета: ");
				User.favcolors = new string[3];
				for (int i = 0; i < User.favcolors.Length; i++)
				{
					User.favcolors[i] = Console.ReadLine();
				}
			}
		}
	}
}
