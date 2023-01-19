using Patterns.Observer.Observers;
using System;

namespace Patterns.Observer
{
	/// <summary>
	/// Игрок.
	/// </summary>
	public class Player
	{
		/// <summary>
		/// Наблюдаемый объект.
		/// </summary>
		private readonly Noise _noise;

		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="noise">Наблюдаемый объект.</param>
		public Player(Noise noise)
		{
			_noise = noise ?? throw new ArgumentNullException(nameof(noise));
		}

		/// <summary>
		/// Сменить укрытие.
		/// </summary>
		public void ChangeHideout()
		{
			Console.WriteLine(" ** Игрок сменил укрытие ** ");
			_noise.GenerateNoise(70);
		}

		/// <summary>
		/// Убить противника.
		/// </summary>
		/// <param name="enemy">Противник.</param>
		public void Kill(Enemy enemy)
		{
			if (enemy == null)
			{
				throw new ArgumentNullException(nameof(enemy));
			}

			Console.WriteLine(" ** Игрок выстрелил в противника ** ");
			enemy.Die();

			_noise.GenerateNoise(100);
		}
	}
}