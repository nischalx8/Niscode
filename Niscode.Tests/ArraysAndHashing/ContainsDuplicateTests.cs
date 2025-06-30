using Niscode.ArraysAndHashing.ContainsDuplicate;

namespace Niscode.Tests.ArraysAndHashing
{
    public class ContainsDuplicateTests
    {
        private readonly Solution _solution = new();

        public static IEnumerable<object[]> DuplicateTestData =>
            new List<object[]>
            {
                new object[] { new[] { 1, 2, 3, 4, 5 }, false },
                new object[] { new[] { 1, 2, 3, 4, 1 }, true },
                new object[] { new[] { 99, 100, 101, 99 }, true },
                new object[] { new[] { 10 }, false },
                new object[] { new int[0], false }
            };

        [Xunit.Theory]
        [MemberData(nameof(DuplicateTestData))]
        public void HasDuplicate_ReturnsExpectedResult(int[] input, bool expected)
        {
            var result = _solution.ContainsDuplicate(input);
            Assert.Equal(expected, result);
        }
    }
}
