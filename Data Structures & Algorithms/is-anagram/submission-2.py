class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        my_dict = {}
        if len(s) != len(t):
            return False
        else:
            for ch in s:
                my_dict[ch] = 1 + my_dict.get(ch,0)
               # if my_dict.get(ch) is not None:                    
                #    my_dict[ch] = my_dict[ch] + 1;
                #else:
                #    my_dict[ch] = 1
         
            for ch in t:
                if my_dict.get(ch) is not None:
                    my_dict[ch] = my_dict[ch] - 1;
                else:
                    return False

            for key, value in my_dict.items():
                if (value != 0):
                    return False
                
        return True

        