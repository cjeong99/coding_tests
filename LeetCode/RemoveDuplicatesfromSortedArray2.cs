
public class Solution {
    //integer array nums sorted in non-decreasing order
    public int RemoveDuplicates(int[] nums) {
        //remove duplicates in-place such that each element appears at most twice
        //and return the new length
        //topics - Array, Two Pointers
        //time complexity - O(n)
        //space complexity - O(1)
        
        for(int i=0; i<nums.Length; i++){

            //pointer and pointer num and counter
            var curPointer = 0;
            if(i+1 >= nums.Length){
                break;
            }
            if(nums[i] == nums[i+1]){
                curPointer++;
            }
            
            
            //if the current element is not equal to the next element
            //i+1 should not exceed the length of the array
            if(i+1 >= nums.Length){
                break;
            }
            if(nums[i] != nums[i+1]){
                nums[i+2] = nums[i+1];
                i++;
            }
        }
    }
}
