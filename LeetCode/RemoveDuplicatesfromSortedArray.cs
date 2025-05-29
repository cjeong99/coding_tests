public class Solution {
//integer array nums sorted in non-decreasing order
//remove duplicates in-place such that each element appears only once
//and return the new length
        public int RemoveDuplicates(int[] nums) {
        //return unique number of elements
        //start from the first element
        //compare the current element with the next element
        //if they are not equal, increment the pointer and assign the next element to the current element
        //increment the pointer
        //return the pointer
        //topics - Array, Two Pointers
        //time complexity - O(n)
        //space complexity - O(1)

        var curPointer = 0;
        for(int i=0; i<nums.Length; i++){
            //if the current element is not equal to the next element
            //i+1 should not exceed the length of the array
            if(i+1 >= nums.Length){
                break;
            }
            if(nums[i] != nums[i+1]){
                curPointer++;

                nums[curPointer] = nums[i+1];
            }
        }
        return curPointer+1;
    }
}