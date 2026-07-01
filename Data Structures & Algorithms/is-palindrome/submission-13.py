class Solution:
    def isPalindrome(self, s: str) -> bool:
        start = 0
        end = len(s)-1

        while (start < end):
            print(f'Begi...{start} {s[start]}.... {end} {s[end]}')
            while start < end and  not (s[start].isalnum()):
                start += 1
            while end > start and  not (s[end].isalnum()):
                end -= 1

            #if start > end:
            #    return True
            print(f'skip...{start} {s[start]}.... {end} {s[end]}')

            if (s[start].lower() == s[end].lower()):
                #print(f'Here {start} {s[start]}.... {end} {s[end]}')
                start +=1
                end -=1
            else:
                print(f'else {start} {s[start]}.... {end} {s[end]}')
                return False

        return True