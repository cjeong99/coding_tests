public class Solution {
    public bool IsSubsequence(string s, string t)
    {
        //1. understand the problem
        // given two strings s and t
        // i can delete zero or more characters from t but cannot rearrange them
        //2.constraints and edge cases
        //s can be empty
        //t can be large
        //3.Approach
        // two-pointer approach
        int i = 0;
        foreach (char c in t)
        {
            if (i < s.Length && c == s[i])
            {
                i++;
            }

        }
        return i == s.Length;
        // tow-pointer approach is good for one or a few queries but if we have many different s queries, and t is big. the approach is not efficient
        // beter approach is to use a hash table ( hashmap, dictionary)

    }
}