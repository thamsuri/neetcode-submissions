public class Solution {
    public int MinPathSum(int[][] grid) {

        int m = grid.Length;
        int n = grid[0].Length;
        int[,] table = new int[m, n];

        

        table[0,0] = grid[0][0];

        for (int i = 1; i<m;i++){           
            table[i,0] = grid[i][0] + table[i-1,0];
        }

        for (int i = 1; i<n;i++){           
            table[0,i] = grid[0][i] + table[0,i-1];
        }

        for (int i = 1; i < m; i++)
        {
            for (int j = 1; j < n; j++)
            {
                table[i,j] = grid[i][j] + Math.Min(  table[i,j-1],  table[i-1,j]);
            }
            Console.WriteLine();
        }


        // for (int i = 0; i < m; i++)
        // {
        //     for (int j = 0; j < n; j++)
        //     {
        //         Console.Write(table[i,j] + "\t");
        //     }
        //     Console.WriteLine();
        // }

        return table[m-1,n-1];
        
    }
}