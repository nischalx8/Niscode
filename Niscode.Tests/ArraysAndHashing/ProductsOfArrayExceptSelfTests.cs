using Niscode.ArraysAndHashing.ProductsOfArrayExceptSelf;

namespace Niscode.Tests.ArraysAndHashing;

public class ProductsOfArrayExceptSelfTests
{
    [Theory]
    [MemberData(nameof(GetTestData))]
    public void ProductsOfArrayExceptSelfTest(int[] nums, int[] expected)
    {
        var solution = new Solution();
        
        var result = solution.ProductExceptSelf(nums);
        
        Assert.Equal(
            new HashSet<int>(expected), 
            new HashSet<int>(result)
        );
    }

    public static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { 1,2,3,4 }, new[] { 24, 12, 8, 6}];
        yield return [new[] { 1,2,4,6 }, new[] { 48, 24, 12, 8}];
        yield return [new[] { -1,0,1,2,3 }, new[] { 0, -6, 0, 0, 0}];
    }
}