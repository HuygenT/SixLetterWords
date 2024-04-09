namespace SixLetterWord.code;

public class WordProcessor : IWordProcessor
{
    public List<string> GetFullWords(string[] words, int wordLength)
    {
        return words.Where(word => word.Length == wordLength).Distinct().ToList();
    }

    public List<string> GetWordParts(string[] words, int wordLength)
    {
        return words.Where(word => word.Length != wordLength).Distinct().ToList();
    }
}