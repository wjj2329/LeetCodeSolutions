public class Solution {
    public string CompressedString(string word) {
        int i = 0;
        StringBuilder sb = new StringBuilder();
        while(i<word.Length){
            int count = 1;
            while(i<word.Length-1&& word[i]==word[i+1]){
                i++;
                count++;
            }
            i++;
            while(count>9){
                sb.Append(9);
                sb.Append(word[i-1]);
                count-=9;
            }
            sb.Append(count);
            sb.Append(word[i-1]);
        }
        return sb.ToString();
    }
}