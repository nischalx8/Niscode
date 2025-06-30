namespace Niscode.ArraysAndHashing.GroupAnagrams;

public class Solution
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        // Create a Dictionary where the key is a string representing character frequency,
        // and the value is a list of anagram strings.
        var res = new Dictionary<string, List<string>>();
        
        //Iterate over all the input strings.
        foreach (var str in strs)
        {
            // Since input strings contain only lowercase English letters, we use a fixed array of length 26.
            var count = new int [26];
            foreach (var c in str)
            {
                // Update the frequency array with counts of each character in the current string.
                count[c - 'a']++;
            }
            
            // Convert the frequency array to a string key for proper value-based dictionary lookup.
            var key = string.Join(",", count);
            
            // If the key doesn't exist in the dictionary, initialise a new list to store anagrams.
            if (!res.ContainsKey(key))
            {
                res[key] = [];
            }
            // Add the current string to the list of anagrams corresponding to this frequency key.
            res[key].Add(str);
        }
        //Return the values that are now stored lists of anagrams.
        return res.Values.ToList();
    }
}