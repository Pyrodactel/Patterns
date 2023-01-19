using System;

namespace Patterns.Observer.Observers
{
	/// <summary>
	/// Противник.
	/// </summary>
	public abstract class Enemy : IObserver
	{
		/// <summary>
		/// Имя.
		/// </summary>
		public abstract string Name { get; }

		/// <summary>
		/// Наблюдаемый объект.
		/// </summary>
		private readonly IObservable _noise;

		/// <summary>
		/// Указывает состояние противника.
		/// </summary>
		private bool _isAlive = true;

		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="observable">Наблюдаемый объект.</param>
		protected Enemy(IObservable observable)
		{
			_noise = observable ?? throw new ArgumentNullException(nameof(observable));
			_noise.Attach(this);
		}

		/// <summary>
		/// Реагирует на шум.
		/// </summary>
		public void Update()
		{
			Shout();
		}

		/// <summary>
		/// Выводит крик.
		/// </summary>
		protected abstract void Shout();

		/// <summary>
		/// Умерщвляет противника.
		/// </summary>
		public void Die()
		{
			if (_isAlive)
			{
				Console.WriteLine($" ** {Name} убит ** ");
				_noise.Detach(this);
				_isAlive = false;
			}
			else
			{
				Console.WriteLine($" ** {Name} уже был мертв ** ");
			}
		}
	}
}