using System;

namespace Patterns.Singleton.Demo
{
	internal class Program
	{
		private static void Main()
		{
			var sadMan = Life.GetInstance("Вася", DateTime.Parse("01.01.1990"));

			Console.WriteLine($"Человек:\n{sadMan}\n");

			sadMan = Life.GetInstance("Alex", DateTime.Parse("01.01.2000"));

			Console.WriteLine($"Человек после попытки получить другую жизнь:\n{sadMan}");

			Console.ReadKey();
		}
	}
}
