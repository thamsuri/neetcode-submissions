public class Solution {
    public int LengthOfLIS(int[] nums) {
        int n = nums.Length;
        int[] dp = new int[n];
        Array.Fill(dp,1);

        for (int i = 0; i<n;i++){
            for (int j = 0; j<i;j++){
                if (nums[j] < nums[i])
                {
                    //Console.WriteLine(dp[j] +" fff" + dp[i]);
                    dp[i] = Math.Max(dp[i],dp[j]+1);
                }                    
            }
        }

        return dp.Max();
    }
}
