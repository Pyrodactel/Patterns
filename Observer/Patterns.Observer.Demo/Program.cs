using Patterns.Observer.Observers;
using System;

namespace Patterns.Observer.Demo
{
	internal class Program
	{
		private static void Main()
		{
			var noise = new Noise();
			var player = new Player(noise);
			var partner = new Partner();
			var firstEnemy = new FirstEnemyType(noise);
			var secondEnemy = new SecondEnemyType(noise);

			noise.Attach(partner);

			while (true)
			{
				var isExitSelected = false;
				Console.Write("Выберете один из вариантов:\n" +
				              "1. Сменить укрытие\n" +
				              "2. Убить первого противника\n" +
				              "0. Выйти\n" +
				              "Выбор: ");
				var choice = Console.ReadLine();
				switch (choice)
				{
					case "1":
						player.ChangeHideout();
						break;
					case "2":
						player.Kill(firstEnemy);
						break;
					case "0":
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


