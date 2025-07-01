# Encode and Decode Strings

Design an algorithm to encode a list of strings to a single string. The encoded string is then decoded back to the original list of strings.

Please implement `encode` and `decode`.

## Example 1:

**Input:**  
`["do", "re", "mi", "fa"]`

**Output:**  
`["do", "re", "mi", "fa"]`

## Example 2:

**Input:**  
`["we", "say", ":", "yes"]`

**Output:**  
`["we", "say", ":", "yes"]`

## Constraints:

- `0 <= strs.length < 100`
- `0 <= strs[i].length < 200`
- `strs[i]` contains only UTF-8 characters

<details>
<summary>Recommended Time & Space Complexity</summary>

You should aim for a solution with **O(m)** time for each `encode()` and `decode()` call and **O(m + n)** space, where `m` is the sum of lengths of all the strings and `n` is the number of strings.

</details>

<details>
<summary>Hint 1</summary>

A naive solution would be to use a non-ASCII character as a delimiter. Can you think of a better way?

</details>

<details>
<summary>Hint 2</summary>

Try to encode and decode the strings using a smart approach based on the lengths of each string. How can you differentiate between the lengths and any numbers that might be present in the strings?

</details>

<details>
<summary>Hint 3</summary>

We can use an encoding approach where we start with a number representing the length of the string, followed by a separator character (let's use `#` for simplicity), and then the string itself. To decode, we read the number until we reach a `#`, then use that number to read the specified number of characters as the string.

</details>
