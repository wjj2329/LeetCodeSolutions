public class Solution {
    public int NumberOfMatches(int n) {
        int count = 0; 
        while(n/2>0){
            int remain = n%2;
            n = n/2;
            count+=n;
            n+=remain;
        }
        return count; 
    }
}