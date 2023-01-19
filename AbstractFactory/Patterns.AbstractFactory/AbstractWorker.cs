using System;

namespace Patterns.AbstractFactory
{
	/// <summary>
	/// Рабочий.
	/// </summary>
	public abstract class AbstractWorker
	{
		/// <summary>
		/// Индекс силы.
		/// </summary>
		private int _powerIndex;

		/// <summary>
		/// Индекс силы.
		/// </summary>
		public int PowerIndex
		{
			get => _powerIndex;
			protected set
			{
				if (value <= 0)
				{
					throw new ArgumentOutOfRangeException(nameof(PowerIndex));
				}

				_powerIndex = value;
			}
		}

		/// <summary>
		/// Название рабочего.
		/// </summary>
		public string Name { get; protected set; }

		/// <summary>
		/// Возвращает визуализацию смещения коробки.
		/// </summary>
		/// <param name="box">Коробка, которую нужно переместить.</param>
		/// <returns>Визуализация смещения коробки.</returns>
		public virtual string MoveBox(string box)
		{
			if (string.IsNullOrEmpty(box))
			{
				throw new ArgumentException("Значение не может быть пустым или равным null.", nameof(box));
			}

			return " сдвинул коробку:\n" + new string(' ', PowerIndex) + box;
		}
	}
}