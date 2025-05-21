public class Solution {
    public int MinOperations(string s) {
        int count = 0;
        int count2 = 0;  
        for(int i = 0; i<s.Length; i++){
            if(i%2==1){
                if(s[i]=='0'){
                    count++;
                    }
                }else{
                    if(s[i]=='1'){
                        count++;
                    }
                }
            }
            for(int i = 0; i<s.Length; i++){
                if(i%2==0){
                    if(s[i]=='0'){
                        count2++;
                    }
                }else{
                    if(s[i]=='1'){
                        count2++;
                    }
                }
            }
        
        return Math.Min(count, count2);
    }
}