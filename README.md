# TextAnalysisApp

- A .NET 8.0 console application that reads a text file, analyzes and calculate the word frequency,
then return the results in descending order.

# Structure

TextAnalysisApp
- Program.cs Entry point >> reads input file and prints word counts.
- FileReader.cs  read text content from a file.
- TextAnalyzer.cs analyzes and calculate the word frequency.
- input.txt is the input file used.
 
- TextAnalysisApp.Tests Unit tests for file reading and text analysis.

# How to Run

1. Open solution in Visual Studio 2022. (dobule click on .sln file or open via visual studio by opening the folder itself)
2. Ensure `input.txt` is placed in the `TextAnalysisApp` project folder.
3. Run the application. Output will show word frequencies sorted by count.

# Testing

Unit tests are written using xUnit:
- ReturnsContent Verifies file reading.
- FileDoesNotExist Ensure throw an exception if file doesn't exist.
- AnalyzeTextContent is to validate word frequency logic.

To run tests:
- Build the solution.
- Go to Test and then Run All Tests from the top menu.

Or run tests from the command line after navigating to the project path run the below command:
dotnet test TextAnalysisApp.Tests

Or just from view , choose terminal then navigate to the TextAnalysisApp.Tests and run below command
dotnet test

# Notes

- Input file path is currently hardcoded for simplicity.
- Punctuation is stripped manually (`.`, `,`, `!`, `?`) before analysis.
- Case is normalized to lowercase for consistent counting.

Since I was asked about Solid Principle in the first interview so considering it without over implementing things was taken into consideration

- Single Responsibility: Each class does one thing.
- Open/Closed: Easy to extend.
- Interface-driven: Promotes testability and abstraction.
- Minimal and readable: no unnecessary complexity.

# Improvements

- Allow dynamic file path input 
- Allow reading multiple files
- Support reading files containing various data types, such as binary content, gibberish text, code, numeric data, or structured formats like JSON.
- Improve punctuation handling (e.g. remove symbols like `...`, `--`, `#`, or `?????`)
- Export results to file or JSON.
- If there is intention to display the output into a UI, i.e web app, user could upload the file and output is displayed into UI, user could export into a CSV or maybe JSON.



