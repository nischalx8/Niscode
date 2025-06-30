using Niscode.ArraysAndHashing.TwoSum;

namespace Niscode.Tests.ArraysAndHashing;

public class TwoSumTests
{
    private readonly Solution _solution = new();

    #region TestData
    public static IEnumerable<object[]> TestData =>
        new List<object[]>
        {
            new object[] { new[] { 3, 4, 5, 6 }, 7, new[] { 0, 1 } },
            new object[] { new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 } },
            new object[] { new[] { 3, 2, 4 }, 6, new[] { 1, 2 } },
            new object[] { new[] { 5, 5}, 10, new[] { 0, 1 } }
        };
    #endregion
    
    [Theory]
    [MemberData(nameof(TestData))]
    public void TwoSumTest(int[] nums, int target, int[] expected)
    {
        var result = _solution.TwoSum(nums, target);
        Assert.Equal(expected, result);
    }
}