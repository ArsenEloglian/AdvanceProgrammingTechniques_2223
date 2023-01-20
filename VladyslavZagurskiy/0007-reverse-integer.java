class Solution {
    public int reverse(int x) {
            long diff= 0;
        while( x != 0){
            diff= diff*10 + x % 10;
            x= x/10;
            if( diff > Integer.MAX_VALUE || diff < Integer.MIN_VALUE){
                return 0;
            }
        }
        return (int) diff;
    }
}
