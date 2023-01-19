using Patterns.AbstractFactory.Implementation;

namespace Patterns.AbstractFactory.Factories
{
	/// <summary>
	/// Фабрика клонов старого поколения.
	/// </summary>
	public class CloneFactory2000 : ICloneFactory
	{
		/// <summary>
		/// Возвращает созданного рабочего.
		/// </summary>
		/// <returns>Созданный рабочий.</returns>
		public AbstractWorker CreateWorker()
		{
			return new Worker2000();
		}

		/// <summary>
		/// Возвращает созданного инженера.
		/// </summary>
		/// <returns>Созданный инженер.</returns>
		public AbstractEngineer CreateEngineer()
		{
			return new Engineer2000();
		}
	}
}