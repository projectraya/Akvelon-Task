# Akvelon Task
Project Structure
  - FizzBuzzDetector.cs – Main logic
  - FizzBuzzResult.cs – Simple class with properties needed for the output
  - Program.cs – Handles input/output logic
  - FizzBuzzDetectorTests.cs – NUnit unit tests, 5 in total

Running Tests
If using Visual Studio:
1. Open Test Explorer
2. Click Run All

If using a console:
1. Select FizzBuzzTests project
2. dotnet test

Notes for potential improvements:
When there are new lines in the input, the output ignores them and gives a single line as a result. This could be fixed with storing the new lines' positions and reapplying them in the output string.
