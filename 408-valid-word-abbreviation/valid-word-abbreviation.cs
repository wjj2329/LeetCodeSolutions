public class Solution {
    public bool ValidWordAbbreviation(string word, string abbr) {
        int count = 0;
        StringBuilder num = new StringBuilder();
        for(int i =0; i<abbr.Length; i++){
            if(char.IsDigit(abbr[i])){
                num.Append(abbr[i]);
            }else{
                if(num.Length>0){
                    if(num[0]=='0'){
                        return false;
                    }else{
                        int s = Int32.Parse(num.ToString());
                        count+=s;
                    }
                    num = new StringBuilder();
                }
                if(count>=word.Length || word[count]!=abbr[i]){
                    return false;
                }
                count++;
            }
        }
        if(num.Length>0){
                    if(num[0]=='0'){
                        return false;
                    }else{
                        int s = Int32.Parse(num.ToString());
                        count+=s;
                    }
                    num = new StringBuilder();
        }
        return count == word.Length;
    }
}