public class Solution {
    public bool IsPalindrome(string s) {

        string result = Regex.Replace(s, "[^a-zA-Z0-9]", "");

        int left = 0;
        int right = result.Length -1;


        while (left < right){
            if (result[left].ToString().ToLower() != result[right].ToString().ToLower()) return false;

            left++;
            right--;            
        }

        return true;
        
    }
}
