using System;

namespace Patterns.Decorator.Decorators
{
	/// <summary>
	/// Пистолет с глушителем.
	/// </summary>
	public class GunWithSilencer : GunDecorator
	{
		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="gun">Пистолет для установки модуля.</param>
		public GunWithSilencer(Gun gun) : base(gun)
		{
			if (gun == null)
			{
				throw new ArgumentNullException(nameof(gun));
			}
		}

		/// <summary>
		/// Тихо стреляет.
		/// </summary>
		public override void Shoot()
		{
			Console.Write("тихий ");
			base.Shoot();
		}
	}
}