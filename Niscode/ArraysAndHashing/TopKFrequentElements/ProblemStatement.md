# Top K Frequent Elements

Given an integer array `nums` and an integer `k`, return the `k` most frequent elements within the array.

The test cases are generated such that the answer is always unique.

You may return the output in any order.

## Example 1:

**Input:**  
`nums = [1,2,2,3,3,3]`, `k = 2`

**Output:**  
`[2,3]`

## Example 2:

**Input:**  
`nums = [7,7]`, `k = 1`

**Output:**  
`[7]`

## Constraints:

- `1 <= nums.length <= 10⁴`
- `-1000 <= nums[i] <= 1000`
- `1 <= k <= number of distinct elements in nums`

<details>
<summary>Recommended Time & Space Complexity</summary>

You should aim for a solution with **O(n)** time and **O(n)** space, where `n` is the size of the input array.

</details>

<details>
<summary>Hint 1</summary>

A naive solution would be to count the frequency of each number and then sort the array based on each element’s frequency. After that, we would select the top `k` frequent elements. This would be an **O(n log n)** solution. Though this solution is acceptable, can you think of a better way?

</details>

<details>
<summary>Hint 2</summary>

Can you think of an algorithm which involves grouping numbers based on their frequency?

</details>

<details>
<summary>Hint 3</summary>

Use the **bucket sort** algorithm to create `n` buckets, grouping numbers based on their frequencies from `1` to `n`. Then, pick the top `k` numbers from the buckets, starting from `n` down to `1`.

</details>
