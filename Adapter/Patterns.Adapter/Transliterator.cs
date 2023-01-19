using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns.Adapter
{
	/// <summary>
	/// Класс-адаптер, позволяющий преобразовать кириллицу в латиницу.
	/// </summary>
	public class Transliterator : ILatin
	{
		/// <summary>
		/// Адаптируемый объект.
		/// </summary>
		private readonly Cyrillic _cyrillic;

		/// <summary>
		/// Словарь транслитерации.
		/// </summary>
		private readonly Dictionary<char, string> _transliterationDictionary = new Dictionary<char, string>
		{
			{'a', "a"},
			{'б', "b"},
			{'в', "v"},
			{'г', "g"},
			{'д', "d"},
			{'е', "е"},
			{'ё', "yo"},
			{'ж', "zh"},
			{'з', "z"},
			{'и', "i"},
			{'й', "y"},
			{'к', "k"},
			{'л', "l"},
			{'м', "m"},
			{'н', "n"},
			{'о', "o"},
			{'п', "p"},
			{'р', "r"},
			{'с', "s"},
			{'т', "t"},
			{'у', "u"},
			{'ф', "f"},
			{'x', "kh"},
			{'ц', "ts"},
			{'ч', "ch"},
			{'ш', "sh"},
			{'щ', "sch"},
			{'ъ', string.Empty},
			{'ы', "y"},
			{'ь', "'"},
			{'э', "e"},
			{'ю', "yu"},
			{'я', "ya"}
		};

		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="cyrillic">Адаптируемый объект.</param>
		public Transliterator(Cyrillic cyrillic)
		{
			_cyrillic = cyrillic ?? throw new ArgumentNullException(nameof(cyrillic));
		}

		/// <summary>
		/// Возвращает текст на латинице.
		/// </summary>
		/// <returns>Текст на латинице.</returns>
		public string GetLatinText()
		{
			var message = _cyrillic.GetRussianText();

			if (message == null)
			{
				throw new ArgumentNullException(nameof(message));
			}

			var transliteratedMessage = new StringBuilder();
			foreach (var character in message)
			{
				if (_transliterationDictionary.TryGetValue(char.ToLower(character), out var transliteratedCharacter))
				{
					if (char.IsUpper(character) && !string.IsNullOrEmpty(transliteratedCharacter))
					{
						transliteratedCharacter = transliteratedCharacter.First().ToString().ToUpper() +
												  transliteratedCharacter.Substring(1);
					}
					transliteratedMessage.Append(transliteratedCharacter);
				}
				else
				{
					transliteratedMessage.Append(character);
				}
			}

			return transliteratedMessage.ToString();
		}
	}
}