public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0;
        int left = 0;
        int right = 1;

        while (right < prices.Length){
            if (prices[right]>prices[left]){
                profit = Math.Max(prices[right]-prices[left],profit);
            }
            else
            {
                left = right;
            }
            right++;
        }

        return profit;
        
    }
}
