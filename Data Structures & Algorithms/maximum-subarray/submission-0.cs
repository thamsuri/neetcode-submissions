public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxAtEveryElement = nums[0];

        int res = nums[0];

        for (int i =1; i< nums.Length;i++){

            maxAtEveryElement = Math.Max(maxAtEveryElement+nums[i],nums[i]);

            res = Math.Max(res,maxAtEveryElement);
        }

        return res;
        
    }
}
