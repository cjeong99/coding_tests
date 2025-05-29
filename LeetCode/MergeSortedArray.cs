
        //Integer Array nums1 and nums2 are sorted in non-decreasing order
        //interger m and n are the number of elements in nums1 and nums2 respectively
        //merge num1 and nums2 into one sorted array in non-decreasing order

        //topics - Array, Two Pointers, Sorting
public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {

        //start from the end of nums1 and nums2
        //compare the last elements of nums1 and nums2
        //put the larger element at the end of nums1
        //decrement the pointer of the array from which the element was taken
        //decrement the pointer of nums1
        int p1 = m - 1; // pointer to end of meaningful nums1
        int p2 = n - 1; // pointer to end of nums2
        int p = m + n - 1; // pointer to end of nums1 buffer space

        while (p1 >= 0 && p2 >= 0) {
            if (nums1[p1] > nums2[p2]) {
                nums1[p] = nums1[p1];
                p1--;
            } else {
                nums1[p] = nums2[p2];
                p2--;
            }
            p--;
        }

        // Copy remaining nums2 elements if any
        while (p2 >= 0) {
            nums1[p] = nums2[p2];
            p2--;
            p--;
        }
    }
}