namespace SixLetterWord.code;

public class Program
{
    private const int DefaultWordLength = 6;

    static void Main(string[] args)
    {
        try
        {
            string[] words = new FileReader().ReadWords("..\\..\\..\\input.txt");

            var wordProcessor = new WordProcessor();
            var wordCombiner = new WordCombiner();

            var fullWords = wordProcessor.GetFullWords(words, DefaultWordLength);
            var wordParts = wordProcessor.GetWordParts(words, DefaultWordLength);

            var combinedWords = wordCombiner.GetFullWordCombinations(fullWords, wordParts);

            foreach (var combination in combinedWords)
            {
                Console.WriteLine(combination);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}