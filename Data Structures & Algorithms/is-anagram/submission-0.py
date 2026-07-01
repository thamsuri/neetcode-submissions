class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        my_dict = {}
        if len(s) != len(t):
            return False
        else:
            for ch in s:
                #print(f".....{ch}")
                if my_dict.get(ch) is not None:                    
                    my_dict[ch] = my_dict[ch] + 1;
                    #print(f"If {ch}: {my_dict[ch]}")
                else:
                    #print(f"Else {ch}: {my_dict[ch]}")
                    my_dict[ch] = 1

           # for key, value in my_dict.items():
            #    print(f"{key}: {value}")

            for ch in t:
                if my_dict.get(ch) is not None:
                    my_dict[ch] = my_dict[ch] - 1;
                else:
                    return False

            for key, value in my_dict.items():
                #print(f"{key}: {value}")
                if (value != 0):
                    return False
                
        return True

        