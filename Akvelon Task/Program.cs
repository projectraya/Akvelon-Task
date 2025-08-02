namespace Akvelon_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzDetector fizzBuzzDetector = new FizzBuzzDetector();

			Console.WriteLine("Enter your text (press ENTER twice to finish):"); 

			//this code ensures multiple lines of input can be pasted/written
			string row = "";
			List<string> rows = new List<string>();
			while (!string.IsNullOrWhiteSpace(row = Console.ReadLine()))
			{
				rows.Add(row);
			}
			string inputString = string.Join(" ", rows);
			

			FizzBuzzResult result = fizzBuzzDetector.getOverlappings(inputString);

            Console.WriteLine(result.OutputString);
            Console.WriteLine(result.WordCount);
        }
    }
}
