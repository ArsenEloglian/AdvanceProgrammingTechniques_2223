'''
Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
You must implement a solution with a linear runtime complexity and use only constant extra space.
Input: nums = [4,1,2,1,2]
Output: 4
'''

class Solution:
    def singleNumber(self, nums: List[int]) -> int:
        con = Counter(nums)
        
        for i in con:
            if con[i] == 1:
                return i
