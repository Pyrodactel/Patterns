using System;

namespace Patterns.AbstractFactory.Implementation
{
	/// <summary>
	/// Инженер первого поколения. 
	/// </summary>
	public class Engineer2000 : AbstractEngineer
	{
		/// <summary>
		/// Конструктор.
		/// </summary>
		public Engineer2000()
		{
			IntelligenceIndex = 5;
			Name = "Инженер первого поколения";
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