using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akvelon_Task
{
	public class FizzBuzzDetector
	{
		public FizzBuzzResult getOverlappings(string input)
		{
			if(input.Length < 7 || input.Length > 100)
			{
				throw new ArgumentOutOfRangeException();
			}
			FizzBuzzResult result = new FizzBuzzResult();
			string[] modifiedInput = input.Split().ToArray();

			for(int i = 0; i <= modifiedInput.Length; i++)
			{
				if(i % 3 == 0 && i % 5 == 0 && i > 1)
				{
					modifiedInput[i - 1] = "FizzBuzz";
					result.WordCount++;
				}
				else if(i % 3 == 0 && i > 1)
				{
					modifiedInput[i - 1] = "Fizz";
					result.WordCount++;
				}
				else if (i % 5 == 0 && i > 1)
				{
					modifiedInput[i - 1] = "Buzz";
					result.WordCount++;
				}
			}

			result.OutputString = string.Join(" ", modifiedInput);
			return result;
		}

	}

	
}
