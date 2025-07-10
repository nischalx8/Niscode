using Niscode.ArraysAndHashing.ValidSudoku;

namespace Niscode.Tests.ArraysAndHashing;

public class ValidSudokuTests
{
    private readonly Solution _solution = new();
    
    #region TestData
    public static IEnumerable<object[]> TestData =>
        new List<object[]>
        {
            new object[]
            {
                new []
                {
                    new [] { '1','2','.','.','3','.','.','.','.' },
                    new [] { '4','.','.','5','.','.','.','.','.' },
                    new [] { '.','9','8','.','.','.','.','.','3' },
                    new [] { '5','.','.','.','6','.','.','.','4' },
                    new [] { '.','.','.','8','.','3','.','.','5' },
                    new [] { '7','.','.','.','2','.','.','.','6' },
                    new [] { '.','.','.','.','.','.','2','.','.' },
                    new [] { '.','.','.','4','1','9','.','.','8' },
                    new [] { '.','.','.','.','8','.','.','7','9' }
                },
                true
            },
            new object[]
            {
                new []
                {
                    new [] { '1','2','.','.','3','.','.','.','.' },
                    new [] { '4','.','.','5','.','.','.','.','.' },
                    new [] { '.','9','1','.','.','.','.','.','3' },
                    new [] { '5','.','.','.','6','.','.','.','4' },
                    new [] { '.','.','.','8','.','3','.','.','5' },
                    new [] { '7','.','.','.','2','.','.','.','6' },
                    new [] { '.','.','.','.','.','.','2','.','.' },
                    new [] { '.','.','.','4','1','9','.','.','8' },
                    new [] { '.','.','.','.','8','.','.','7','9' }
                },
                false
            }
        };
    #endregion

    [Theory]
    [MemberData(nameof(TestData))]
    public void ValidSudokuTest(char[][] input, bool expected)
    {
        var result = _solution.IsValidSudoku(input);
        Assert.Equal(expected, result);
    }
}