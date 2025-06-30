namespace Niscode.ArraysAndHashing.TwoSum;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        
        var dictionary = new Dictionary<int, int>();
        
        // The problem asks to find the indices of two numbers that add up to the target.
        // We use the difference (target - current number) to check if a complement exists.
        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];
            var complement = target - num;
            // If the complement (difference) exists in the dictionary,
            // we found two numbers that sum to the target: return their indices.
            if (dictionary.TryGetValue(complement, out var value))
            {
                return [value, i];
            }
            // Otherwise, add the current number and its index to the dictionary for future lookups.
            dictionary[num] = i;
        }
        throw new ArgumentException("No two sum solution");
    }
}