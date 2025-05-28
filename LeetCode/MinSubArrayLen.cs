public class Solution {
    public int MinSubArrayLen(int target, int[] nums)
    {
        //Minimum Size Subarray Sum
        //1. Understand the problem
        // an array of positive integer nums and a positive interger target
        //2. constraints and edge cases
        // no valid subarray -> all elemets add up to less than target
        // single element is greater than or equal to target
        // entire array needed
        // all nums are the same
        //3. Approach
        // Brute force approach: check all subarrays and their sums (for understanding)
        // time complexity: O(n^2) - it is slow for large arrays ( n up to 10 ^5)

        int n = nums.Length;
        int minLen = n + 1; // Initialize to a value larger than any possible subarray length
        int left = 0, sum = 0;
        for (int right = 0; right < n; right++)
        {
            sum += nums[right]; // Expand the window by adding the right element

            // Shrink the window from the left as long as the sum is greater than or equal to target
            while (sum >= target)
            {
                var aa = Math.
                minLen = Math.Min(minLen, right - left + 1); // Update the minimum length
                sum -= nums[left]; // Remove the leftmost element
                left++; // Move the left pointer to the right
            }
        }
        // If minLen was updated, return it; otherwise, return 0

        return minLen == n + 1 ? 0 : minLen; // If no valid subarray found, return 0
 

    }
}