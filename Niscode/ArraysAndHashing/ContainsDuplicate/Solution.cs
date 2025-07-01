namespace Niscode.ArraysAndHashing.ContainsDuplicate;

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        //Create a set to hold numbers as we iterate.
        var map = new HashSet<int>();
        var containsDuplicate = false;
        //Iterate over the input numbers
        foreach (var t in nums)
        {
            //Check for existence in the set. If it exists, we have a duplicate.
            if (!map.Add(t))
            {
                containsDuplicate = true;
            }
        }
        //If no items occur again in the set after iterating through, we don't have duplicates.
        return containsDuplicate;
    }
}