# 217. Contains Duplicate
# https://leetcode.com/problems/contains-duplicate/

# O(n)
class Solution:
    def containsDuplicate(self, nums: List[int]) -> bool:
        obj = {}
        has_duplicate = False

        for num in nums:
            if obj.get(num):
                has_duplicate = True
                break

            obj[num] = 1

        return has_duplicate
