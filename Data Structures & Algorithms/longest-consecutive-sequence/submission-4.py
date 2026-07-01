class Solution:
    def longestConsecutive(self, nums: List[int]) -> int:
        result=[]
        tempRes=[]
        if len(nums) ==  1:
            return len(nums)
        for num in nums:
            if len(tempRes) > len(result):
                result=tempRes
            tempRes = []
            while (num in nums):
                tempRes.append(num)
                num = num + 1
            
        if len(tempRes) > len(result):
                result=tempRes

        return len(result)
        