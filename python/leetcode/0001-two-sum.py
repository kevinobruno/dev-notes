# 1. Two Sum
# https://leetcode.com/problems/two-sum/

# O(n^2)
class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        r = []

        for i in range(len(nums)):
            for j in range(i + 1, len(nums)):
                if nums[i] + nums[j] == target:
                    r.append(i)
                    r.append(j)

        return r


# O(n)
class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        prev_map = {}  # value -> index
        r = []

        for i, n in enumerate(nums):
            diff = target - n

            if diff in prev_map:
                return [prev_map[diff], i]
            
            prev_map[n] = i
