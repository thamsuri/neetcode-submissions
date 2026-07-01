public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        Dictionary<char,int> chlst = new Dictionary<char,int>();

        foreach (var c in s){
            if (chlst.ContainsKey(c)) chlst[c]++;
            else chlst[c] = 1;
        }

        foreach (var c in t){
            if (!chlst.ContainsKey(c)) return false;
            chlst[c]--;
        }

        foreach( KeyValuePair<char, int> kvp in chlst )
        {
            if (kvp.Value != 0) return false;
        }

        return true;
    }
}
