using Patterns.AbstractFactory.Implementation;

namespace Patterns.AbstractFactory.Factories
{
	/// <summary>
	/// Фабрика клонов нового поколения.
	/// </summary>
	public class CloneFactory3000 : ICloneFactory
	{
		/// <summary>
		/// Возвращает созданного рабочего.
		/// </summary>
		/// <returns>Созданный рабочий.</returns>
		public AbstractWorker CreateWorker()
		{
			return new Worker3000();
		}

		/// <summary>
		/// Возвращает созданного инженера.
		/// </summary>
		/// <returns>Созданный инженер.</returns>
		public AbstractEngineer CreateEngineer()
		{
			return new Engineer3000();
		}
	}
}