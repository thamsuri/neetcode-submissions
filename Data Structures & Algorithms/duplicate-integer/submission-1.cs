public class Solution {
    public bool hasDuplicate(int[] nums) {

        if (nums.Length != nums.Distinct().Count())
            return true;
        else
            return false;
        
    }
}