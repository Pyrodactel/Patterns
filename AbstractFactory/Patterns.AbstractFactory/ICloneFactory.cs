namespace Patterns.AbstractFactory
{
	/// <summary>
	/// Интерфейс фабрики клонов.
	/// </summary>
	public interface ICloneFactory
	{
		/// <summary>
		/// Создать рабочего.
		/// </summary>
		/// <returns>Созданный рабочий.</returns>
		AbstractWorker CreateWorker();

		/// <summary>
		/// Создать инженера.
		/// </summary>
		/// <returns>Созданный инженер.</returns>
		AbstractEngineer CreateEngineer();
	}
}