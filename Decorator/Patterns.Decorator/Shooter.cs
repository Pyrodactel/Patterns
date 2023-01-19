using System;

namespace Patterns.Decorator
{
	/// <summary>
	/// Стрелок.
	/// </summary>
	public class Shooter
	{
		/// <summary>
		/// Имя стрелка.
		/// </summary>
		public string Name { get; } = "Стрелок";

		/// <summary>
		/// Стреляет.
		/// </summary>
		/// <param name="gun">Пистолет, из которого ведется стрельба.</param>
		public void ShootAGun(Gun gun)
		{
			if (gun == null)
			{
				throw new ArgumentNullException(nameof(gun));
			}

			Console.Write(Name + " приготовился и сделал ");
			gun.Shoot();
		}

		/// <summary>
		/// Переопределяет преобразование в строку.
		/// </summary>
		/// <returns>Имя стрелка.</returns>
		public override string ToString()
		{
			return Name;
		}
	}
}
