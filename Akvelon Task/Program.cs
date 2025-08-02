namespace Akvelon_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

			Console.WriteLine("Input (press enter two times to submit):");

			List<string> inputLines = InputWithLines();
			string joinedInput = string.Join(" ", inputLines);


			FizzBuzzDetector detector = new FizzBuzzDetector();
			FizzBuzzResult result = detector.getOverlappings(joinedInput);


			List<string> outputWords = result.OutputString.Split(' ').ToList();
			List<string> outputLines = OutputWithLines(outputWords, inputLines);



			Console.WriteLine("\noutput string:");
			foreach (string outLine in outputLines)
			{
				Console.WriteLine(outLine);
			}

			Console.WriteLine($"\ncount: {result.WordCount}");
		}

		public static List<string> OutputWithLines(List<string> outputWords, List<string> inputLines)
		{
			int index = 0;
			List<string> outputLines = new List<string>();

			foreach (string inputLine in inputLines)
			{
				int wordCount = inputLine.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;

				List<string> lineWords = outputWords.Skip(index).Take(wordCount).ToList();
				outputLines.Add(string.Join(" ", lineWords));
				index += wordCount;
			}

			return outputLines;
		}

		public static List<string> InputWithLines()
		{
			List<string> inputLines = new List<string>();
			string line = "";
			while (!string.IsNullOrEmpty(line = Console.ReadLine()))
			{
				inputLines.Add(line);
			}
			return inputLines;
		}
	}
}
