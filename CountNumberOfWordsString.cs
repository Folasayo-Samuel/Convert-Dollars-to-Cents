// using Internal;
using System;

namespace CountNumberOfWordsString
{
	public class Program
	{
		public static void Main(string[]args)
		{
			string sentence;
			Console.Write("Enter String: ");
			sentence = Console.ReadLine();
			string[] words = sentence.Split(' ');
			Console.WriteLine("Count of words: " + words.Length);
            Console.ReadKey();
        }
	}
}