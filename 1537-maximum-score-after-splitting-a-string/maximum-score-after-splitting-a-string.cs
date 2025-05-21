public class Solution {
    public int CountNumberOfZeros(string s){
        int count = 0; 
        foreach(char c in s){
            if(c == '0'){
                count++;
            }
        }
        return count;
    }
    public int CountNumberOfOnes(string s){
        int count = 0; 
        foreach(char c in s){
            if(c == '1'){
                count++;
            }
        }
        return count;
    }
    public int MaxScore(string s) {
        int max = 0; 
        for(int i = 1; i<s.Length; i++){
            string part1 = s.Substring(0, i);
            string part2 = s.Substring(i, s.Length-i);
            max = Math.Max(max, CountNumberOfZeros(part1)+CountNumberOfOnes(part2));
        }
        return max;
    }
}