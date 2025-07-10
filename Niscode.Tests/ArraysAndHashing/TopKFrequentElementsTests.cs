using Niscode.ArraysAndHashing.TopKFrequentElements;

namespace Niscode.Tests.ArraysAndHashing;

public class TopKFrequentElementsTests
{
    [Theory]
    [MemberData(nameof(GetTestData))]
    public void TopKFrequent_ReturnsExpectedResult(int[] nums, int k, int[] expected)
    {
        var solution = new Solution();
        
        var result = solution.TopKFrequent(nums, k);
        
        Assert.Equal(
            new HashSet<int>(expected), 
            new HashSet<int>(result)
        );
    }

    public static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { 1, 2, 2, 3, 3, 3 }, 2, new[] { 2, 3 }];
        yield return [new[] { 7, 7 }, 1, new[] { 7 }];
        yield return [new[] { 5, 6, 5, 7, 6, 5 }, 1, new[] { 5 }];
        yield return [new[] { 1 }, 1, new[] { 1 }];
        yield return [new[] { -1, -1, -2, -2, -2, -3 }, 2, new[] { -2, -1 }];
        yield return [new[] { 4, 4, 4, 5, 5, 6 }, 2, new[] { 4, 5 }];
    }
}