using Akvelon_Task;

namespace FizzBuzzTests
{
	public class Tests
	{
		private FizzBuzzDetector _detector;

		[SetUp]
		public void Setup()
		{
			_detector = new FizzBuzzDetector();
		}

		[Test]
		public void TestGivenExample()
		{
			string input = "Mary had a little lamb Little lamb, little lamb Mary had a little lamb It's fleece was white as snow";
			var result = _detector.getOverlappings(input);
			Assert.That(result.WordCount, Is.EqualTo(9));
			Assert.That(result.OutputString, Is.EqualTo("Mary had Fizz little Buzz Fizz lamb, little Fizz Buzz had Fizz little lamb FizzBuzz fleece was Fizz as Buzz"));
		}

		[Test]
		public void TestNoAlphanumericWords()
		{
			string input = "!@#$%^&*() ---";
			var result = _detector.getOverlappings(input);
			Assert.That(result.WordCount, Is.EqualTo(0));
		}

		[Test]
		public void TestNullException()
		{
			Assert.Throws<System.NullReferenceException>(() => _detector.getOverlappings(null));
		}

		
		[Test]
		public void TestOnlyAlphanumeric()
		{
			string input = "one two three four five six seven eight nine ten";
			var result = _detector.getOverlappings(input);
			Assert.IsTrue(result.OutputString.Contains("Fizz"));
			Assert.IsTrue(result.OutputString.Contains("Buzz"));
			Assert.Greater(result.WordCount, 0);
		}

		[Test]
		public void TestShortInput()
		{
			Assert.Throws<System.ArgumentOutOfRangeException>(() => _detector.getOverlappings("short"));
		}
	}
}