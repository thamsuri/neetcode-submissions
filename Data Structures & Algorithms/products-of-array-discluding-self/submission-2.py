from functools import reduce
from typing import List
class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        result =[]
        for index,num in enumerate(nums):
            filtered = [value for i, value in enumerate(nums)]
            filtered.pop(index)
            
            product = reduce(lambda x, y: x * y, filtered)
            result.append(product)

        return result
        