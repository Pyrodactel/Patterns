using System;

namespace Patterns.Observer.Observers
{
	/// <summary>
	/// Противник второго типа.
	/// </summary>
	public class SecondEnemyType : Enemy
	{
		/// <summary>
		/// Имя.
		/// </summary>
		public override string Name { get; } = "Противник 2";

		/// <summary>
		/// Выводит крик.
		/// </summary>
		protected override void Shout()
		{
			Console.WriteLine($"{Name}: Наверно крысы.");
		}

		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="observable">Наблюдаемый объект.</param>
		public SecondEnemyType(IObservable observable) : base(observable)
		{
			if (observable == null)
			{
				throw new ArgumentNullException(nameof(observable));
			}
		}
	}
}