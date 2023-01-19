using System;

namespace Patterns.AbstractFactory.Implementation
{
	/// <summary>
	/// Рабочий второго поколения.
	/// </summary>
	public class Worker3000 : AbstractWorker
	{
		/// <summary>
		/// Конструктор.
		/// </summary>
		public Worker3000()
		{
			PowerIndex = 30;
			Name = "Рабочий второго поколения";
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