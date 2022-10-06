using NUnit.Framework;
using Epam.Upskill.Module11UnitTesting;

namespace Module11UnitTesting.Tests
{
	[TestFixture]
	public class CharOperationsTest
	{
		[SetUp]
		public void SetUp()
		{
		}

		[TestCase("a", "a")]
		[TestCase("1?#", "1?#")]
		[TestCase("aaaaaAaaa", "aA")]
		[TestCase("1a?2345b121234567 8#M95", "1234567 8#M9")]
		public void GetMaxDistinctChars(string input, string expected)
		{
			var actual = CharOperations.GetMaxDistinctChars(input);
			Assert.AreEqual(expected, actual);
		}

		[TestCase("a", "a")]
		[TestCase("aaaaaaaaA", "aaaaaaaa")]
		[TestCase("abcABC", "a")]
		[TestCase("1a?2345b121234567 8#mxXXXx95", "XXX")]
		[TestCase("1?#", "")]
		public void GetMaxSameLetters(string input, string expected)
		{
			var actual = CharOperations.GetMaxSameLetters(input);
			Assert.AreEqual(expected, actual);
		}

		[TestCase("1", "1")]
		[TestCase("122111", "111")]
		[TestCase("1a?2345b121234567 8#m2111x95", "111")]
		[TestCase("a?#", "")]
		public void GetMaxSameDigits(string input, string expected)
		{
			var actual = CharOperations.GetMaxSameDigits(input);
			Assert.AreEqual(expected, actual);
		}
	}
}
