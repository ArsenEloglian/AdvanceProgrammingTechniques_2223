/**
 *
Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.

The overall run time complexity should be O(log (m+n)).

Example 1:

  Input: nums1 = [1,3], nums2 = [2]
  Output: 2.00000
  Explanation: merged array = [1,2,3] and median is 2.

Example 2:

  Input: nums1 = [1,2], nums2 = [3,4]
  Output: 2.50000
  Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.
  */

/**
 * @param {number[]} nums1
 * @param {number[]} nums2
 * @return {number}
 */

const getIndex = (array) => Math.floor(array.length / 2)

const findMedianSortedArrays = function (nums1, nums2) {
  const size = nums1.length + nums2.length

  if (size == 0) return null
  if (size == 1) return nums1.length > 0 ? nums1[0] : nums2[0]

  const concatedArray = nums1.concat(nums2).sort((a, b) => a - b)

  const index = getIndex(concatedArray)

  // is odd
  if (concatedArray.length % 2 == 1)
    return concatedArray[index]

  return (concatedArray[index] + concatedArray[index - 1]) / 2
};