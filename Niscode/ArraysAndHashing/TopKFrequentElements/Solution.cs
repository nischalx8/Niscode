namespace Niscode.ArraysAndHashing.TopKFrequentElements;

public class Solution
{
    //Core Idea: Count occurence of numbers, map frequency & list of numbers for that frequency (Bucket Sort)
    //Iterate backwards from length of numbers to k & check frequency for numbers.
    public int[] TopKFrequent(int[] nums, int k)
    {
        //Count how many times each unique number appears.
        var count = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (count.ContainsKey(num))
            {
                count[num]++;
            }
            else
            {
                count[num] = 1;
            }
        }
        
        //Bucket Sort: Organise by Frequency
        //Index represents frequency
        //List at index: All numbers that appeared with that specific frequency.
        var frequency = new List<int>[nums.Length + 1]; //If nums.Length is the highest possible frequency, and you want
                                                        //to use that frequency as an index, you need an
                                                        //array of size nums.Length + 1.
        
        //Initialise an empty list at all positions through 0-n                                                    
        for (var i = 0; i < frequency.Length; i++)
        {
            frequency[i] = [];
        }
        
        foreach (var entry in count)
        {
            //For each number and its count, add the number to the list
            //at the index corresponding to its frequency.
            frequency[entry.Value].Add(entry.Key);
        }
        
        var res = new int[k]; //This will store our final k most frequent numbers
        var index = 0; //Tracks how many numbers we've added to 'res'
        
        //Iterate from the highest possible frequency (nums.Length) down to 1.
        // <k because we only want k frequent items.
        for (int i = frequency.Length - 1; i > 0 && index < k; i--)
        {
            //For each frequency 'i', check if there are any numbers with that frequency
            foreach (var n in frequency[i])
            {
                res[index++] = n; // Add the number to the result array
                if (index == k) return res; //If we have k numbers, we are done.
            }
        }
        return res; //Unreachable since k is always valid.
    }
}