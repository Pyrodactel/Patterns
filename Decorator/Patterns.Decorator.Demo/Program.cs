using Patterns.Decorator.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Patterns.Decorator.Demo
{
	internal class Programs
	{
		private static void Main()
		{
			var shooter = new Shooter();
			Gun someGun = new SomeGun();
			Console.WriteLine(" * Стрелок взял оружие * ");
			var menu = new Dictionary<int, string>
			{
				{1, "Пострелять"},
				{2, "Установить расширенный магазин"},
				{3, "Установить глушитель"},
				{4, "Установить прицел"},
				{0, "Выйти"}
			};
			while (true)
			{
				var isExitSelected = false;
				Console.WriteLine("Выберите:");
				menu.Keys.ToList().ForEach(key => Console.WriteLine($"{key}. {menu[key]}"));
				Console.Write("Выбор: ");
				if (!int.TryParse(Console.ReadLine(), out var choice))
				{
					continue;
				}
				switch (choice)
				{
					case 1:
						Console.WriteLine();
						shooter.ShootAGun(someGun);
						break;
					case 2:
						if (menu.ContainsKey(choice))
						{
							someGun = new GunWithExtendedMagazine(someGun);
							menu.Remove(choice);
						}
						break;
					case 3:
						if (menu.ContainsKey(choice))
						{
							someGun = new GunWithSilencer(someGun);
							menu.Remove(choice);
						}
						break;
					case 4:
						if (menu.ContainsKey(choice))
						{
							someGun = new GunWithScope(someGun);
							menu.Remove(choice);
						}
						break;
					case 0:
						isExitSelected = true;
						break;
				}

				if (isExitSelected)
				{
					break;
				}

				Console.WriteLine();
			}
		}
	}
}