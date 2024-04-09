namespace SixLetterWord;

public interface IWordProcessor
{
    List<string> GetFullWords(string[] words, int wordLength);
    List<string> GetWordParts(string[] words, int wordLength);
}