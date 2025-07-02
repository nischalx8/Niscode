namespace Niscode.ArraysAndHashing.ProductsOfArrayExceptSelf;

public class Solution
{
    //Core Idea: No division, so think of how we can identify products of the array members without the number at specific index.
    //Prefix Product & Postfix Products help us get the expected output.
    public int[] ProductExceptSelf(int[] nums)
    {
        //The result array. Same length as the input array.
        var res = new int[nums.Length];

        //Initialise the result array with 1 at each index.
        Array.Fill(res, 1);

        //Initialise the prefix & postfix product as 1.
        var prefix = 1;
        var postfix = 1;

        //First pass: From start to end to calculate prefix products.
        for (int i = 0; i < nums.Length; i++)
        {
            //The result array is used to store prefix products.
            // Store current prefix product in res[i]
            res[i] = prefix;
            //Update the prefix for the next iteration by multiplying it with the number at index i.
            prefix *= nums[i];
        }
        //Iterations: For [1,2,3,4] input nums, res would be:
        //i[0] -> 1 ,res: [1,1,1,1] -> [1,1,1,1], prefix: 1 -> 1 (prefix = prefix * num[i])
        //i[1] -> 2 ,res: [1,1,1,1] -> [1,1,1,1], prefix: 1 -> 2
        //i[2] -> 3 ,res: [1,1,1,1] -> [1,1,2,1], prefix: 2 -> 6
        //i[3] -> 4 ,res: [1,1,2,1] -> [1,1,2,6], prefix: 6 -> 24

        //Another pass to get the postfix products.
        //Since first pass already has prefix products, we can multiply number at index i with postfix
        //product to get result to be stored at index i.
        //For [1,2,3,4], res here would be: [1,1,2,6]
        for (var i = nums.Length - 1; i >= 0; i--)
        {
            res[i] *= postfix;
            postfix *= nums[i];
        }
        //Iterations: 
        //i[3] -> 4, res: [1,1,2,6] -> [1,1,2,6], postfix: 1 -> 4 (postfix = postfix * num[i])
        //i[2] -> 3, res: [1,1,2,6] -> [1,1,8,6], postfix: 4 -> 12
        //i[1] -> 2, res: [1,1,8,6] -> [1,12,8,6], postfix: 12 -> 24
        //i[0] -> 1, res: [1,12,8,6] -> [24,12,8,6], postfix: 24 -> 24

        
        return res;
    }
}