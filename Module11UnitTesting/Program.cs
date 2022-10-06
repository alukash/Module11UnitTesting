using System;
using System.Reflection.Metadata.Ecma335;

namespace Epam.Upskill.Module11UnitTesting
{
	internal class Program
	{
		static void Main(string[] args)
		{
			{
				if (args.Length == 0)
				{
					Console.WriteLine("Input is empty");
					return;
				}

				string input = args[0];
				Console.WriteLine("Initial string: " + input);

				string output;
				output = CharOperations.GetMaxDistinctChars(input);
				//	output = CharOperations.GetMaxSameLetters(input);
				//output = CharOperations.GetMaxSameDigits(input);

				Console.WriteLine();
				Console.WriteLine("Max sequence of distinct chars: " + output);

				Console.WriteLine();
				Console.Write("Press any key to close the app...");
				Console.ReadKey();
			}
		}
	}
}
