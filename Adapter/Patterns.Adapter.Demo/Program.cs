using System;

namespace Patterns.Adapter.Demo
{
	internal class Program
    {
        private static void Main()
        {
            var russian = new Cyrillic();
            ILatin latin = new Transliterator(russian);
            Console.WriteLine(latin.GetLatinText());
            Console.ReadKey();
        }
    }
}
