# 125. Valid Palindrome
# https://leetcode.com/problems/valid-palindrome/

# O(n)
class Solution:
    def isPalindrome(self, s: str) -> bool:
        word = ''.join([c for c in s if self.alphanum(c)])

        i = 0
        j = len(word) - 1

        while i < j:
            if word[i].lower() != word[j].lower():
                return False

            j -= 1
            i += 1

        return True

    def alphanum(self, c):
        return (
            ord('A') <= ord(c) <= ord('Z')
            or ord('a') <= ord(c) <= ord('z')
            or ord('0') <= ord(c) <= ord('9')
        )
