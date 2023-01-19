using System;
using System.Collections.Generic;

namespace Patterns.Observer
{
	/// <summary>
	/// Шум.
	/// </summary>
	public class Noise : IObservable
	{
		/// <summary>
		/// Список наблюдателей.
		/// </summary>
		private readonly List<IObserver> _observers = new List<IObserver>();

		/// <summary>
		/// Присоединяет наблюдателя к наблюдаемому объекту.
		/// </summary>
		/// <param name="observer">Наблюдатель.</param>
		public void Attach(IObserver observer)
		{
			if (observer is null)
			{
				throw new ArgumentNullException(nameof(observer));
			}

			if (_observers.Contains(observer))
			{
				Console.WriteLine($" ** {observer.Name} уже слушал ** ");
				return;
			}

			Console.WriteLine($" ** {observer.Name} прислушался ** ");
			_observers.Add(observer);
		}

		/// <summary>
		/// Отсоединяет наблюдателя от наблюдаемого объекта.
		/// </summary>
		/// <param name="observer">Наблюдатель.</param>
		public void Detach(IObserver observer)
		{
			if (observer is null)
			{
				throw new ArgumentNullException(nameof(observer));
			}

			if (!_observers.Contains(observer))
			{
				Console.WriteLine($" ** {observer.Name} и так не слушал ** ");
				return;
			}

			_observers.Remove(observer);
			Console.WriteLine($" ** {observer.Name} больше не слушает ** ");
		}

		/// <summary>
		/// Уведомляет всех наблюдателей о событии.
		/// </summary>
		public void Notify()
		{
			foreach (var observer in _observers)
			{
				observer.Update();
			}
		}

		/// <summary>
		/// Генерирует шум с заданной вероятностью.
		/// </summary>
		/// <param name="noiseChance">Вероятность шума.</param>
		public void GenerateNoise(int noiseChance)
		{
			if (noiseChance < 0)
			{
				throw new ArgumentOutOfRangeException(nameof(noiseChance));
			}

			var randomNumber = new Random().Next(100);

			if (randomNumber < noiseChance)
			{
				Notify();
			}
		}
	}
}