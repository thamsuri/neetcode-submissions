public class Solution {
    public int ClimbStairs(int n) {  

        if (n <= 2) return n;
        
        int[] table = new int[n+1];
        Array.Fill(table, 0)   ;        

        table[1] = 1;
        table[2] = 2;

        for (int i = 3;i<n+1;i++){
            table[i] = table[i-1]+table[i-2];
        }
        return table[n];
        
    }
}
