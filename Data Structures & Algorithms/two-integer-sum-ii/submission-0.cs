public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int start =0;
        int end = numbers.Length-1;

        List<int> dynamicList = new List<int>();

        while (start < end){
            if (numbers[start] + numbers[end]  > target )
            {
                end--;
            }
            else if (numbers[start] + numbers[end]  < target){
                start++;
            }
            else
            {
                dynamicList.Add(start + 1);
                dynamicList.Add(end + 1);
                break;
            }
        }

        return dynamicList.ToArray();
        
    }
}
