namespace Niscode.ArraysAndHashing.ValidSudoku;

public class Solution
{
    // Core Idea: Validate Sudoku by leveraging bit manipulation for constant-time
    // checks. Each row, column, and 3x3 square maintains a bitmask where a set bit
    // indicates a digit's presence, allowing quick duplicate detection.
    public bool IsValidSudoku(char[][] board)
    {
        //Create bitmask for each row, column & squares
        var rows = new int[9];
        var cols = new int[9];
        var squares = new int[9];

        for (var r = 0; r < 9; r++)
        {
            for (var c = 0; c < 9; c++)
            {
                //'.' means the cell is empty. No validations to be performed.
                if(board[r][c] == '.') continue;
                
                //Bitmask to index. '1' -> 0, '8' -> 7
                var val = board[r][c] - '1';
                
                // Calculate the index of the 3x3 square this cell belongs to.
                // (r / 3) determines the 3x3 square's row block (0, 1, or 2).
                // (c / 3) determines the 3x3 square's column block (0, 1, or 2).
                // (r / 3) * 3 + (c / 3) gives a unique index from 0 to 8 for the square.
                var squareIndex = ((r / 3) * 3 + (c / 3));
                
                //Check the bitmasked value in the row/column/squares indices
                if ((rows[r] & (1 << val)) > 0 ||
                    (cols[c] & (1 << val)) > 0 ||
                    (squares[squareIndex] & (1 << val)) > 0)
                {
                    // If any of these conditions are true, it means a duplicate digit is found,
                    // so the Sudoku is invalid.
                    return false;
                }
                
                // Mark the current digit (val) as seen in:
                // 1. The current row's bitmask
                // 2. The current column's bitmask
                // 3. The current 3x3 square's bitmask
                
                // The bitwise OR operator '|=' sets the specified bit in the mask.
                // For example, if rows[r] was 00000000 and val is 0 ('1'),
                // rows[r] |= (1 << 0) will make rows[r] = 00000001.
                // If val is 2 ('3'), rows[r] |= (1 << 2) will make rows[r] = 00000101.
                rows[r] |= (1 << val);
                cols[c] |= (1 << val);
                squares[squareIndex] |= (1 << val);
            }
        }
        return true;
    }
}