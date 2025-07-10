namespace Niscode.ArraysAndHashing.LongestConsecutiveSequence;

public class Solution
{
    ///Core Idea: Convert the input array to a set.
    /// Iterate over the input array. Check if the set contains the current number's "left neighbor" i.e. n-1.
    /// If it exists, it is not the start of the sequence.
    /// If it is a start of the sequence, iterate until the set contains it's last sequence number.
    public int LongestConsecutive(int[] nums)
    {
        var hashSet = new HashSet<int>(nums);
        var longest = 0;
        foreach (var num in nums)
        {
            //If it has a left neighbor, it is not the start of a sequence.
            //We should not be making a range from this number.
            if (hashSet.Contains(num - 1)) continue;
            //For the current sequence starter, initialise a length.
            var length = 0;
            //Iterate until we hit the "end" of the sequence, i.e. the last number in the sequence from this
            //sequence starter.
            while (hashSet.Contains(num + length))
            {
                length++;
            }
            //The longest sequence is now the maximum of the current length and the previous longest.
            longest = Math.Max(length, longest);
        }
        return longest;
    }
}