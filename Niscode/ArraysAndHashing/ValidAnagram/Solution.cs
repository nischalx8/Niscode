namespace Niscode.ArraysAndHashing.ValidAnagram;

public class Solution
{
    // public bool IsValidAnagram(string s, string t)
    // {
    //     var firstChars = s.ToCharArray();
    //     var secondChars = t.ToCharArray();
    //     var firstCharsMap = GetCharacterFrequencies(firstChars);
    //     var secondCharsMap = GetCharacterFrequencies(secondChars);
    //     
    //     if(firstChars.Length != secondChars.Length) return false;
    //     
    //     foreach (var ch in firstCharsMap)
    //     {
    //         secondCharsMap.TryGetValue(ch.Key, out var secondStringCharFrequency);
    //         if (ch.Value != secondStringCharFrequency) return false;
    //     }
    //     return true;
    // }
    //
    // private Dictionary<char,int> GetCharacterFrequencies(char[] chars)
    // {
    //     var charsMap = new Dictionary<char, int>();
    //     foreach (var t in chars)
    //     {
    //         if (!charsMap.TryAdd(t, 1))
    //         {
    //             charsMap[t]++;
    //         }
    //     }
    //     return charsMap;
    // }

    public bool IsValidAnagram(string s, string t)
    {
        //Anagrams must have the same length
        if(s.Length != t.Length) return false;
        
        // The problem constraint says the strings contain only lowercase English letters.
        // We'll use an array of size 26 to track the frequency of each character using their ASCII values.
        var count = new int[26];

        // Iterate over both strings simultaneously, comparing characters at the same index.
        for (var i = 0; i < s.Length; i++)
        {
            // Increase the count for the character from s, and decrease the count for the character from t.
            // If the strings are anagrams, all counts should cancel out to zero.
            count[s[i] - 'a']++;
            count[t[i] - 'a']--;
        }
    
        // Check if all values in the count array are zero.
        // Non-zero values mean the character frequencies don't match, so the strings aren't anagrams.
        foreach (var val in count)
        {
            if(val != 0) return false;
        }
        return true;
    }
}