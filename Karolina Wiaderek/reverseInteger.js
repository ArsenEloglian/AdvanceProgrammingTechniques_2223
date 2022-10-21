/**
 * Function calculates ranges
 * @returns {Record<string, number>}
 */
const calculateRanges = () => ({
  lower: -Math.pow(2, 31),
  upper: Math.pow(2, 31) - 1,
})

/**
 * Function checks if given number is out of scope
 * @param {Number} number
 * @param {Record<string, number>} param1
 * @returns {boolean}
 */
const checkIfOutOfScope = (number, { lower, upper }) => number < lower || number > upper

/**
 * Function reverse the number
 * Provides initial checker of the range and final one before returning value
 * @param {number} number
 * @return {number}
 */
const reverse = (number) => {
  const ranges = calculateRanges()

  if (checkIfOutOfScope(number, ranges)) return 0

  const checkIfNegative = number < 0 ? true : false

  const reversed = +Math.abs(number).toString().split('').reverse().join('')

  if (checkIfOutOfScope(reversed, ranges)) return 0

  return checkIfNegative ? -Math.abs(reversed) : reversed
};