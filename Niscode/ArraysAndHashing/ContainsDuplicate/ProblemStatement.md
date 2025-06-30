# Contains Duplicate

Given an integer array `nums`, return `true` if any value appears more than once in the array, otherwise return `false`.

## Example 1:

**Input:**  
`nums = [1, 2, 3, 3]`

**Output:**  
`true`

## Example 2:

**Input:**  
`nums = [1, 2, 3, 4]`

**Output:**  
`false`

<details>
<summary>Recommended Time & Space Complexity</summary>

You should aim for a solution with **O(n)** time and **O(n)** space, where n is the size of the input array.

</details>

<details>
<summary>Hint 1</summary>

A brute force solution would be to check every element against every other element in the array. This would be an **O(n²)** solution. Can you think of a better way?

</details>

<details>
<summary>Hint 2</summary>

Is there a way to check if an element is a duplicate without comparing it to every other element? Maybe there's a data structure that is useful here.

</details>

<details>
<summary>Hint 3</summary>

We can use a hash data structure like a hash set or hash map to store elements we've already seen. This will allow us to check if an element is a duplicate in constant time.

</details>
