namespace Patterns.Observer
{
	/// <summary>
	/// Интерфейс наблюдаемого объекта.
	/// </summary>
	public interface IObservable
	{
		/// <summary>
		/// Присоединяет наблюдателя к наблюдаемому объекту.
		/// </summary>
		/// <param name="observer">Наблюдатель.</param>
		void Attach(IObserver observer);

		/// <summary>
		/// Отсоединяет наблюдателя от наблюдаемого объекта.
		/// </summary>
		/// <param name="observer">Наблюдатель.</param>
		void Detach(IObserver observer);

		/// <summary>
		/// Уведомляет всех наблюдателей о событии.
		/// </summary>
		void Notify();
	}
}