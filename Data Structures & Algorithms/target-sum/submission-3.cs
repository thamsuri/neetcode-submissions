public class Solution {
    public int FindTargetSumWays(int[] nums, int target) {

        var memo = new Dictionary<string, int>();
        return helper (0,0,nums,target,memo);
        
    }

    public int helper(int i, int current_sum,int[] nums,int target,Dictionary<string, int> memo){
        if (i == nums.Length){
            if (current_sum == target){
                return 1;
            }
            else
            {
                return 0;
            }
        }

        var key = $"{i},{current_sum}";
        if (memo.ContainsKey(key))
        {
            return memo[key];
        }

        memo[key] = (
            helper (i+1,current_sum+nums[i],nums,target,memo) +    
            helper (i+1,current_sum-nums[i],nums,target,memo)
            );
        return memo[key];
    }
}