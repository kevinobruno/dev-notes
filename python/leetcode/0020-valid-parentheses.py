# 20. Valid Parentheses
# https://leetcode.com/problems/valid-parentheses/

# O(n)
class Solution:
    def isValid(self, s: str) -> bool:
        close_to_open = {')': '(', ']': '[', '}': '{'}
        stack = []

        for c in s:
            if c in close_to_open:
                if stack and stack[-1] == close_to_open[c]:
                    stack.pop()
                else:
                    return False
            else:
                stack.append(c)

        return True if not stack else False
