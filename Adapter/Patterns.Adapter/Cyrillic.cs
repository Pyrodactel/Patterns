namespace Patterns.Adapter
{
	/// <summary>
	/// Содержит методы, возвращающие кириллицу.
	/// </summary>
	public class Cyrillic
	{
		/// <summary>
		/// Возвращает строку на русском языке.
		/// </summary>
		/// <returns>Строка на русском языке.</returns>
		public string GetRussianText()
		{
			return "ПриведЪ! Я использую кириллицу.";
		}
	}
}
