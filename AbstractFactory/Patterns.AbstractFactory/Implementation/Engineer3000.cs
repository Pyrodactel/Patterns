using System;

namespace Patterns.AbstractFactory.Implementation
{
	/// <summary>
	/// Инженер второго поколения.
	/// </summary>
	public class Engineer3000 : AbstractEngineer
	{
		/// <summary>
		/// Конструктор.
		/// </summary>
		public Engineer3000()
		{
			IntelligenceIndex = 20;
			Name = "Инженер второго поколения";
		}

		/// <summary>
		/// Возвращает результат написания программы.
		/// </summary>
		/// <param name="taskComplexity">Время, данное на выполнение.</param>
		/// <returns>Результат написания программы.</returns>
		public override string WriteProgram(int taskComplexity)
		{
			if (taskComplexity <= 0)
			{
				throw new ArgumentOutOfRangeException(nameof(taskComplexity));
			}

			return Name + base.WriteProgram(taskComplexity);
		}
	}
}