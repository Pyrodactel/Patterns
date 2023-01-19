using System;

namespace Patterns.Observer.Observers
{
	/// <summary>
	/// Союзник.
	/// </summary>
	public class Partner : IObserver
	{
		/// <summary>
		/// Имя.
		/// </summary>
		public string Name { get; set; } = "Напарник";

		/// <summary>
		/// Выводит реакцию на шум.
		/// </summary>
		public void Update()
		{
			Console.WriteLine($"{Name}: Не шуми!");
		}
	}
}