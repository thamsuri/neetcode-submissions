public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> freq = new Dictionary<int,int>();

        foreach (int ele in nums){
            if (freq.ContainsKey(ele)){
                freq[ele]++;
            }
            else 
            {
                freq[ele]=1;
            }
        }

        List<int>[] bucket = new List<int>[nums.Length+1];
        for (int i = 0; i < bucket.Length; i++) {
            bucket[i] = new List<int>();
        }


        foreach (KeyValuePair<int,int> pair in freq)
        {
            //Console.WriteLine (pair.Key + " " + pair.Value);
            bucket[pair.Value].Add(pair.Key);
        }

        int[] res = new int[k];
        int index = 0;
        for (int i = bucket.Length-1; i >= 0; i--) {
            foreach (var e in bucket[i])
            {
               // Console.WriteLine($" {i} ---> {e}");
                res[index] = e;
                if (index+1 == k) return res;
                index++;
            }
        }        
        
        return new int[0];
    }
}
