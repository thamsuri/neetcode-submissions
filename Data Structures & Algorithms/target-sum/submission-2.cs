public class Solution {
    public int FindTargetSumWays(int[] nums, int target) {

        return helper (0,0,nums,target);
        
    }

    public int helper(int i, int current_sum,int[] nums,int target){
        if (i == nums.Length){
            if (current_sum == target){
                return 1;
            }
            else
            {
                return 0;
            }
        }

        return (
            helper (i+1,current_sum+nums[i],nums,target) +    
            helper (i+1,current_sum-nums[i],nums,target)
            );
    }
}
