
namespace TextAnalysisApp
{
    public class TextAnalyzer
    {
        private Dictionary<string, int> wordFrequencyCounter = new Dictionary<string, int>();
        public Dictionary<string, int> AnalyzeTextContent(string text)
        {
            wordFrequencyCounter.Clear();

            //remove punctuations
            //source: https://learn.microsoft.com/en-us/dotnet/csharp/how-to/parse-strings-using-split
            //ensuring that words are separated correctly
            var words = text.Replace(".", " ")
                            .Replace(",", " ")
                            .Replace("!", " ")
                            .Replace("?", " ")
                            .Split(new[] { ' ', '\r', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            /*
             * Looping over the output and count frequency if each word, if it's first time to see it
             * then it's count value will be 1 but if it exists then will increment count by 1.
             */ 
            foreach (var word in words)
            {
                if (wordFrequencyCounter.ContainsKey(word))
                    wordFrequencyCounter[word]++;
                else
                    wordFrequencyCounter[word] = 1;
            }

            return wordFrequencyCounter;
        }
    }
}