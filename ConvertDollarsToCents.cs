// using Internal;
using System;

namespace ConvertDollarsToCents
{
	public class Program
	{
		public static void Main(string[]args)
		{
			double dollar_amount;
			int cents;

			Console.Write("Enter dollar amount: ");
			dollar_amount = Convert.ToDouble(Console.ReadLine());

			cents = (int)(dollar_amount * 100);

            Console.WriteLine($"{dollar_amount}$ = {cents}cents");

            Console.ReadLine();
		}
	}
}