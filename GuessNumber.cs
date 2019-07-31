/*
 * Tested in SharpDevelop.
 * Date: 31.7.2019.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Guess a number between 1 and 100: ");
			var r = new Random();
			int randNumber = r.Next(1,100);
			int counter = 1;
			do
			{
				int number = Convert.ToInt32(Console.ReadLine());
				if (number > randNumber)
				{
					Console.Write("Guess number is smaller, try again: ");
				}
				if (number < randNumber)
				{
					Console.Write("Guess number is larger, try again: ");
				}
				if (number == randNumber)
				{
					Console.Write("Congratulations ");
					break;
				}
				counter++;
			}while (true);
			
			Console.WriteLine("you find a number from {0} times", counter);
			Console.ReadKey(true);
		}
	}
}
