using Xunit;
using TextAnalysisApp;
using System.IO;

namespace TextAnalysisApp.Tests
{
    public class FileReaderTests
    {
        [Fact]
        public void ReturnsContent()
        {
            var reader = new FileReader();
            string filePath = @"..\TextAnalysisApp\input.txt";

            string content = reader.ReadText(filePath);

            Assert.NotEmpty(content);
            Assert.Contains("lorem ipsum dolor sit amet", content, StringComparison.OrdinalIgnoreCase);
            Assert.Contains("elit lorem ipsum dolor", content, StringComparison.OrdinalIgnoreCase);
            Assert.Contains("sit amet dolor lorem ipsum", content, StringComparison.OrdinalIgnoreCase);

            var analyzer = new TextAnalyzer();
            var frequency = analyzer.AnalyzeTextContent(content);

            Assert.Equal(8, frequency["lorem"]);
            Assert.Equal(6, frequency["ipsum"]);
            Assert.Equal(6, frequency["dolor"]);
            Assert.Equal(6, frequency["sit"]);
            Assert.Equal(6, frequency["amet"]);
            Assert.Equal(4, frequency["elit"]);
            Assert.Equal(2, frequency["consectetur"]);
        }

        [Fact]
        public void FileDoesNotExist()
        {
            var reader = new FileReader();
            string path = "somefile.txt";

            //this won't pass since that file doesn't exist
            Assert.Throws<FileNotFoundException>(() => reader.ReadText(path));
        }
    }
}
