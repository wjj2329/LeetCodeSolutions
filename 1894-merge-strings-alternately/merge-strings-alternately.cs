public class Solution {
    public string MergeAlternately(string word1, string word2) {
        bool word1smaller= word1.Length<word2.Length?true:false;
        int count = word1smaller?word1.Length:word2.Length;
        StringBuilder sb = new StringBuilder();
        for(int i =0; i<count; i++){
            sb.Append(word1[i]);
            sb.Append(word2[i]);
        }
        if(word1smaller){
            sb.Append(word2.Substring(count));
        }else{
            if(word1.Length>word2.Length){
                sb.Append(word1.Substring(count));
            }
        }
        return sb.ToString();
    }
}