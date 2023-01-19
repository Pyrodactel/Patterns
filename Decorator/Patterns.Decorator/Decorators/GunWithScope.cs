using System;

namespace Patterns.Decorator.Decorators
{
	/// <summary>
	/// Пистолет с прицелом.
	/// </summary>
	public class GunWithScope : GunDecorator
	{
		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="gun">Пистолет для установки модуля.</param>
		public GunWithScope(Gun gun) : base(gun)
		{
			if (gun == null)
			{
				throw new ArgumentNullException(nameof(gun));
			}
		}

		/// <summary>
		/// Прицельно стреляет.
		/// </summary>
		public override void Shoot()
		{
			Console.Write("прицельный ");
			base.Shoot();
		}
	}
}