/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
const twoSum = function (nums, target) {

  for (let a = 0; a < nums.length; a++) {
    for (let i = a + 1; i < nums.length; i++) {
      if (nums[a] + nums[i] === target) return [a, i]
    }
  }

};
