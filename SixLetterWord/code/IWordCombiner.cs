namespace SixLetterWord.code;

public interface IWordCombiner
{
    IEnumerable<string> GetFullWordCombinations(List<string> fullWords, List<string> wordParts);
}