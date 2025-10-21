using System;
using System.IO;
using System.Reflection.PortableExecutable;

namespace TextAnalysisApp
{
    class Program
    {
        static void Main()
        {
            // for simplicity: hardcoded input file for now. Can be made dynamic so user can choose path.
            string _inputFile = "input.txt";

            try
            {
                FileReader reader = new FileReader();
                TextAnalyzer textAnayalyzer = new TextAnalyzer();

                string content = reader.ReadText(_inputFile);
                var countFrequency = textAnayalyzer.AnalyzeTextContent(content);

                // Sort words by frequency in descending order, then alphabetically
                foreach (var k in countFrequency.OrderByDescending(k => k.Value).ThenBy(k => k.Key))
                    Console.WriteLine($"{k.Key} Count is: {k.Value}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}