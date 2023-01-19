namespace Patterns.Observer
{
	/// <summary>
	/// Интерфейс наблюдателя.
	/// </summary>
	public interface IObserver
	{
		/// <summary>
		/// Имя наблюдателя.
		/// </summary>
		string Name { get; }

		/// <summary>
		/// Получает обновление от издателя.
		/// </summary>
		void Update();
	}
}