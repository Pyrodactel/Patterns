using System;

namespace Patterns.Decorator.Decorators
{
	/// <summary>
	/// Пистолет с расширенным магазином.
	/// </summary>
	public class GunWithExtendedMagazine : GunDecorator
	{
		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="gun">Пистолет для установки модуля.</param>
		public GunWithExtendedMagazine(Gun gun) : base(gun)
		{
			if (gun == null)
			{
				throw new ArgumentNullException(nameof(gun));
			}
		}

		/// <summary>
		/// Стреляет в два раза больше.
		/// </summary>
		public override void Shoot()
		{
			base.Shoot();
			base.Shoot();
		}
	}
}