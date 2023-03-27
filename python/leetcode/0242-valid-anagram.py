# 242. Valid Anagram
# https://leetcode.com/problems/valid-anagram/

class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        if len(s) != len(t):
            return False
        
        chars_s = {}
        chars_t = {}

        for i in range(len(s)):
            chars_s[s[i]] = 1 + chars_s.get(s[i], 0)
            chars_t[t[i]] = 1 + chars_t.get(t[i], 0)

        return chars_s == chars_t
