using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Epam.Upskill.Module11UnitTesting
{
	public class CharOperations
	{
		public static string GetMaxDistinctChars(string str)
		{
			string distinctChars = new(str.Distinct().ToArray());
			string[] strings = Array.Empty<string>();

			for (int i = 0; i < str.Length; i++)
			{
				string strTemp = string.Empty;
				string distinctCharsTemp = distinctChars;
				for (int j = i; j < str.Length; j++)
				{
					if (distinctCharsTemp.Length == 0)
					{
						distinctCharsTemp = distinctChars;
						strings = strings.Append(strTemp).ToArray();
						strTemp = string.Empty;
					}
					if (distinctCharsTemp.Contains(str[j]))
					{
						strTemp += str[j];
						distinctCharsTemp = distinctCharsTemp.Replace(str[j].ToString(), string.Empty);
					}
					else
					{
						strings = strings.Append(strTemp).ToArray();
						strTemp = str[j].ToString();
						distinctCharsTemp = distinctChars;
						distinctCharsTemp = distinctCharsTemp.Replace(str[j].ToString(), string.Empty);
					}
				}
				strings = strings.Append(strTemp).ToArray();
			}
			return strings.OrderByDescending(str => str.Length).First();
		}

		public static string GetMaxSameLetters(string input)
		{
			input = Regex.Replace(input, "[^a-zA-Z]+", " ").Trim();
			return GetMaxSameChars(input);
		}

		public static string GetMaxSameDigits(string input)
		{
			input = Regex.Replace(input, "[^0-9]+", " ").Trim();
			return GetMaxSameChars(input);
		}

		private static string GetMaxSameChars(string input)
		{
			string[] strings = input.Split(" ");
			string[] stringsOut = Array.Empty<string>();
			foreach (string str in strings)
			{
				string strTemp = string.Empty;
				for (int i = 0; i < str.Length; i++)
				{
					if (str.Length == 1)
					{
						strTemp = str[0].ToString();
						break;
					}
					if (str[i] == str[i + 1])
					{
						strTemp = strTemp + str[i];
					}
					else
					{
						strTemp = strTemp + str[i];
						stringsOut = stringsOut.Append(strTemp).ToArray();
						strTemp = string.Empty;
					}
					if (i + 2 == str.Length)
					{
						strTemp = strTemp + str[i + 1];
						break;
					}
				}
				stringsOut = stringsOut.Append(strTemp).ToArray();
			}
			return stringsOut.OrderByDescending(str => str.Length).First();
		}
	}
}
