public class Solution {
    public string IntToRoman(int num) {

        StringBuilder sb = new StringBuilder();
        string[] roman = {"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};
        int[] integer = {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};
        
        for (int i = 0; i < 13; i++)
        {
            while (num >= integer[i])
            {
                num -= integer[i];
                sb.Append(roman[i]);
            }
        }
        string res = sb.ToString();
        return res;
    }
}