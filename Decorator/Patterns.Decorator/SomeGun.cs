using System;

namespace Patterns.Decorator
{
	/// <summary>
	/// Какой-то пистолет.
	/// </summary>
	public class SomeGun : Gun
	{
		/// <summary>
		/// Стреляет.
		/// </summary>
		public override void Shoot()
		{
			Console.Write(" * Пиу * ");
		}
	}
}