using System;

namespace Patterns.AbstractFactory
{
	/// <summary>
	/// Инженер.
	/// </summary>
	public abstract class AbstractEngineer
	{
		/// <summary>
		/// Индекс интеллекта.
		/// </summary>
		private int _intelligenceIndex = 1;

		/// <summary>
		/// Эталонное время написания демонстрационной программы. 
		/// </summary>
		private const int StandardWritingProgramTime = 4;

		/// <summary>
		/// Индекс интеллекта.
		/// </summary>
		public int IntelligenceIndex
		{
			get => _intelligenceIndex;
			protected set
			{
				if (value <= 0)
				{
					throw new ArgumentOutOfRangeException(nameof(IntelligenceIndex));
				}

				_intelligenceIndex = value;
			}
		}

		/// <summary>
		/// Название инженера.
		/// </summary>
		public string Name { get; protected set; }

		/// <summary>
		/// Возвращает результат написания программы.
		/// </summary>
		/// <param name="taskComplexity">Сложность задачи.</param>
		/// <returns>Результат написания программы.</returns>
		public virtual string WriteProgram(int taskComplexity)
		{
			if (taskComplexity <= 0)
			{
				throw new ArgumentOutOfRangeException(nameof(taskComplexity));
			}

			var elapsedTime = new Random().Next(taskComplexity / IntelligenceIndex);

			return (elapsedTime < StandardWritingProgramTime)
				? " написал: Console.WriteLine(\"Hello, World!\");"
				: " так и не закончил.";
		}
	}
}