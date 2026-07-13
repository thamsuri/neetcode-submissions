public class Solution {
    public void Rotate(int[][] matrix) {
        int l = 0;
        int r = matrix[0].Length-1;
        Console.WriteLine(l + " " + r);

        while (l<r){
            for (int i =0; i<(r-l);i++){
                int top =l;
                int bottom = r;

                int temp = matrix[top][l+i];

                matrix[top][l+i] = matrix[bottom-i][l];

                matrix[bottom-i][l] = matrix[bottom][r-i];

                matrix[bottom][r-i] = matrix[top+i][r];

                matrix[top+i][r] = temp;
            }           

            l++;
            r--;
        }

        
    }
}
