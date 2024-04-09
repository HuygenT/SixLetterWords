﻿using SixLetterWord.code;

namespace Test;

[TestFixture]
public class WordProcessorTests
{
    private WordProcessor wordProcessor;

    [SetUp]
    public void SetUp()
    {
        wordProcessor = new WordProcessor();
    }

    [Test]
    public void GetFullWords_Returns_Correct_Words()
    {
        string[] words = { "foobar", "fo", "obar", "baz", "qui" };
        int wordLength = 6;

        List<string> result = wordProcessor.GetFullWords(words, wordLength);

        Assert.That(result.Count, Is.EqualTo(1));
        Assert.That(result.First(), Is.EqualTo("foobar"));
    }

    [Test]
    public void GetWordParts_Returns_Correct_Words()
    {
        string[] words = { "foobar", "fo", "obar", "baz", "qui" };
        int wordLength = 6;

        List<string> result = wordProcessor.GetWordParts(words, wordLength);

        Assert.That(result.Count, Is.EqualTo(4));
        Assert.Contains("fo", result);
        Assert.Contains("obar", result);
        Assert.Contains("baz", result);
        Assert.Contains("qui", result);
    }
}