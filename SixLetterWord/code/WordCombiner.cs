namespace SixLetterWord;

public class WordCombiner
{
    public IEnumerable<string> GetFullWordCombinations(List<string> fullWords, List<string> wordParts)
    {
        foreach (var word1 in wordParts)
        {
            foreach (var word2 in wordParts)
            {
                if (word1 == word2) continue;
                var combinedWord = word1 + word2;
                if (fullWords.Contains(combinedWord))
                {
                    yield return $"{word1} + {word2} = {combinedWord}";
                }
            }
        }
    }
}