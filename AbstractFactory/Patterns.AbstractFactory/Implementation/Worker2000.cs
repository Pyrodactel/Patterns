using System;

namespace Patterns.AbstractFactory.Implementation
{
	/// <summary>
	/// Рабочий первого поколения.
	/// </summary>
	public class Worker2000 : AbstractWorker
	{
		/// <summary>
		/// Конструктор.
		/// </summary>
		public Worker2000()
		{
			PowerIndex = 10;
			Name = "Рабочий первого поколения";
		}

		/// <summary>
		/// Возвращает визуализацию смещения коробки.
		/// </summary>
		/// <param name="box">Коробка, которую нужно переместить.</param>
		/// <returns>Визуализация смещения коробки.</returns>
		public override string MoveBox(string box)
		{
			if (string.IsNullOrEmpty(box))
			{
				throw new ArgumentException("Значение не может быть пустым или равным null.", nameof(box));
			}

			return Name + base.MoveBox(box);
		}
	}
}