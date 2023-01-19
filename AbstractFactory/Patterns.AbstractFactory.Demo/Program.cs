using System;
using Patterns.AbstractFactory.Factories;

namespace Patterns.AbstractFactory.Demo
{
	internal class Program
	{
		private static void Main()
		{
			Console.WriteLine(" * Тест клонов первого поколения * ");
			TestClones(new CloneFactory2000());
			Console.WriteLine();

			Console.WriteLine(" * Тест клонов второго поколения * ");
			TestClones(new CloneFactory3000());

			Console.ReadKey();
		}

		/// <summary>
		/// Тестирует клонов фабрики.
		/// </summary>
		/// <param name="cloneFactory">Фабрика-создатель клонов для тестирования.</param>
		private static void TestClones(ICloneFactory cloneFactory)
		{
			if (cloneFactory == null)
			{
				throw new ArgumentNullException(nameof(cloneFactory));
			}

			var worker = cloneFactory.CreateWorker();
			var engineer = cloneFactory.CreateEngineer();

			const string box = "|_|";
			Console.WriteLine($"Тест силы (перемещение коробки):\n{box}");

			Console.WriteLine(worker.MoveBox(box));

			Console.WriteLine("Тест интеллекта (написание программы за заданное время):");
			Console.WriteLine(engineer.WriteProgram(100));
		}
	}
}
