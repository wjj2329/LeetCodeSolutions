/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        int upper = n;
        int lower = 0;
        while(lower<=upper){
            int num = lower+(upper - lower) /2;
            int result = guess(num);
            if(result == 0){
                return num;
            }
            if(result == -1){
                upper =num-1;
            }
            if(result == 1){
                lower = num+1;
            }
        }
        return -1;
    }
}