public class Solution {
    public int ClimbStairs(int n) {  

        if (n == 1) return 1;
        
        int[] table = new int[n+1];
        Array.Fill(table, 0)   ;        

        table[1] = 1;
        table[2] = 2;

        for (int i = 3;i<=n;i++){
            table[i] = table[i-2]+table[i-1];
            Console.WriteLine ( $"Hello {i}  {table[i]}");
        }
        return table[n];
        
    }
}
