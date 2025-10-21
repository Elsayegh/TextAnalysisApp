
namespace TextAnalysisApp
{
    public class FileReader
    {
        public string ReadText(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("File is not found", path);

            //.toLower to prevent duplicates if word case was different
            return File.ReadAllText(path).ToLower(); 
        }
    }
}