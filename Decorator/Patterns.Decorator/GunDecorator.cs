using System;

namespace Patterns.Decorator
{
	/// <summary>
	/// Декоратор пистолета.
	/// </summary>
	public abstract class GunDecorator : Gun
	{
		/// <summary>
		///	Пистолет.
		/// </summary>
		protected Gun Gun;

		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="gun">Пистолет для установки модуля.</param>
		protected GunDecorator(Gun gun)
		{
			Gun = gun ?? throw new ArgumentNullException(nameof(gun));
		}

		/// <summary>
		/// Стреляет.
		/// </summary>
		public override void Shoot()
		{
			Gun?.Shoot();
		}
	}
}