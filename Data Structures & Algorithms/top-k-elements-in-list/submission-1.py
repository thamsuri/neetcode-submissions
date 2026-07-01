class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        x = dict(Counter(nums))
        
        sortx = dict(sorted(x.items(),key=lambda item: item[1], reverse=True))
        count = 0
        result = []
        
        for key, value in sortx.items():
            if count == k:
                break
            result.append(key)
            count += 1

        
        return result