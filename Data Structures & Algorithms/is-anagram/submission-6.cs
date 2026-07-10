public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        int[] count = new int[128];

        foreach(char c in s) count[c]++;

        foreach(char c in t) 
        {
            count[c]--;

            if (count[c] < 0) return false;
        }

        return true;

    }
}
