using Niscode.ArraysAndHashing.LongestConsecutiveSequence;

namespace Niscode.Tests.ArraysAndHashing;

public class LongestConsecutiveSequenceTests
{
    #region MyRegion

    public static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { 2,20,4,10,3,4,5 }, 4];
        yield return [new[] { 0,3,2,5,4,6,1,1 }, 7];
    }

    #endregion

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void LongestConsecutiveTest(int[] nums, int k)
    {
        var solution = new Solution();
        var result = solution.LongestConsecutive(nums);
        Assert.Equal(k, result);
    }

}