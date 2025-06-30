using Niscode.ArraysAndHashing.GroupAnagrams;

namespace Niscode.Tests.ArraysAndHashing;

public class GroupAnagramsTests
{
    private readonly Solution _solution = new();
    
    #region TestData
    public static IEnumerable<object[]> TestData =>
        new List<object[]>
        {
            new object[]
            {
                new[] { "act", "pots", "tops", "cat", "stop", "hat" },
                new List<List<string>>
                {
                    new() { "hat" },
                    new() { "act", "cat" },
                    new() { "stop", "pots", "tops" },
                }
            },
            new object[]
            {
                new[] { "" },
                new List<List<string>>
                {
                    new() { "" }
                }
            },
            new object[]
            {
                new[] { "a" },
                new List<List<string>>
                {
                    new() { "a" }
                }
            }
        };
    #endregion


    [Theory]
    [MemberData(nameof(TestData))]
    public void GroupAnagramsTest(string[] input, List<List<string>> expected)
    {
        var result = new Solution().GroupAnagrams(input);

        // Normalise both expected and result by sorting each group and the outer list
        List<string> SortGroup(List<string> group) => group.OrderBy(x => x).ToList();

        var sortedExpected = expected.Select(SortGroup).OrderBy(g => string.Join(",", g)).ToList();
        var sortedResult = result.Select(SortGroup).OrderBy(g => string.Join(",", g)).ToList();

        Assert.Equal(sortedExpected, sortedResult);
    }
}