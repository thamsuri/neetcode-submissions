public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> map = new Dictionary<int,int>();

        for (int i=0; i<nums.Length; i++){
            var lookingKey = target - nums[i];

            int index;
            if (map.TryGetValue(lookingKey, out index))
            {                
                return new int[] {index, i};
            }
            else
            {                
                map[nums[i]] = i;
            }

        }

        return new int[0];
    }
}
