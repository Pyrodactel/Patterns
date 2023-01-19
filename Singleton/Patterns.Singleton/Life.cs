using System;

namespace Patterns.Singleton
{
	/// <summary>
	/// Человеческая жизнь.
	/// </summary>
	public class Life
	{
		/// <summary>
		/// Приватный конструктор.
		/// </summary>
		/// <param name="name">Имя человека.</param>
		/// <param name="birthDay">Дата начала жизни.</param>
		private Life(string name, DateTime birthDay)
		{
			_birthDay = birthDay;
			Name = name;
		}

		/// <summary>
		/// Имя человека.
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Дата начала жизни.
		/// </summary>
		private readonly DateTime _birthDay;

		/// <summary>
		/// Единственный экземпляр объекта.
		/// </summary>
		private static Life _instance;

		/// <summary>
		/// Возраст человека.
		/// </summary>
		public int Age
		{
			get
			{
				// Получаем текущую дату в заданном формате.
				// Пример: "20200505".
				var currentDate = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
				// Получаем дату рождения в заданном формате.
				// Пример: "19901010".
				var birthDay = int.Parse(_birthDay.ToString("yyyyMMdd"));
				// Возвращаем целую часть разницы дат в годах, путем деления на 10000, чтобы избавиться от месяцев и дней.
				// Пример: (20200505 - 19901010) / 10000 = 29.9495
				return (currentDate - birthDay) / 10000;
			}
		}

		/// <summary>
		/// Объект-блокировка для синхронизации потоков.
		/// </summary>
		private static readonly object Lock = new object();

		/// <summary>
		/// Получить экземпляр класса жизнь.
		/// </summary>
		/// <param name="name">Имя человека.</param>
		/// <param name="birthDay">Дата начала жизни.</param>
		/// <returns>Экземпляр класса жизнь.</returns>
		public static Life GetInstance(string name, DateTime birthDay)
		{
			if (birthDay > DateTime.Now)
			{
				throw new ArgumentOutOfRangeException($"Значение {nameof(birthDay)} не может быть больше текущей даты.");
			}

			if (string.IsNullOrEmpty(name))
			{
				throw new ArgumentException("Значение не может быть пустым или равным null.", nameof(name));
			}

			if (_instance == null)
			{
				lock (Lock)
				{
					if (_instance == null)
					{
						_instance = new Life(name, birthDay);
					}
				}
			}

			return _instance;
		}

		/// <summary>
		/// Переопределят приведение к строке.
		/// </summary>
		/// <returns>Приведенный к строке класс.</returns>
		public override string ToString()
		{
			return $"Имя: {Name}\n" +
				   $"Возраст: {Age}";
		}
	}
}
