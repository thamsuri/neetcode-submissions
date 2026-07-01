class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        my_dict = {}
        if len(s) != len(t):
            return False
        else:
            for ch in s:
                my_dict[ch] = 1 + my_dict.get(ch,0)
         
            for ch in t:
                my_dict[ch] = my_dict.get(ch,0) -1

            for key, value in my_dict.items():
                if (value != 0):
                    return False
                
        return True

        