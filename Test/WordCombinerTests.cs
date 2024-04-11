using SixLetterWord;
using SixLetterWord.code;

namespace Test;

[TestFixture]
public class WordCombinerTests
{
    [Test]
    public void GetFullWordCombinations_ReturnsCorrectCombinations()
    {
        var fullWords = new List<string> { "foobar", "hello" };
        var wordParts = new List<string> { "foo", "bar", "hell", "o" };
        var expectedCombinations = new List<string> { "foo + bar = foobar", "hell + o = hello" };

        var wordCombiner = new WordCombiner();

        var result = wordCombiner.GetFullWordCombinations(fullWords, wordParts);

        Assert.That(result, Is.EqualTo(expectedCombinations));
    }
}