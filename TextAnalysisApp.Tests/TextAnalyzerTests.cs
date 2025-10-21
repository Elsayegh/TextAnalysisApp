namespace TextAnalysisApp.Tests;

public class TextAnalyzerTests
{
    [Fact]
    public void ReturnsCorrectFrequencies()
    {
        string text = "lorem ipsum dolor sit amet, consectetur adipiscing elit. lorem ipsum dolor sit amet,";
        var textAnayalyzer = new TextAnalyzer();

        var result = textAnayalyzer.AnalyzeTextContent(text);

        Assert.Equal(2, result["lorem"]);
        Assert.Equal(2, result["ipsum"]);
        Assert.Equal(2, result["dolor"]);
        Assert.Equal(2, result["sit"]);
        Assert.Equal(2, result["amet"]);
        Assert.Equal(1, result["consectetur"]);
        Assert.Equal(1, result["adipiscing"]);
        Assert.Equal(1, result["elit"]);
    }

    [Fact]
    public void ReturnsEmptyDictionary()
    {
        var analyzer = new TextAnalyzer();
        string input = string.Empty;

        var result = analyzer.AnalyzeTextContent(input);

        Assert.Empty(result);
    }
}
