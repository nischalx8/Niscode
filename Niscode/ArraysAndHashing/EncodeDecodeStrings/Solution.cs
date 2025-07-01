namespace Niscode.ArraysAndHashing.EncodeDecodeStrings;

public class Solution {
    //Core Idea: Encode the string such that we can identify where to split and how much to split by.
    //Encode: At the start of each string, append the length of the string followed by the delimiter.
    //Decode: Create two pointers. One that tracks where a string starts, another where it ends.
    //To track end, increase second pointer until occurence of delimiter.
    //Find the difference between the starting index and the index where we encountered the delimiter,
    //which gives us the length of the string.  
    //Slide the start pointer for each new string after each pass.
    public string Encode(IList<string> strs) {
        var res = "";
        foreach (var s in strs)
        {
            res += s.Length + "#" + s;
        }
        return res;
    }

    public List<string> Decode(string s)
    {
       var res = new List<string>();
       //Start at 0
       var i = 0;
       //Ensure pointer is within bounds.
       while (i < s.Length)
       {
           //Initialise second pointer at i, use this to find end index of the string.
           var j = i;
           
           //Increase pointer until the occurence of the delimiter.
           //(Think of strings of double/triple digit lengths)
           while (s[j] != '#')
           {
               j++;
           }
           //Extract the length stored between the i'th and the j-1'th characters of the string.
           var length = int.Parse(s.Substring(i, j-i));
           i = j + 1; //Advance 'i' past the delimiter to the start of the actual string content.
           j = i + length; // Set 'j' to mark the end of the current string.
                           // 'j' will be the index one past the last character of the string.
                           
           // Extract the actual string using the calculated length.
           // The substring starts at 'i' and has 'length' characters.                           
           res.Add(s.Substring(i, length));
           
           // Move 'i' to the beginning of the next encoded segment (i.e., to 'j').
           // This sets up 'i' for the next iteration of the while loop.
           i = j;
       }
       return res;
    }
}