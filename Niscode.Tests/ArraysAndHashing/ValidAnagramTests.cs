using Niscode.ArraysAndHashing.ValidAnagram;

namespace Niscode.Tests.ArraysAndHashing;

public class ValidAnagramTests
{
    private readonly Solution _solution = new();

    [Theory]
    [InlineData("anagram", "nagaram", true)]
    [InlineData("rat", "car", false)]
    [InlineData("a", "a", true)]
    [InlineData("ab", "a", false)]
    [InlineData("abcde", "edcba", true)]
    public void IsAnagram_ReturnsExpectedResult(string s, string t, bool expected)
    {
        var result = _solution.IsValidAnagram(s, t);
        Assert.Equal(expected, result);
    }
}