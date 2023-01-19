using System;

namespace Patterns.Observer.Observers
{
	/// <summary>
	/// Противник первого типа.
	/// </summary>
	public class FirstEnemyType : Enemy
	{
		/// <summary>
		/// Имя.
		/// </summary>
		public override string Name { get; } = "Противник 1";

		/// <summary>
		/// Выводит крик.
		/// </summary>
		protected override void Shout()
		{
			Console.WriteLine($"{Name}: Что это было?!");
		}

		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="observable">Наблюдаемый объект.</param>
		public FirstEnemyType(IObservable observable) : base(observable)
		{
			if (observable == null)
			{
				throw new ArgumentNullException(nameof(observable));
			}
		}
	}
}