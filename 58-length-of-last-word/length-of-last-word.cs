public class Solution {
    public int LengthOfLastWord(string s) {
        StringBuilder sb = new StringBuilder();
        int end = s.Length-1;
        while(s[end]==' '){
            end--;
        }
        while(end>=0 && s[end]!=' '){
            sb.Append(s[end]);
            end--;
        }
        return sb.Length;
    }
}